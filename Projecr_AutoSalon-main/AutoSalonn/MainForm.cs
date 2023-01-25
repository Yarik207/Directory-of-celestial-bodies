using System;
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
            CarForm car = new CarForm(button1.Text);
            car.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CarForm car = new CarForm(button3.Text);
            car.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarForm car = new CarForm(button2.Text);
            car.Show();
        }
    }
}
