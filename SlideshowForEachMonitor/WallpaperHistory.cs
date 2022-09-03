using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DesktopWallpaper;


public static class WallpaperHistory
{
	private const string REG_ITEM_PATH = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Wallpapers";
	private const string BASE_HISTORY_KEY_NAME = @"BackgroundHistoryPath";
	private const int MAX_HISTORY = 5;
	private static object?[] histories = new object[MAX_HISTORY];
	private static Dictionary<string, string> originWallpapers = new();

	public static void Backup(IDesktopWallpaper? wallpaper) {
		for (int i = 0; i < MAX_HISTORY; i++) {
			var value = Registry.GetValue(REG_ITEM_PATH, BASE_HISTORY_KEY_NAME + i.ToString(), null);
			histories[i] = value;
		}
		if (wallpaper != null) {
			for (uint i = 0; i < wallpaper.GetMonitorDevicePathCount(); i++) {
				var monitorId = wallpaper.GetMonitorDevicePathAt(i);
				var originWallpaper = wallpaper.GetWallpaper(monitorId);
				if (!originWallpapers.ContainsKey(monitorId))
					originWallpapers.Add(monitorId, originWallpaper);
			}
		}
	}

	public static void Restore(IDesktopWallpaper? wallpaper) {
		if (wallpaper != null) {
			foreach (var entry in originWallpapers) {
				wallpaper.SetWallpaper(entry.Key, entry.Value);
			}
		}
		for (int i = 0; i < MAX_HISTORY; i++) {
			var value = histories[i];
			if (value != null) {
				Registry.SetValue(REG_ITEM_PATH, BASE_HISTORY_KEY_NAME + i.ToString(), value);
			}
		}
	}
}