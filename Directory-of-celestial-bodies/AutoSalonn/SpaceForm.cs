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
    public partial class SpaceForm : Form
    {
        public SpaceForm(string Space)
        {
            InitializeComponent();

            Text = Space;
            label1.Text = Space;
            try
            {
                pictureBox1.Load("../../Pictures/" + Space + ".bmp");
                textBox1.Text = File.ReadAllText("../../Pictures/" + Space + ".txt");
            }
            catch (Exception) { }
        }

        private static void SpaceForm_Load(object sender, EventArgs e)
        {

        }
    }
}
