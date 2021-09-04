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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        List<Color>backgroundColors = new List<Color>();
        List<Color> borderColors = new List<Color>();

        private void Form7_Load(object sender, EventArgs e)
        {
            //bunifuHorizontalBarChart1.BackgroundColor[0] = Color.FromArgb(7, 162, 135);
            backgroundColors.AddRange(new Color[]
            {
                Color.FromArgb(7, 162, 135),
                Color.FromArgb(46, 41, 78),
                Color.FromArgb(91, 146, 121)
            });

            borderColors.AddRange(new Color[]
            {
                Color.FromArgb(239, 202, 8),
                Color.FromArgb(103, 125, 183),
                Color.FromArgb(149, 198, 35)
            });
        }
        private void bwBunifuHSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            bunifuHorizontalBarChart1.HoverBorderWidth = e.Value;
        }

        private void backgroundBunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (backgroundBunifuDropdown1.SelectedIndex == 0)
            {
                bunifuHorizontalBarChart1.HoverBackgroundColor = backgroundColors[0];
                bunifuChartCanvas1.Update();
            }
            else if (backgroundBunifuDropdown1.SelectedIndex == 1)
            {
                bunifuHorizontalBarChart1.HoverBackgroundColor = backgroundColors[1];
                bunifuChartCanvas1.Update();
            }
            else
            {
                bunifuHorizontalBarChart1.HoverBackgroundColor= backgroundColors[2];
                bunifuChartCanvas1.Update();
            }
        }

        private void borderBunifuDropdown2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (borderBunifuDropdown2.SelectedIndex == 0)
            { 
                bunifuHorizontalBarChart1.HoverBorderColor= borderColors[0];
            }
            else if (borderBunifuDropdown2.SelectedIndex == 1)
            {
                bunifuHorizontalBarChart1.HoverBorderColor = borderColors[1];
            }
            else
            {
                bunifuHorizontalBarChart1.HoverBorderColor = borderColors[2];
            }
        }

      
    }
}
