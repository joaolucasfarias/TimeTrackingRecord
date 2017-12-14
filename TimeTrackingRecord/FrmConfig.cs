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
        private decimal _salaryMonth, _salaryHour, _overtime;

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
            txtOvertime.Value = _overtime;
        }

        private void txtSalaryMonth_ValueChanged(object sender, EventArgs e)
        {
            _salaryMonth = txtSalaryMonth.Value;
            var salaryDay = _salaryMonth / 30;
            _salaryHour = salaryDay / 8;
            _overtime = _salaryHour + _salaryHour / 2;
            SetTextBoxes();
        }

        private void txtSalaryHour_ValueChanged(object sender, EventArgs e)
        {
            _salaryHour = txtSalaryHour.Value;
            _overtime = _salaryHour + _salaryHour / 2;
            var salaryDay = _salaryHour * 8;
            _salaryMonth = salaryDay * 30;
            SetTextBoxes();
        }

        private void txtOvertime_ValueChanged(object sender, EventArgs e)
        {
            _overtime = txtOvertime.Value;
            _salaryHour = _overtime * 100 / 150;
            var salaryDay = _salaryHour * 8;
            _salaryMonth = salaryDay * 30;
            SetTextBoxes();
        }
    }
}
