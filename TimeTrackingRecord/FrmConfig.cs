using ExtensionMethods;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Models;

namespace TimeTrackingRecord
{
    public partial class FrmConfig : Form
    {
        private SalaryValuesModel _salary;

        public FrmConfig()
        {
            InitializeComponent();
        }

        public void SetDefaultTextBoxesAndShowDialog()
        {
            _salary = new SalaryValuesModel();
            SetTextBoxes();
            ShowDialog();
        }

        private void SetTextBoxes()
        {
            if (!chkAutomatic.Checked) return;
            txtSalaryMonth.Value = _salary.Month;
            txtSalaryHour.Value = _salary.Hour;
            txtOvertime.Value = _salary.Overtime;
        }

        private void txtSalaryMonth_ValueChanged(object sender, EventArgs e)
        {
            _salary.Month = txtSalaryMonth.Value;
            _salary.Hour = _salary.Month / 220;
            _salary.Overtime = _salary.Hour + _salary.Hour / 2;
            SetTextBoxes();
        }

        private void txtSalaryHour_ValueChanged(object sender, EventArgs e)
        {
            _salary.Hour = txtSalaryHour.Value;
            _salary.Overtime = _salary.Hour + _salary.Hour / 2;
            _salary.Month = _salary.Hour * 220;
            SetTextBoxes();
        }

        private void txtOvertime_ValueChanged(object sender, EventArgs e)
        {
            _salary.Overtime = txtOvertime.Value;
            _salary.Hour = _salary.Overtime * 100 / 150;
            _salary.Month = _salary.Hour * 220;
            SetTextBoxes();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var valuesJson = JsonConvert.SerializeObject(_salary);

            var file = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\ttrconfig.txt";

            using (var tw = new StreamWriter(file, false, Encoding.UTF8))
                tw.WriteLine(valuesJson.ToBase64());

            Close();
        }
    }
}
