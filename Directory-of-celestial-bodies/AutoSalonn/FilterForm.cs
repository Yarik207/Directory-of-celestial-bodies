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
    public struct sky
    {
        public string name;
        public int mass;
        public string tipe;
        public int radius;
        public Button btn;

        Button btn = new Button();

        public sky(string _name, int _mass, string _tipe, int _radius, Button btn)
        {
            name = _name;
            mass = _mass;
            tipe = _tipe;
            radius = _radius;
        }

        public sky(string v1, string v2, string v3, string v4) : this()
        {
        }
    }

    public partial class FilterForm : Form
    {
        sky[] sky_list = new sky[4];
        public FilterForm()
        {
            InitializeComponent();
            sky_list[0] = new sky("СтрелецА", "367234534635","квазар", "54332", button1);
            sky_list[1] = new sky("Гаргантюа", "468689566235", "дырка", "12", button2 );
            sky_list[2] = new sky("Кластер  Феникс", "23456765432", "черный", "123123", button3 );
            sky_list[3] = new sky("TON 618", "67", "блэк", "354346", button4);
        }

        private void Findbutton_Click(object sender, EventArgs e)
        {
            for(int i=0; i<4; i++)
            {
                if (comboBox1.Text == sky_list[i].tipe)
                {
                    sky_list[i].btn.Visible = false;    
                }    
            }
        }
    }
}
