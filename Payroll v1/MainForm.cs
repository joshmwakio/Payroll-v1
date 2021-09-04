using Bunifu.UI.WinForms;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        BunifuDropdown ctrl = new BunifuDropdown();
        private void LoadData()
        {
            DataTable dataTable = new DataTable();



            List<InfoObject> infoObjects = new List<InfoObject>()
            {
                new InfoObject()
                {
                    CompanyName="Microsoft",
                    ClientName="Alvin Harvey",
                     Amount="Ksh 17000 /=",
                     InvoiceNumber="P235212",
                     Status="Paid",
                     Date=DateTime.Parse("12/05/2021 03:10:15 AM")
                },
                new InfoObject()
                {
                     CompanyName="Amazon",
                    ClientName="Johnson Derek",
                     Amount="USD 1000 /=",
                     InvoiceNumber="P095212",
                     Status="Paid",
                     Date=DateTime.Parse("15/05/2021 12:10:15 PM")
                },
                new InfoObject()
                {
                     CompanyName="Microsoft",
                    ClientName="Victoria Wells",
                     Amount="USD 870 /=",
                     InvoiceNumber="P235212",
                     Status="Past Due",
                     Date=DateTime.Parse("17/05/2021 08:07:25 AM")
                },
                    new InfoObject()
                {
                         CompanyName="Digital Ocean",
                    ClientName="Feliz Xander",
                     Amount="Euro 1220 /=",
                     InvoiceNumber="P2352r12",
                     Status="Private",
                     Date=DateTime.Parse("17/05/2021 02:14:15 AM")
                },
                    new InfoObject()
                {
                        CompanyName="Microsoft",
                    ClientName="Andrey Wesley",
                     Amount="Ksh 49200 /=",
                     InvoiceNumber="P662212",
                     Status="Past Due",
                     Date=DateTime.Parse("19/05/2021 10:10:25 AM")
                },
                        new InfoObject()
                {
                    ClientName="Michael davids",
                    CompanyName="Google",
                     Amount="USD 9000 /=",
                     InvoiceNumber="P235212",
                     Status="Paid",
                     Date=DateTime.Parse("21/05/2021 12:10:15 PM")
                }
        };

            dataTable.Columns.Add(" ");
            dataTable.Columns.Add("Company Name");
            dataTable.Columns.Add("Client Name");
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("Invoice Number");
            dataTable.Columns.Add("Amount");
            dataTable.Columns.Add("Status");
     

            foreach (var info in infoObjects)
            {

                DataRow row = dataTable.NewRow();
                row[1] = info.CompanyName;
                row[2] = info.ClientName;
                row[3] = info.Date;
                row[4] = info.InvoiceNumber;
                row[5] = info.Amount;
                row[6] = info.Status;
                dataTable.Rows.Add(row);
            }

            bunifuDataGridView1.DataSource = dataTable;
        }
        private void FormatColumnsAndCells()
        {
            bunifuDataGridView1.Columns[0].Width = 1;
            

            List<Color> colors = new List<Color>()
            {
                Color.FromArgb(7, 162, 135),
                Color.FromArgb(61, 245, 214),
                Color.FromArgb(249, 138, 36),
            };
            Random random = new Random();
            for (int i = 0; i < bunifuDataGridView1.RowCount; i++)
            {
                int colorVal = random.Next(0, 2);
                bunifuDataGridView1[0, i].Style.BackColor = colors[colorVal];
                bunifuDataGridView1[0, i].Style.SelectionBackColor = colors[colorVal];
                bunifuDataGridView1[3, i].Style.ForeColor = Color.Gray;
            }

            for (int i = 0; i < bunifuDataGridView1.RowCount; i++)
            {
                string val = bunifuDataGridView1[6, i].Value.ToString();
                if (val == "Paid")
                {
                    bunifuDataGridView1[6, i].Style.ForeColor = Color.FromArgb(18, 184, 155);
                    bunifuDataGridView1[6, i].Style.SelectionForeColor = Color.FromArgb(18, 184, 155);
                }
                else if (val == "Past Due")
                {
                    bunifuDataGridView1[6, i].Style.ForeColor = Color.FromArgb(226, 81, 81);
                    bunifuDataGridView1[6, i].Style.SelectionForeColor = Color.FromArgb(226, 81, 81);
                }
                else
                {
                    bunifuDataGridView1[6, i].Style.ForeColor = Color.FromArgb(249, 138, 36);
                    bunifuDataGridView1[6, i].Style.SelectionForeColor = Color.FromArgb(249, 138, 36);
                }
            }
        }
        private void CreateDropdownColumn()
        {
            DataGridViewComboBoxCell dataGridViewCombo = new DataGridViewComboBoxCell();
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.Items.AddRange(new string[]
            {
                 "Action",
                "Copy",
                "Send Mail",
                "Before Due",
                "Past Due"
            });
            comboBoxColumn.HeaderText = "Action";
            comboBoxColumn.DropDownWidth = 120;
            comboBoxColumn.MaxDropDownItems = 3;
            comboBoxColumn.Width = 100;
            comboBoxColumn.Name = "Action";
            comboBoxColumn.FlatStyle = FlatStyle.Flat;
            comboBoxColumn.CellTemplate.Style.ForeColor = Color.Gray;
            comboBoxColumn.ValueMember = "Action";
            comboBoxColumn.CellTemplate.Style.BackColor = Color.White;
            comboBoxColumn.CellTemplate.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            bunifuDataGridView1.Columns.Add(comboBoxColumn);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            LoadData();
            FormatColumnsAndCells();
            CreateDropdownColumn();
            panel5.SendToBack();
            bunifuPages1.SelectTab(1);
        }

        private void bunifuDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 7 && e.Value==null)
            {
                e.Value = "Select Action";
            }
        }

        private void bunifuDataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
         
        }

        private void bunifuDataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private async void monthlyBunifuRadioButton2_CheckedChanged2(object sender, BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuPages1.SelectTab(0);
                await Task.Delay(800);
                bunifuChartCanvas1.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;
                bunifuChartCanvas1.Update();
                bunifuChartCanvas1.Refresh();
                panel9.BringToFront();
                panel8.SendToBack();
                panel6.BringToFront();
                panel5.BringToFront();
            }
        }

        private async void weeklyBunifuRadioButton1_CheckedChanged2(object sender, BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuPages1.SelectTab(1);

                await Task.Delay(800);
                bunifuChartCanvas2.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;          
                bunifuChartCanvas2.Update();
                bunifuChartCanvas2.Refresh();
                panel5.SendToBack();
                panel3.BringToFront();
                panel6.BringToFront();
                panel8.BringToFront();

            }
        }
            private async void yearlyBunifuRadioButton3_CheckedChanged2(object sender, BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuPages1.SelectTab(2);
                await Task.Delay(800);
                bunifuChartCanvas3.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;
                bunifuChartCanvas3.Update();
                bunifuChartCanvas3.Refresh();
                panel6.SendToBack();
                panel7.BringToFront();
                panel5.BringToFront();
                panel8.BringToFront();

            }
        }
        
        private void GetWeeklyData()
        {
        
        }
        private void GetMonthlyData()
        {

        }
        private void bunifuLabel28_Click(object sender, EventArgs e)
        {

        }
    }
}
