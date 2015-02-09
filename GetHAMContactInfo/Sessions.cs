﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GetHAMContactInfo
{
    public partial class Sessions : Form
    {
        public Sessions()
        {
            InitializeComponent();
        }

        private void Sessions_Load(object sender, EventArgs e)
        {
            gridSessions.DataSource = SessionsController.GetDataSet().Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SessionsController.SaveDataSet();
        }
    }
}
