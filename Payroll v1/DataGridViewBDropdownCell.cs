using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Bunifu.UI.WinForms;

namespace Payroll_v1
{

    class DataGridViewBDropdownCell : DataGridViewImageCell
    {
        public override Type ValueType
        {
            get { return typeof(BunifuDropdown); }
        }
        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, "", errorText, cellStyle, advancedBorderStyle, paintParts);
           
            BunifuDropdown ctrl = new BunifuDropdown();
            ctrl.Size = new Size(128, 21);
            ctrl.Height = 15;
            ctrl.Location = cellBounds.Location;
            
        }
        protected override void OnClick(DataGridViewCellEventArgs e)
        {
            List<InfoObject> objs = DataGridView.DataSource as List<InfoObject>;
            if (objs == null)
                return;
            if (e.RowIndex < 0 || e.RowIndex >= objs.Count)
                return;
         //  BunifuDropdown dropdown = objs[e.RowIndex].Dropdown;
            MessageBox.Show("uu");
           DataGridView.InvalidateCell(e.ColumnIndex, e.RowIndex);
        }
    }
}
