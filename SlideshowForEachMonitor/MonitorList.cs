using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopWallpaper;

namespace SlideshowForEachMonitor
{
	public partial class MonitorList : UserControl
	{
		private Dictionary<string, string> config = new();
		private Dictionary<int, string> indexMonitorId = new();

		public MonitorList() {
			InitializeComponent();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
			if (e.ColumnIndex == 2 && e.RowIndex >= 0) {
				var monitorId = indexMonitorId[e.RowIndex];
				var dlg = new FolderPicker();
				dlg.InputPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
				if(dlg.ShowDialog(this.Handle) == true) {
					var path = dlg.ResultPath;
					if(!System.IO.Directory.Exists(path)) {
						MessageBox.Show("Selected folder is not existed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					config[monitorId] = path;
					monitorListView.Rows[e.RowIndex].Cells[1].Value = path;
				}
			}
		}

		public void configSet(Dictionary<string, string> l_config, IDesktopWallpaper wallpaper) {
			config = l_config;
			monitorListView.Rows.Clear();
			foreach(var entry in config) {
				var monitorId = entry.Key;
				var rect = wallpaper.GetMonitorRECT(monitorId);
				var desc = $"{rect.Bottom - rect.Top}x{rect.Right - rect.Left}@({rect.Left},{rect.Top})";
				var index = monitorListView.Rows.Add(desc, entry.Value, "...");
				indexMonitorId.Add(index, monitorId);
			}
		}

		public Dictionary<string, string> configGet() {
			return config;
		}
	}
}
