﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSalonn
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpForm hf = new HelpForm();
            hf.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            SpaceForm sky = new SpaceForm(btn.Text);
            sky.Show();
        }

        private void Filterbutton_Click(object sender, EventArgs e)
        {
            FilterForm filter = new FilterForm();
            filter.ShowDialog();
        }
    }
}