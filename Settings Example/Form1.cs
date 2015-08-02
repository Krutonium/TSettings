﻿using System;
using System.Windows.Forms;
using TSettings;
using TSettings.Encryptions;

namespace Settings_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Settings.Encryption = new DesEncrpytion("ABCDEFGH", "ABCDEFGH");

            yourage.Value = Settings.Default.Get<Decimal>("age", 0);
            firstname.Text = Settings.Default.Get("name", "No name set");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default.Set("age", yourage.Value);
            Settings.Default.Set("name", firstname.Text);
            Settings.Default.Save();
        }
    }
}
