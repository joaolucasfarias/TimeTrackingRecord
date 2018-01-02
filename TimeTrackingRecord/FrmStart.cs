using ExtensionMethods;
using Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TimeTrackingRecord
{
    public partial class FrmStartStop : Form
    {
        private readonly WorkedTimeModel _workedTime;

        public FrmStartStop()
        {
            InitializeComponent();
            _workedTime = new WorkedTimeModel();
        }

        private void btnConfig_Click(object sender, EventArgs e) =>
            new FrmConfig().SetDefaultTextBoxesAndShowDialog();

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_workedTime.Start == DateTime.MinValue)
                Start();
            else
                Stop();
        }

        private void Start()
        {
            _workedTime.StartCounting();
            btnStart.Text = "STOP";
            lblWorkedTime.Text = "Worked time: 00:00:00";
            lblWorkedTime.Visible = true;
            btnUpdateWorkedTime.Visible = true;
        }

        private void Stop()
        {
            UpdateWorkedTime();

            var values = $"{_workedTime.Start};{_workedTime.Stop}";

            var file = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\ttrecords.txt";

            using (var tw = new StreamWriter(file, true, Encoding.UTF8))
                tw.WriteLine(values.ToBase64());

            btnStart.Text = "START";
            btnUpdateWorkedTime.Visible = false;
        }

        private void UpdateWorkedTime()
        {
            _workedTime.StopCounting();

            var timeDifferenceHours = _workedTime.DifferenceHours;
            var timeDifferenceMinutes = _workedTime.DifferenceMinutes;
            var timeDifferenceSeconds = _workedTime.DifferenceSeconds;

            lblWorkedTime.Text =
                $"Worked time: {timeDifferenceHours:00}:{timeDifferenceMinutes:00}:{timeDifferenceSeconds:00}";
        }

        private void btnUpdateWorkedTime_Click(object sender, EventArgs e) =>
            UpdateWorkedTime();

        private void btnFinalReport_Click(object sender, EventArgs e)
        {
            var recordsPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\ttrecords.txt";
            if (!File.Exists(recordsPath)) return;
            var configPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\ttrconfig.txt";
            if (!File.Exists(configPath)) return;

            var recordsFileLines = File.ReadAllLines(recordsPath);

            var records =
                recordsFileLines
                    .Where(recordsLine => !string.IsNullOrEmpty(recordsLine))
                    .Select(recordsLine => new WorkedTimeModel().CreateRecord(recordsLine.FromBase64()))
                    .ToList()
                    .GroupBy(record => record.Start.ToString("MM/dd/yyyy"))
                    .Select(
                        record =>
                            new WorkedTimeModel()
                                .CreateGroupedRecord(record.First().Start,
                                    record.Sum(recordSum => recordSum.TotalDifferenceInMinutes))
                    )
                    .ToList();

            var saveAs = new SaveFileDialog
            {
                FileName = "Record Report.txt",
                Filter = @"Text File | *.txt",
                DefaultExt = "txt",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            if (saveAs.ShowDialog() != DialogResult.OK) return;

            double totalSalary = 0;
            var salary =
                JsonConvert.DeserializeObject<SalaryValuesModel>(File.ReadAllLines(configPath)[0].FromBase64());
            using (var saveFile = new StreamWriter(saveAs.OpenFile()))
            {
                saveFile.WriteLine("Report");
                saveFile.WriteLine("");
                foreach (var record in records)
                {
                    double totalSalaryDay;
                    if ((int) record.Start.DayOfWeek != 0)
                        totalSalaryDay = record.SumTotalMinutesGroup * Convert.ToDouble(salary.Overtime / 60);
                    else
                        totalSalaryDay = record.SumTotalMinutesGroup * Convert.ToDouble(salary.Overtime * 2 / 60);
                    totalSalary += totalSalaryDay;
                    saveFile.WriteLine(
                        $"{record.Start:dd/MM/yyyy} => {record.SumTotalMinutesInHours} = {totalSalaryDay:c2}");
                }
                saveFile.WriteLine("");
                saveFile.WriteLine($"Total salary = {totalSalary:c2}");
            }
        }
    }
}
