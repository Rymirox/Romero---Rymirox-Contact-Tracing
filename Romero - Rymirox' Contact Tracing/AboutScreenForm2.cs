﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Romero___Rymirox__Contact_Tracing
{
    public partial class AboutScreenForm2 : Form
    {
        public AboutScreenForm2()
        {
            InitializeComponent();
        }

        private void buttonASF1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutScreenForm aboutScreenForm = new AboutScreenForm();
            aboutScreenForm.Show();
        }

        private void buttonASF2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutScreenForm3 aboutScreenForm3 = new AboutScreenForm3();
            aboutScreenForm3.Show();
        }
    }
}
