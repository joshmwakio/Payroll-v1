
namespace Payroll_v1
{
    partial class RevenueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RevenueForm));
            this.bunifuLabel23 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuChartCanvas1 = new Bunifu.Charts.WinForms.BunifuChartCanvas();
            this.bunifuHorizontalBarChart1 = new Bunifu.Charts.WinForms.ChartTypes.BunifuHorizontalBarChart(this.components);
            this.SuspendLayout();
            // 
            // bunifuLabel23
            // 
            this.bunifuLabel23.AllowParentOverrides = false;
            this.bunifuLabel23.AutoEllipsis = false;
            this.bunifuLabel23.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel23.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel23.Font = new System.Drawing.Font("Roboto", 14F);
            this.bunifuLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(39)))), ((int)(((byte)(33)))));
            this.bunifuLabel23.Location = new System.Drawing.Point(30, 26);
            this.bunifuLabel23.Name = "bunifuLabel23";
            this.bunifuLabel23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel23.Size = new System.Drawing.Size(194, 23);
            this.bunifuLabel23.TabIndex = 4;
            this.bunifuLabel23.Text = "Organic Food Revenue";
            this.bunifuLabel23.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel23.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuChartCanvas1
            // 
            this.bunifuChartCanvas1.AnimationDuration = 1000;
            this.bunifuChartCanvas1.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;
            this.bunifuChartCanvas1.BackColor = System.Drawing.Color.White;
            this.bunifuChartCanvas1.CanvasPadding = new System.Windows.Forms.Padding(0, 0, 25, 120);
            this.bunifuChartCanvas1.Labels = new string[] {
        "United States of America",
        "German",
        "France",
        "Kenya",
        "China",
        "United Kingdom",
        "Italy",
        "SwitzerLand"};
            this.bunifuChartCanvas1.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center;
            this.bunifuChartCanvas1.LegendDisplay = true;
            this.bunifuChartCanvas1.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuChartCanvas1.LegendForeColor = System.Drawing.Color.DarkGray;
            this.bunifuChartCanvas1.LegendFullWidth = true;
            this.bunifuChartCanvas1.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.bunifuChartCanvas1.LegendRevese = false;
            this.bunifuChartCanvas1.LegendRTL = false;
            this.bunifuChartCanvas1.Location = new System.Drawing.Point(32, 66);
            this.bunifuChartCanvas1.Name = "bunifuChartCanvas1";
            this.bunifuChartCanvas1.ShowXAxis = true;
            this.bunifuChartCanvas1.ShowYAxis = true;
            this.bunifuChartCanvas1.Size = new System.Drawing.Size(781, 281);
            this.bunifuChartCanvas1.TabIndex = 5;
            this.bunifuChartCanvas1.Title = "";
            this.bunifuChartCanvas1.TitleLineHeight = 1.2D;
            this.bunifuChartCanvas1.TitlePadding = 10;
            this.bunifuChartCanvas1.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.bunifuChartCanvas1.TooltipBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.TooltipFont = new System.Drawing.Font("Roboto", 14F);
            this.bunifuChartCanvas1.TooltipForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuChartCanvas1.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest;
            this.bunifuChartCanvas1.TooltipsEnabled = true;
            this.bunifuChartCanvas1.XAxesBeginAtZero = true;
            this.bunifuChartCanvas1.XAxesDrawTicks = true;
            this.bunifuChartCanvas1.XAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.XAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas1.XAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.XAxesGridLines = true;
            this.bunifuChartCanvas1.XAxesLabel = "";
            this.bunifuChartCanvas1.XAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.XAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas1.XAxesLineWidth = 1;
            this.bunifuChartCanvas1.XAxesStacked = false;
            this.bunifuChartCanvas1.XAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.XAxesZeroLineWidth = 1;
            this.bunifuChartCanvas1.YAxesBeginAtZero = true;
            this.bunifuChartCanvas1.YAxesDrawTicks = true;
            this.bunifuChartCanvas1.YAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.YAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas1.YAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.YAxesGridLines = true;
            this.bunifuChartCanvas1.YAxesLabel = "";
            this.bunifuChartCanvas1.YAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.YAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas1.YAxesLineWidth = 1;
            this.bunifuChartCanvas1.YAxesStacked = false;
            this.bunifuChartCanvas1.YAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.YAxesZeroLineWidth = 1;
            // 
            // bunifuHorizontalBarChart1
            // 
            this.bunifuHorizontalBarChart1.BackgroundColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("bunifuHorizontalBarChart1.BackgroundColor")));
            this.bunifuHorizontalBarChart1.BorderColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("bunifuHorizontalBarChart1.BorderColor")));
            this.bunifuHorizontalBarChart1.BorderSkipped = null;
            this.bunifuHorizontalBarChart1.BorderWidth = 0;
            this.bunifuHorizontalBarChart1.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("bunifuHorizontalBarChart1.Data")));
            this.bunifuHorizontalBarChart1.HoverBackgroundColor = System.Drawing.Color.Empty;
            this.bunifuHorizontalBarChart1.HoverBorderColor = System.Drawing.Color.Empty;
            this.bunifuHorizontalBarChart1.HoverBorderWidth = 0;
            this.bunifuHorizontalBarChart1.Label = "Revenue in Million Euros";
            this.bunifuHorizontalBarChart1.TargetCanvas = this.bunifuChartCanvas1;
            // 
            // RevenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 417);
            this.Controls.Add(this.bunifuChartCanvas1);
            this.Controls.Add(this.bunifuLabel23);
            this.Name = "RevenueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form";
            this.Load += new System.EventHandler(this.RevenueForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel23;
        private Bunifu.Charts.WinForms.BunifuChartCanvas bunifuChartCanvas1;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuHorizontalBarChart bunifuHorizontalBarChart1;
    }
}