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

public partial class RevenueForm : Form
    {
        public RevenueForm()
        {
            InitializeComponent();
        }
        public class FoodRevenueData
        {
            public double USData { get; set; }
            public double GermanData { get; set; }
            public double KenyanData { get; set; }
            public double FranceData { get; set; }
            public double UKData { get; set; }
            public double ChinaData { get; set; }
            public double ItalyData { get; set; }
            public double SwitzerLandData { get; set; }
        }
        private void RevenueForm_Load(object sender, EventArgs e)
        {
            //Set data to the class properties
            FoodRevenueData data = new FoodRevenueData()
            {
                USData = 44727,
                GermanData = 11970,
                FranceData = 11295,
                ChinaData = 18205,
                ItalyData = 13265,
                SwitzerLandData = 21133,
                KenyanData = 23014,
                UKData = 42299
            };
            //map the property values of the class with its key(the country!)
            Dictionary<String, Double> revenueByCountry = new Dictionary<string, double>();
            revenueByCountry.Add("United States of America", data.USData);
            revenueByCountry.Add("German", data.GermanData);
            revenueByCountry.Add("France", data.FranceData);
            revenueByCountry.Add("China", data.ChinaData);
            revenueByCountry.Add("Italy", data.ItalyData);
            revenueByCountry.Add("SwitzerLand", data.SwitzerLandData);
            revenueByCountry.Add("Kenya", data.KenyanData);
            revenueByCountry.Add("United Kingdom", data.UKData);
            /*
            * sort data in the dictionary by value in a descending order and
              assign the data to the list
            */
            List<string> y_AxisLabels = new List<string>();
            List<double> horizontalBarData = new List<double>();
           
            foreach (var countryData in revenueByCountry.OrderByDescending(x=>x.Value))
            {
                y_AxisLabels.Add(countryData.Key);
                horizontalBarData.Add(countryData.Value);
            }

            //assign the values
            bunifuChartCanvas1.Labels = y_AxisLabels.ToArray();
            bunifuHorizontalBarChart1.Data = horizontalBarData;
        }
    }
}
