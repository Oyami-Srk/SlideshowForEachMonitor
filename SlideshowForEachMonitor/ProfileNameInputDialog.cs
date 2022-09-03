using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlideshowForEachMonitor
{
	public partial class ProfileNameInputDialog : Form
	{
		public ProfileNameInputDialog(string defaultName) {
			InitializeComponent();
			this.textBox1.Text = defaultName;
		}

		public string GetProfileName() {
			return this.textBox1.Text;
		}
	}
}
