using DesktopWallpaper;
using System.Text.Json;
using System.Windows.Forms;

namespace SlideshowForEachMonitor
{
	using configType = Dictionary<string, Dictionary<string, string>>;

	public partial class Form1 : Form
	{
		class Config
		{
			public bool isHideOnClose { get; set; }
			public decimal interval { get; set; }
			public configType profiles { get; set; }

			public int selectedProfiles { get; set; }

			public Config(configType profiles, decimal interval, bool isHideOnClose) {
				this.profiles = profiles;
				this.interval = interval;
				this.isHideOnClose = isHideOnClose;
			}
		}

		static string configPath = "slideshow_config.json";
		static IDesktopWallpaper wallpaper = (IDesktopWallpaper)(new DesktopWallpaperClass());

		Config? config;

		List<MonitorList> profiles = new();
		Invoker? invoker = null;


		public Form1() {
			InitializeComponent();
		}


		private void StartButton_Click(object sender, EventArgs e) {
			if (invoker != null) {
				return;
			}
			var currentProfile = profiles[ProfilesTab.SelectedIndex];
			var currentConfig = currentProfile.configGet();
			var seconds = (uint)Math.Floor(minutesCounter.Value * 60);
			if(seconds < 1) {
				MessageBox.Show("Slideshow interval too low.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			foreach (var entry in currentConfig) {
				string[] wallpapers = Directory.GetFiles(
					entry.Value, "*.*", SearchOption.TopDirectoryOnly
					).Where(s => Invoker.SUPPORTED_EXTENSION.Contains(Path.GetExtension(s).ToLower()))
					.ToArray();
				if (wallpapers.Length == 0) {
					MessageBox.Show($"Slideshow folder {entry.Value} have no picture there.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return; 
				}
			}

			// First, backup
			WallpaperHistory.Backup(wallpaper);
			// Invoke timer
			invoker = new(currentConfig, wallpaper);
			invoker.Start(seconds);
		}

		private void StopButton_Click(object sender, EventArgs e) {
			if (invoker == null) {
				return;
			}
			// Stop timer
			// Last, restore
			invoker.Close();
			WallpaperHistory.Restore(wallpaper);
			invoker = null;
		}

		private void AddButton_Click(object sender, EventArgs e) {
			var defaultName = "Profile";
			for (uint i = 1; true; i++) {
				if (!config!.profiles.ContainsKey(defaultName + i.ToString())) {
					defaultName += i.ToString();
					break;
				}
			}
			ProfileNameInputDialog dlg = new(defaultName);
			var profileName = "";
			if (dlg.ShowDialog(this) == DialogResult.OK) {
				profileName = dlg.GetProfileName();
				if(config.profiles.ContainsKey(profileName)) {
					MessageBox.Show("Profile name already existed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			} else {
				return;
			}
			if(profileName.Length == 0) {
				MessageBox.Show("Profile name empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			// Add to config
			string defaultSlideshowPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
			Dictionary<string, string> monitorSets = new();
			for (uint i = 0; i < wallpaper.GetMonitorDevicePathCount(); i++) {
				string monitorId = wallpaper.GetMonitorDevicePathAt(i);
				monitorSets.Add(monitorId, defaultSlideshowPath);
			}
			config.profiles.Add(profileName, monitorSets);
			// Add a tab
			MonitorList profile = new();
			profile.configSet(monitorSets, wallpaper);
			profiles.Add(profile);
			profile.Dock = DockStyle.Fill;
			TabPage page = new();
			page.Controls.Add(profile);
			page.Name = profileName;
			page.Text = profileName;
			ProfilesTab.TabPages.Add(page);
			ProfilesTab.SelectTab(page);
			// tray menu
			ToolStripMenuItem menuItem = new();
			menuItem.Text = profileName;
			menuItem.Click += new EventHandler((sender, e) => { ChangeProfile(profiles.IndexOf(profile)); });
			trayMenuProfiles.DropDownItems.Add(menuItem);
		}

		private void SaveButton_Click(object sender, EventArgs e) {
			if(config == null) {
				return;
			}
			config.isHideOnClose = IsHideOnClose.Checked;
			config.interval = minutesCounter.Value;
			config.selectedProfiles = ProfilesTab.SelectedIndex;
			System.IO.File.WriteAllText(configPath, JsonSerializer.Serialize(config));
		}

		private void Form1_Load(object sender, EventArgs e) {
			// Load config
			if (System.IO.File.Exists(configPath)) {
				try {
					Config? tryRead = JsonSerializer.Deserialize<Config>(System.IO.File.ReadAllText(configPath));
					config = tryRead;
				} catch {
					config = null;
				}
			} 
			if(config == null){
				string defaultName = "Default";
				string defaultSlideshowPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
				Dictionary<string, string> monitorSets = new();
				for(uint i = 0; i < wallpaper.GetMonitorDevicePathCount(); i++) {
					string monitorId = wallpaper.GetMonitorDevicePathAt(i);
					monitorSets.Add(monitorId, defaultSlideshowPath);
				}
				configType profiles = new();
				profiles.Add(defaultName, monitorSets);
				config = new(profiles, this.minutesCounter.Value, IsHideOnClose.Checked);
			}
			if(config.interval == 0) {
				config.interval = minutesCounter.Value;
			} else {
				minutesCounter.Value = config.interval;
			}
			IsHideOnClose.Checked = config.isHideOnClose;
	
			if(config.profiles == null) {
				string defaultName = "Default";
				string defaultSlideshowPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
				Dictionary<string, string> monitorSets = new();
				for (uint i = 0; i < wallpaper.GetMonitorDevicePathCount(); i++) {
					string monitorId = wallpaper.GetMonitorDevicePathAt(i);
					monitorSets.Add(monitorId, defaultSlideshowPath);
				}
				configType profiles = new();
				profiles.Add(defaultName, monitorSets);
				config.profiles = profiles;
			}

			// Setup Tabs
			ProfilesTab.TabPages.Clear();
			foreach(var entry in config.profiles) {
				MonitorList profile = new();
				profile.configSet(entry.Value, wallpaper);
				profiles.Add(profile);
				profile.Dock = DockStyle.Fill;
				TabPage page = new();
				page.Controls.Add(profile);
				page.Name = entry.Key;
				page.Text = entry.Key;
				ProfilesTab.TabPages.Add(page);
				// tray menu
				ToolStripMenuItem menuItem = new();
				menuItem.Text = entry.Key;
				menuItem.Click += new EventHandler((sender, e) => { ChangeProfile(profiles.IndexOf(profile)); });
				trayMenuProfiles.DropDownItems.Add(menuItem);
			}
			ProfilesTab.SelectedIndex = config.selectedProfiles;
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
			if (e.CloseReason == CloseReason.UserClosing && IsHideOnClose.Checked) {
				Hide();
				notifyIcon1.ShowBalloonTip(3, "Slideshow4EachMonitor", "Hello, I'm here.", ToolTipIcon.Info);
				e.Cancel = true;
				return;
			}
			// Stop
			StopButton.PerformClick();
			// Save
			SaveButton.PerformClick();
		}

		private void Form1_Resize(object sender, EventArgs e) {
			if(this.WindowState == FormWindowState.Minimized) {
				Hide();
				notifyIcon1.ShowBalloonTip(3, "Slideshow4EachMonitor", "Hello, I'm here.", ToolTipIcon.Info);
			}
		}

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) {
			Show();
			this.WindowState = FormWindowState.Normal;
		}

		private void trayMenuExit_Click(object sender, EventArgs e) {
			Show();
			this.WindowState = FormWindowState.Normal;
			this.StopButton.PerformClick();
			this.SaveButton.PerformClick();
			this.Dispose();
		}

		private void trayMenuRefresh_Click(object sender, EventArgs e) {
			if(invoker != null) {
				invoker.Refresh();
			}
		}

		private void trayMenuReshuffle_Click(object sender, EventArgs e) {
			if(invoker != null) {
				invoker.Reshuffle();
			}
		}

		private void ChangeInterval(uint seconds) {
			if(seconds == 0) {
				return;
			}
			if(invoker != null) {
				invoker.Stop();
				invoker.SetInterval(seconds);
			}
			minutesCounter.Value = (decimal)seconds / 60;
		}

		private void ChangeProfile(int profileIndex) {
			StopButton.PerformClick();
			ProfilesTab.SelectedIndex = profileIndex;
			StartButton.PerformClick();
		}

		private void secondsToolStripMenuItem_Click(object sender, EventArgs e) {
			ChangeInterval(5);
		}

		private void secondsToolStripMenuItem1_Click(object sender, EventArgs e) {
			ChangeInterval(15);
		}

		private void secondsToolStripMenuItem2_Click(object sender, EventArgs e) {
			ChangeInterval(30);
		}

		private void minuteToolStripMenuItem_Click(object sender, EventArgs e) {
			ChangeInterval(60);
		}

		private void minutesToolStripMenuItem_Click(object sender, EventArgs e) {
			ChangeInterval(60 * 3);
		}

		private void minutesToolStripMenuItem1_Click(object sender, EventArgs e) {
			ChangeInterval(60 * 5);
		}

		private void minutesToolStripMenuItem2_Click(object sender, EventArgs e) {
			ChangeInterval(60 * 10);
		}

		private void minutesToolStripMenuItem3_Click(object sender, EventArgs e) {
			ChangeInterval(60 * 30);
		}

		private void hourToolStripMenuItem_Click(object sender, EventArgs e) {
			ChangeInterval(60 * 60);
		}

		private void hoursToolStripMenuItem_Click(object sender, EventArgs e) {
			ChangeInterval(60 * 60 * 2);
		}

		private void hoursToolStripMenuItem1_Click(object sender, EventArgs e) {
			ChangeInterval(60 * 60 * 5);
		}

		private void hoursToolStripMenuItem2_Click(object sender, EventArgs e) {
			ChangeInterval(60 * 60 * 12);
		}

		private void hoursToolStripMenuItem3_Click(object sender, EventArgs e) {
			ChangeInterval(60 * 60 * 24);
		}
	}
}