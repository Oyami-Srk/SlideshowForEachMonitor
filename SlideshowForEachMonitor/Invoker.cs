using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopWallpaper;

namespace SlideshowForEachMonitor
{
	internal class Invoker {
		Dictionary<string, string> monitorSlideshowPath;
		uint interval = 0; // in sec
		Dictionary<string, string[]> monitorWallpapers = new();
		Dictionary<string, int[]> monitorWallpaperShuffledList = new();
		Dictionary<string, uint> monitorWallpaperCurrentIndex = new();
		Dictionary<string, uint> monitorWallpaperTotalIndex = new();
		public const string SUPPORTED_EXTENSION = "*.jpg,*.JPG,*.png,*.PNG,*.jpeg,*.JPEG";
		IDesktopWallpaper wallpaper;
		object locker = new();
		Random rnd = new();
		System.Timers.Timer refreshTimer = new();
		System.Timers.Timer restoreTimer = new();


		public Invoker(Dictionary<string, string> lconfig, IDesktopWallpaper wallpaper) {
			monitorSlideshowPath = lconfig;
			Reshuffle();
			this.wallpaper = wallpaper;
			refreshTimer.AutoReset = true;
			refreshTimer.Enabled = true;
			refreshTimer.Elapsed += new System.Timers.ElapsedEventHandler((sender, e) => { Refresh(); });

			restoreTimer.AutoReset = false;
			restoreTimer.Enabled = true;
			restoreTimer.Interval = 800;
			restoreTimer.Elapsed += new System.Timers.ElapsedEventHandler((sender, e) => { WallpaperHistory.Restore(null); });
		}

		// interval is in seconds.
		public void Start(uint interval) {
			lock (locker) {
				if (interval == 0) {
					return;
				}
				this.interval = interval;
				refreshTimer.Interval = interval * 1000;
				refreshTimer.Start();
			}
			Refresh();
		}

		public void Stop() {
			lock (locker) {
				refreshTimer.Stop();
			}
		}

		public void SetInterval(uint interval) {
			if (interval == 0)
				return;
			lock (locker) {
				refreshTimer.Stop();
				refreshTimer.Interval = interval * 1000;
				refreshTimer.Start();
			}
			Refresh();
		}

		public void Close() {
			Stop();
			lock(locker) {
				refreshTimer.Close();
				restoreTimer.Close();
				WallpaperHistory.Restore(null);
			}
		}

		public void Reshuffle() {
			lock (locker) {
				foreach (var entry in monitorSlideshowPath) {
					var monitorId = entry.Key;
					string[] wallpapers = Directory.GetFiles(entry.Value, "*.*", SearchOption.TopDirectoryOnly)
						.Where(s => SUPPORTED_EXTENSION.Contains(Path.GetExtension(s).ToLower())).ToArray();
					monitorWallpaperShuffledList[monitorId] = Enumerable.Repeat<int>(0, wallpapers.Length).Select((x, i) => new { i = i, rnd = rnd.Next() }).OrderBy(x => x.rnd).Select(x => x.i).ToArray();
					monitorWallpapers[monitorId] = wallpapers;
					monitorWallpaperCurrentIndex[monitorId] = 0;
					monitorWallpaperTotalIndex[monitorId] = (uint)wallpapers.Length - 1;
				}
			}
		}

		public void Refresh() {
			lock (locker) {
				foreach (var entry in monitorWallpapers) {
					var monitorId = entry.Key;
					var currentIndex = monitorWallpaperCurrentIndex[monitorId];
					var totalIndex = monitorWallpaperTotalIndex[monitorId];
					wallpaper.SetWallpaper(monitorId, entry.Value[monitorWallpaperShuffledList[monitorId][currentIndex]]);
					currentIndex++;
					if (currentIndex >= totalIndex) {
						monitorWallpaperShuffledList[monitorId] = Enumerable.Repeat<int>(0, (int)totalIndex + 1).Select((x, i) => new { i = i, rnd = rnd.Next() }).OrderBy(x => x.rnd).Select(x => x.i).ToArray();
						currentIndex = 0;
					}
					monitorWallpaperCurrentIndex[monitorId] = currentIndex;
				}
				restoreTimer.Start();
			}
		}
	}
}
