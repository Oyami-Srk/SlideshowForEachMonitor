namespace SlideshowForEachMonitor
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.StartButton = new System.Windows.Forms.Button();
			this.StopButton = new System.Windows.Forms.Button();
			this.ProfilesTab = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.monitorList1 = new SlideshowForEachMonitor.MonitorList();
			this.SaveButton = new System.Windows.Forms.Button();
			this.AddButton = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.label1 = new System.Windows.Forms.Label();
			this.minutesCounter = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.IsHideOnClose = new System.Windows.Forms.CheckBox();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.trayMenuProfiles = new System.Windows.Forms.ToolStripMenuItem();
			this.trayMenuInterval = new System.Windows.Forms.ToolStripMenuItem();
			this.secondsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.secondsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.secondsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.minuteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.minutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.minutesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.minutesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.minutesToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.hourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hoursToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.hoursToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.hoursToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.trayMenuReshuffle = new System.Windows.Forms.ToolStripMenuItem();
			this.trayMenuRefresh = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.trayMenuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.ProfilesTab.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.minutesCounter)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// StartButton
			// 
			this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.StartButton.Location = new System.Drawing.Point(536, 12);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(112, 34);
			this.StartButton.TabIndex = 0;
			this.StartButton.Text = "Start";
			this.StartButton.UseVisualStyleBackColor = true;
			this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
			// 
			// StopButton
			// 
			this.StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.StopButton.Location = new System.Drawing.Point(654, 12);
			this.StopButton.Name = "StopButton";
			this.StopButton.Size = new System.Drawing.Size(112, 34);
			this.StopButton.TabIndex = 1;
			this.StopButton.Text = "Stop";
			this.StopButton.UseVisualStyleBackColor = true;
			this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
			// 
			// ProfilesTab
			// 
			this.ProfilesTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ProfilesTab.Controls.Add(this.tabPage1);
			this.ProfilesTab.Location = new System.Drawing.Point(12, 52);
			this.ProfilesTab.Name = "ProfilesTab";
			this.ProfilesTab.SelectedIndex = 0;
			this.ProfilesTab.Size = new System.Drawing.Size(754, 431);
			this.ProfilesTab.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.monitorList1);
			this.tabPage1.Location = new System.Drawing.Point(4, 33);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(746, 394);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Default";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// monitorList1
			// 
			this.monitorList1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.monitorList1.Location = new System.Drawing.Point(3, 3);
			this.monitorList1.Name = "monitorList1";
			this.monitorList1.Size = new System.Drawing.Size(740, 388);
			this.monitorList1.TabIndex = 0;
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(16, 12);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(112, 34);
			this.SaveButton.TabIndex = 3;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(134, 12);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(112, 34);
			this.AddButton.TabIndex = 4;
			this.AddButton.Text = "Add";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.statusStrip1.Location = new System.Drawing.Point(0, 522);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(778, 22);
			this.statusStrip1.TabIndex = 5;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 493);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 24);
			this.label1.TabIndex = 6;
			this.label1.Text = "Interval Time:";
			// 
			// minutesCounter
			// 
			this.minutesCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.minutesCounter.DecimalPlaces = 2;
			this.minutesCounter.Location = new System.Drawing.Point(143, 489);
			this.minutesCounter.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
			this.minutesCounter.Name = "minutesCounter";
			this.minutesCounter.Size = new System.Drawing.Size(141, 30);
			this.minutesCounter.TabIndex = 7;
			this.minutesCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(290, 493);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 24);
			this.label2.TabIndex = 8;
			this.label2.Text = "minute(s)";
			// 
			// IsHideOnClose
			// 
			this.IsHideOnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.IsHideOnClose.AutoSize = true;
			this.IsHideOnClose.Checked = true;
			this.IsHideOnClose.CheckState = System.Windows.Forms.CheckState.Checked;
			this.IsHideOnClose.Location = new System.Drawing.Point(593, 489);
			this.IsHideOnClose.Name = "IsHideOnClose";
			this.IsHideOnClose.Size = new System.Drawing.Size(173, 28);
			this.IsHideOnClose.TabIndex = 9;
			this.IsHideOnClose.Text = "HideWhenClose";
			this.IsHideOnClose.UseVisualStyleBackColor = true;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.BalloonTipTitle = "Slideshow4EachMonitor";
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "Slideshow4EachMonitor";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayMenuProfiles,
            this.trayMenuInterval,
            this.toolStripSeparator2,
            this.trayMenuReshuffle,
            this.trayMenuRefresh,
            this.toolStripSeparator1,
            this.trayMenuExit});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(160, 166);
			// 
			// trayMenuProfiles
			// 
			this.trayMenuProfiles.Name = "trayMenuProfiles";
			this.trayMenuProfiles.Size = new System.Drawing.Size(159, 30);
			this.trayMenuProfiles.Text = "Profiles";
			// 
			// trayMenuInterval
			// 
			this.trayMenuInterval.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secondsToolStripMenuItem,
            this.secondsToolStripMenuItem1,
            this.secondsToolStripMenuItem2,
            this.minuteToolStripMenuItem,
            this.minutesToolStripMenuItem,
            this.minutesToolStripMenuItem1,
            this.minutesToolStripMenuItem2,
            this.minutesToolStripMenuItem3,
            this.hourToolStripMenuItem,
            this.hoursToolStripMenuItem,
            this.hoursToolStripMenuItem1,
            this.hoursToolStripMenuItem2,
            this.hoursToolStripMenuItem3});
			this.trayMenuInterval.Name = "trayMenuInterval";
			this.trayMenuInterval.Size = new System.Drawing.Size(159, 30);
			this.trayMenuInterval.Text = "Interval";
			// 
			// secondsToolStripMenuItem
			// 
			this.secondsToolStripMenuItem.Name = "secondsToolStripMenuItem";
			this.secondsToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
			this.secondsToolStripMenuItem.Text = "5 seconds";
			this.secondsToolStripMenuItem.Click += new System.EventHandler(this.secondsToolStripMenuItem_Click);
			// 
			// secondsToolStripMenuItem1
			// 
			this.secondsToolStripMenuItem1.Name = "secondsToolStripMenuItem1";
			this.secondsToolStripMenuItem1.Size = new System.Drawing.Size(206, 34);
			this.secondsToolStripMenuItem1.Text = "15 seconds";
			this.secondsToolStripMenuItem1.Click += new System.EventHandler(this.secondsToolStripMenuItem1_Click);
			// 
			// secondsToolStripMenuItem2
			// 
			this.secondsToolStripMenuItem2.Name = "secondsToolStripMenuItem2";
			this.secondsToolStripMenuItem2.Size = new System.Drawing.Size(206, 34);
			this.secondsToolStripMenuItem2.Text = "30 seconds";
			this.secondsToolStripMenuItem2.Click += new System.EventHandler(this.secondsToolStripMenuItem2_Click);
			// 
			// minuteToolStripMenuItem
			// 
			this.minuteToolStripMenuItem.Name = "minuteToolStripMenuItem";
			this.minuteToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
			this.minuteToolStripMenuItem.Text = "1 minute";
			this.minuteToolStripMenuItem.Click += new System.EventHandler(this.minuteToolStripMenuItem_Click);
			// 
			// minutesToolStripMenuItem
			// 
			this.minutesToolStripMenuItem.Name = "minutesToolStripMenuItem";
			this.minutesToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
			this.minutesToolStripMenuItem.Text = "3 minutes";
			this.minutesToolStripMenuItem.Click += new System.EventHandler(this.minutesToolStripMenuItem_Click);
			// 
			// minutesToolStripMenuItem1
			// 
			this.minutesToolStripMenuItem1.Name = "minutesToolStripMenuItem1";
			this.minutesToolStripMenuItem1.Size = new System.Drawing.Size(206, 34);
			this.minutesToolStripMenuItem1.Text = "5 minutes";
			this.minutesToolStripMenuItem1.Click += new System.EventHandler(this.minutesToolStripMenuItem1_Click);
			// 
			// minutesToolStripMenuItem2
			// 
			this.minutesToolStripMenuItem2.Name = "minutesToolStripMenuItem2";
			this.minutesToolStripMenuItem2.Size = new System.Drawing.Size(206, 34);
			this.minutesToolStripMenuItem2.Text = "10 minutes";
			this.minutesToolStripMenuItem2.Click += new System.EventHandler(this.minutesToolStripMenuItem2_Click);
			// 
			// minutesToolStripMenuItem3
			// 
			this.minutesToolStripMenuItem3.Name = "minutesToolStripMenuItem3";
			this.minutesToolStripMenuItem3.Size = new System.Drawing.Size(206, 34);
			this.minutesToolStripMenuItem3.Text = "30 minutes";
			this.minutesToolStripMenuItem3.Click += new System.EventHandler(this.minutesToolStripMenuItem3_Click);
			// 
			// hourToolStripMenuItem
			// 
			this.hourToolStripMenuItem.Name = "hourToolStripMenuItem";
			this.hourToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
			this.hourToolStripMenuItem.Text = "1 hour";
			this.hourToolStripMenuItem.Click += new System.EventHandler(this.hourToolStripMenuItem_Click);
			// 
			// hoursToolStripMenuItem
			// 
			this.hoursToolStripMenuItem.Name = "hoursToolStripMenuItem";
			this.hoursToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
			this.hoursToolStripMenuItem.Text = "2 hours";
			this.hoursToolStripMenuItem.Click += new System.EventHandler(this.hoursToolStripMenuItem_Click);
			// 
			// hoursToolStripMenuItem1
			// 
			this.hoursToolStripMenuItem1.Name = "hoursToolStripMenuItem1";
			this.hoursToolStripMenuItem1.Size = new System.Drawing.Size(206, 34);
			this.hoursToolStripMenuItem1.Text = "5 hours";
			this.hoursToolStripMenuItem1.Click += new System.EventHandler(this.hoursToolStripMenuItem1_Click);
			// 
			// hoursToolStripMenuItem2
			// 
			this.hoursToolStripMenuItem2.Name = "hoursToolStripMenuItem2";
			this.hoursToolStripMenuItem2.Size = new System.Drawing.Size(206, 34);
			this.hoursToolStripMenuItem2.Text = "12 hours";
			this.hoursToolStripMenuItem2.Click += new System.EventHandler(this.hoursToolStripMenuItem2_Click);
			// 
			// hoursToolStripMenuItem3
			// 
			this.hoursToolStripMenuItem3.Name = "hoursToolStripMenuItem3";
			this.hoursToolStripMenuItem3.Size = new System.Drawing.Size(206, 34);
			this.hoursToolStripMenuItem3.Text = "24 hours";
			this.hoursToolStripMenuItem3.Click += new System.EventHandler(this.hoursToolStripMenuItem3_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(156, 6);
			// 
			// trayMenuReshuffle
			// 
			this.trayMenuReshuffle.Name = "trayMenuReshuffle";
			this.trayMenuReshuffle.Size = new System.Drawing.Size(159, 30);
			this.trayMenuReshuffle.Text = "Reshuffle";
			this.trayMenuReshuffle.Click += new System.EventHandler(this.trayMenuReshuffle_Click);
			// 
			// trayMenuRefresh
			// 
			this.trayMenuRefresh.Name = "trayMenuRefresh";
			this.trayMenuRefresh.Size = new System.Drawing.Size(159, 30);
			this.trayMenuRefresh.Text = "Refresh";
			this.trayMenuRefresh.Click += new System.EventHandler(this.trayMenuRefresh_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
			// 
			// trayMenuExit
			// 
			this.trayMenuExit.Name = "trayMenuExit";
			this.trayMenuExit.Size = new System.Drawing.Size(159, 30);
			this.trayMenuExit.Text = "Exit";
			this.trayMenuExit.Click += new System.EventHandler(this.trayMenuExit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(778, 544);
			this.Controls.Add(this.IsHideOnClose);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.minutesCounter);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.ProfilesTab);
			this.Controls.Add(this.StopButton);
			this.Controls.Add(this.StartButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(600, 300);
			this.Name = "Form1";
			this.Text = "Slideshow4EachMonitor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.ProfilesTab.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.minutesCounter)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button StartButton;
		private Button StopButton;
		private TabControl ProfilesTab;
		private TabPage tabPage1;
		private Button SaveButton;
		private Button AddButton;
		private StatusStrip statusStrip1;
		private MonitorList monitorList1;
		private Label label1;
		private NumericUpDown minutesCounter;
		private Label label2;
		private CheckBox IsHideOnClose;
		private NotifyIcon notifyIcon1;
		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem trayMenuExit;
		private ToolStripMenuItem trayMenuRefresh;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripMenuItem trayMenuReshuffle;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem trayMenuProfiles;
		private ToolStripMenuItem trayMenuInterval;
		private ToolStripMenuItem secondsToolStripMenuItem;
		private ToolStripMenuItem secondsToolStripMenuItem1;
		private ToolStripMenuItem secondsToolStripMenuItem2;
		private ToolStripMenuItem minuteToolStripMenuItem;
		private ToolStripMenuItem minutesToolStripMenuItem;
		private ToolStripMenuItem minutesToolStripMenuItem1;
		private ToolStripMenuItem minutesToolStripMenuItem2;
		private ToolStripMenuItem minutesToolStripMenuItem3;
		private ToolStripMenuItem hourToolStripMenuItem;
		private ToolStripMenuItem hoursToolStripMenuItem;
		private ToolStripMenuItem hoursToolStripMenuItem1;
		private ToolStripMenuItem hoursToolStripMenuItem2;
		private ToolStripMenuItem hoursToolStripMenuItem3;
	}
}