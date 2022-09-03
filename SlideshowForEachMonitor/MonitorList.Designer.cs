namespace SlideshowForEachMonitor
{
	partial class MonitorList
	{
		/// <summary> 
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent() {
			this.monitorListView = new System.Windows.Forms.DataGridView();
			this.MonitorDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SlideshowFolder = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Choser = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.monitorListView)).BeginInit();
			this.SuspendLayout();
			// 
			// monitorListView
			// 
			this.monitorListView.AllowUserToAddRows = false;
			this.monitorListView.AllowUserToDeleteRows = false;
			this.monitorListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.monitorListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.monitorListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MonitorDesc,
            this.SlideshowFolder,
            this.Choser});
			this.monitorListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.monitorListView.Location = new System.Drawing.Point(0, 0);
			this.monitorListView.MultiSelect = false;
			this.monitorListView.Name = "monitorListView";
			this.monitorListView.RowHeadersVisible = false;
			this.monitorListView.RowHeadersWidth = 62;
			this.monitorListView.RowTemplate.Height = 32;
			this.monitorListView.Size = new System.Drawing.Size(545, 460);
			this.monitorListView.TabIndex = 0;
			this.monitorListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// MonitorDesc
			// 
			this.MonitorDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.MonitorDesc.Frozen = true;
			this.MonitorDesc.HeaderText = "Monitor";
			this.MonitorDesc.MinimumWidth = 8;
			this.MonitorDesc.Name = "MonitorDesc";
			this.MonitorDesc.ReadOnly = true;
			this.MonitorDesc.Width = 116;
			// 
			// SlideshowFolder
			// 
			this.SlideshowFolder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.SlideshowFolder.HeaderText = "SlideshowFolder";
			this.SlideshowFolder.MinimumWidth = 8;
			this.SlideshowFolder.Name = "SlideshowFolder";
			// 
			// Choser
			// 
			this.Choser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Choser.HeaderText = "";
			this.Choser.MinimumWidth = 8;
			this.Choser.Name = "Choser";
			this.Choser.Text = "...";
			this.Choser.UseColumnTextForButtonValue = true;
			this.Choser.Width = 30;
			// 
			// MonitorList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.monitorListView);
			this.Name = "MonitorList";
			this.Size = new System.Drawing.Size(545, 460);
			((System.ComponentModel.ISupportInitialize)(this.monitorListView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DataGridView monitorListView;
		private DataGridViewTextBoxColumn MonitorDesc;
		private DataGridViewTextBoxColumn SlideshowFolder;
		private DataGridViewButtonColumn Choser;
	}
}
