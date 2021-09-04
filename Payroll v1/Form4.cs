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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            List<Color> colorsList = new List<Color>();
            colorsList.AddRange(new Color[]{
            Color.FromArgb(7, 162, 135),
            Color.FromArgb(204, 255, 102),
            Color.FromArgb(9, 174, 150),
            Color.FromArgb(64, 98, 187),
            Color.FromArgb(46, 41, 78)
            });

            bunifuHorizontalBarChart1.BackgroundColor = colorsList;
        }
    }
}
