﻿using System;
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
    public partial class FrmStartStop : Form
    {
        public FrmStartStop()
        {
            InitializeComponent();
        }

        private void btnConfig_Click(object sender, EventArgs e) =>
            new FrmConfig().ShowDialog();
    }
}