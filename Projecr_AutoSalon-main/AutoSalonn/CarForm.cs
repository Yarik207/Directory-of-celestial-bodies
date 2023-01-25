using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Drawing.Text;

namespace AutoSalonn
{
    public partial class CarForm : Form
    {
        public CarForm(string carName)
        {
            InitializeComponent();

            Text = carName;
            label1.Text = carName;
            try
            {
                pictureBox1.Load("../../Pictures/" + carName + ".bmp");
                textBox1.Text = File.ReadAllText("../../Pictures/" + carName + ".txt");
            }
            catch (Exception) { }
          
            private void CarForm_Load(object sender, EventArgs e)
            {

            }
        }      
    }
}
