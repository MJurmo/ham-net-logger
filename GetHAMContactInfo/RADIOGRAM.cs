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
    public partial class RADIOGRAM : Form
    {
        private string m_ID;
        public RADIOGRAM(string ID)
        {
            InitializeComponent();
            m_ID = ID;
        }
    }
}
