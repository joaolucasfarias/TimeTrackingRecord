using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtensionMethods;
using Newtonsoft.Json;

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
            if (!chkAutomatic.Checked) return;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            var values = new
            {
                Month = _salaryMonth,
                Hour = _salaryHour,
                Overtime = _overtime
            };

            var valuesJson = JsonConvert.SerializeObject(values);

            var file = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\ttrconfig.txt";

            using (var tw = new StreamWriter(file, false, Encoding.UTF8))
                tw.WriteLine(valuesJson.ToBase64());

            Close();
        }
    }
}
