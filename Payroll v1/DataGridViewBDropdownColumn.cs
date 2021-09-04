using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_v1
{
    class DataGridViewBDropdownColumn : DataGridViewColumn
    {
        public DataGridViewBDropdownColumn() : base(new DataGridViewBDropdownCell()) { }
        public override DataGridViewCell CellTemplate
        {
            get { return base.CellTemplate; }
            set
            {
                if (value != null && !value.GetType()
              .IsAssignableFrom(typeof(DataGridViewBDropdownCell)))
                    throw new InvalidCastException("It should be a custom Cell");
                base.CellTemplate = value;
            }
        }

    }
}
