using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 集中器控制客户端
{
    public partial class ChartDaoNetBar : Form
    {
        public ChartDaoNetBar()
        {
            InitializeComponent();
        }
        public List<double> db = new List<double>();
        public List<string> toop = new List<string>();
        private void ChartDaoNetBar_Load(object sender, EventArgs e)
        {
            microChart1.DataPoints = db;
            microChart1.DataPointTooltips = toop;
        }

        private void 折线图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            microChart1.ChartType = DevComponents.DotNetBar.eMicroChartType.Line;
        }

        private void 曲线图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            microChart1.ChartType = DevComponents.DotNetBar.eMicroChartType.Plot;
        }

        private void 其他ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            microChart1.ChartType = DevComponents.DotNetBar.eMicroChartType.Area;
        }
    }
}
