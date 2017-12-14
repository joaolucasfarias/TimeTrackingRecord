using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTrackingRecord
{
    public partial class FrmConfig : Form
    {
        private decimal _salaryMonth, _salaryHour;

        public FrmConfig()
        {
            InitializeComponent();
        }

        public void SetDefaultTextBoxesAndShowDialog()
        {
            SetTextBoxes();
            ShowDialog();
        }

        private void SetTextBoxes()
        {
            txtSalaryMonth.Value = _salaryMonth;
            txtSalaryHour.Value = _salaryHour;
        }
    }
}
