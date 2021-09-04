using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_v1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            List<Color> colorList = new List<Color>();
            colorList.AddRange(new Color[]
            {
                Color.FromArgb(240, 246, 110),
                Color.FromArgb(45, 45, 42),
                Color.FromArgb(50, 13, 109),
                Color.FromArgb(67, 100, 54),
                Color.FromArgb(90, 210, 244),
                Color.FromArgb(159, 164, 169)
            });
            bunifuHorizontalBarChart1.BorderColor = colorList;
        }
    }
}
