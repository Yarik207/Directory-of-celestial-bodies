using AutoSalonn.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSalonn
{
    public struct sky
    {
        public string name;
        public string mass;
        public string tipe;
        public Button btn;
        public PictureBox pb;

        public sky(string _name, string _mass, string _tipe)
        {
            name = _name;
            mass = _mass;
            tipe = _tipe;
            btn = new Button();
            btn.Text = name;
            pb = new PictureBox();
           // try
            {
                pb.Load("../../Pictures/" + name + ".bmp");   
            }
            //catch (Exception) { }
        }

    }
    
    
    public partial class FilterForm : Form
    {
        sky[] sky_list = new sky[12];

        public FilterForm()
        {
            InitializeComponent();
            sky_list[0] = new sky("СтрелецА", "миллионКГ","квазар");
            sky_list[1] = new sky("Гаргантюа", "стоКГ", "дырка");
            sky_list[2] = new sky("Кластер  Феникс", "МилллиардКГ", "черный");
            sky_list[3] = new sky("TON 618", "ТрилиардКГ", "блэк");
            sky_list[4] = new sky("S5 0014+81", "1000 Sollar Mass", "Радио Квазар");
            sky_list[5] = new sky("NGC 6166", "10 * 10^10 Sollar Mass", "эллиптическая галактика");
            sky_list[6] = new sky("СтрелецА", "миллионКГ", "квазар");
            sky_list[7] = new sky("Гаргантюа", "стоКГ", "дырка");
            sky_list[8] = new sky("Кластер  Феникс", "МилллиардКГ", "черный");
            sky_list[9] = new sky("TON 618", "ТрилиардКГ", "блэк");
            sky_list[10] = new sky("S5 0014+81", "1000 Sollar Mass", "Радио Квазар");
            sky_list[11] = new sky("NGC 6166", "10 * 10^10 Sollar Mass", "эллиптическая галактика");


            int x = 10;
            int y = 200; 
            for (int i = 0; i < 12; i++)
            {
                sky_list[i].btn.Font = new Font("Microsoft Sans Serif", 12F);
                sky_list[i].btn.Location = new Point(x, y);
                sky_list[i].btn.Size = new Size(200, 30);
                sky_list[i].btn.Click += new EventHandler(this.button1_Click);
                Controls.Add(sky_list[i].btn);

                sky_list[i].pb.Location = new Point(x, y + 30);
                sky_list[i].pb.Size = new Size(200, 210);
                sky_list[i].pb.SizeMode = PictureBoxSizeMode.StretchImage;
                Controls.Add(sky_list[i].pb);

                x += 210;

                if (x > 800)
                {
                    x = 10;
                    y += 210;
                }
            }
           
        }

        private void Findbutton_Click(object sender, EventArgs e)
        {
            int x = 10;
            int y = 210;

            for (int i = 0; i < 12; i++)
            {
                sky_list[i].btn.Visible = true;
                sky_list[i].pb.Visible = true;

                if (typecomboBox1.Text != "" &&
                    typecomboBox1.Text != sky_list[i].tipe)
                {
                    sky_list[i].btn.Visible = false;
                    sky_list[i].pb.Visible = false;
                }

                if (masscomboBox2.Text != "" &&
                    masscomboBox2.Text != sky_list[i].mass)
                {
                    sky_list[i].btn.Visible = false;
                    sky_list[i].pb.Visible = false;
                }

                if (namecomboBox3.Text != "" &&
                    namecomboBox3.Text != sky_list[i].name)
                {
                    sky_list[i].btn.Visible = false;
                    sky_list[i].pb.Visible = false;
                }

                if (sky_list[i].pb.Visible)
                {
                    sky_list[i].btn.Location = new Point(x, y);                    
                    sky_list[i].pb.Location = new Point(x, y + 30);
                    x += 210;                
                    if (x > 800)
                    {
                        x = 10;
                        y += 210;
                    }
                }
                    

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            SpaceForm sky = new SpaceForm(btn.Text);
            sky.Show();
        }

        private void typecomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
