using Bunifu.Charts.WinForms.ChartTypes;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void topBunifuRadioButton1_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuHorizontalBarChart1.BorderSkipped = "top"; 
            }
        }

        private void bottomBunifuRadioButton2_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuHorizontalBarChart1.BorderSkipped = "bottom";
            }
        }

        private void leftBunifuRadioButton3_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuHorizontalBarChart1.BorderSkipped = "left";
            }
        }

        private void rightBunifuRadioButton4_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuHorizontalBarChart1.BorderSkipped = "right";
            }
        }

        private void falseBunifuRadioButton1_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuHorizontalBarChart1.BorderSkipped = "false";
            }
        }
    }
}
