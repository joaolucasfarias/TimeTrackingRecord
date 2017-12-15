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
    public partial class FrmStartStop : Form
    {
        private DateTime _start, _stop;

        public FrmStartStop()
        {
            InitializeComponent();
        }

        private void btnConfig_Click(object sender, EventArgs e) =>
            new FrmConfig().SetDefaultTextBoxesAndShowDialog();

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_start == DateTime.MinValue)
            {
                _start = DateTime.Now;
                btnStart.Text = "STOP";
                lblWorkedTime.Visible = false;
            }
            else
            {
                _stop = DateTime.Now;

                var values = $"{_start};{_stop}";

                var file = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\ttrecords.txt";

                using (var tw = new StreamWriter(file, true, Encoding.UTF8))
                    tw.WriteLine(values.ToBase64());

                var timeDifferenceHours = _stop.Subtract(_start).Hours;
                var timeDifferenceMinutes = _stop.Subtract(_start).Minutes;
                var timeDifferenceSeconds = _stop.Subtract(_start).Seconds;

                lblWorkedTime.Text =
                    $"Worked time: {timeDifferenceHours:00}:{timeDifferenceMinutes:00}:{timeDifferenceSeconds:00}";
                lblWorkedTime.Visible = true;

                _start = DateTime.MinValue;

                btnStart.Text = "START";
            }
        }
    }
}
