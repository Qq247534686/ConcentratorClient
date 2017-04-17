namespace 集中器控制客户端
{
    partial class ChartDaoNetBar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartDaoNetBar));
            this.microChart1 = new DevComponents.DotNetBar.MicroChart();
            this.command1 = new DevComponents.DotNetBar.Command(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.折线图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.曲线图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.其他ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // microChart1
            // 
            this.microChart1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.microChart1.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.microChart1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.microChart1.BackgroundStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(198)))));
            this.microChart1.Command = this.command1;
            this.microChart1.ContextMenuStrip = this.contextMenuStrip1;
            this.microChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.microChart1.LineChartStyle.ControlLine1Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.microChart1.LineChartStyle.LowPointColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.microChart1.Location = new System.Drawing.Point(0, 0);
            this.microChart1.Name = "microChart1";
            this.microChart1.PlotChartStyle.ControlLine1EndValue = 100D;
            this.microChart1.Size = new System.Drawing.Size(709, 474);
            this.microChart1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.microChart1.TabIndex = 0;
            this.microChart1.Text = "microChart1";
            // 
            // command1
            // 
            this.command1.Image = global::集中器控制客户端.Properties.Resources.download;
            this.command1.ImageSmall = global::集中器控制客户端.Properties.Resources.curve_arrow_50_237288135593px_1205381_easyicon_net;
            this.command1.Name = "command1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.折线图ToolStripMenuItem,
            this.曲线图ToolStripMenuItem,
            this.其他ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 82);
            // 
            // 折线图ToolStripMenuItem
            // 
            this.折线图ToolStripMenuItem.Name = "折线图ToolStripMenuItem";
            this.折线图ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.折线图ToolStripMenuItem.Text = "折线图";
            this.折线图ToolStripMenuItem.Click += new System.EventHandler(this.折线图ToolStripMenuItem_Click);
            // 
            // 曲线图ToolStripMenuItem
            // 
            this.曲线图ToolStripMenuItem.Name = "曲线图ToolStripMenuItem";
            this.曲线图ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.曲线图ToolStripMenuItem.Text = "散点图";
            this.曲线图ToolStripMenuItem.Click += new System.EventHandler(this.曲线图ToolStripMenuItem_Click);
            // 
            // 其他ToolStripMenuItem
            // 
            this.其他ToolStripMenuItem.Name = "其他ToolStripMenuItem";
            this.其他ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.其他ToolStripMenuItem.Text = "其他";
            this.其他ToolStripMenuItem.Click += new System.EventHandler(this.其他ToolStripMenuItem_Click);
            // 
            // ChartDaoNetBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 474);
            this.Controls.Add(this.microChart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChartDaoNetBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChartDaoNetBar";
            this.Load += new System.EventHandler(this.ChartDaoNetBar_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.MicroChart microChart1;
        private DevComponents.DotNetBar.Command command1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 折线图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 曲线图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 其他ToolStripMenuItem;
    }
}