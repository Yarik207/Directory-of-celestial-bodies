using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AutoSalonn
{
    public partial class CarForm : Form
    {
        public CarForm(string carName)
        {
            InitializeComponent();

            Text = carName;
            label1.Text = carName;

            if (carName == "Гаргантюа\r\n")
            {
                pictureBox1.Load("../../Pictures/Otsilka na interstellar.jpg");
                textBox1.Text = "Это лишь модель, схожей черной дыры" +
                                System.Environment.NewLine +
                                "Это очень массивная, быстро вращающаяся" +
                                System.Environment.NewLine +
                                "Вокруг нее вращаются планеты Миллер и Манн, а также безымянная нейтронная звезда " +
                                System.Environment.NewLine +
                                "Масса - +-10^5—10^11 масс Солнца ";
                               
            }

            if (carName == "Стрелец*А")
            {
                pictureBox1.Load("../../Pictures/SterelecA_BlackHole.jpg");
                textBox1.Text = " компактный радиоисточник, находящийся в центре Млечного Пути" +
                                System.Environment.NewLine +
                                "Представляет собой высокоплотный объект — сверхмассивную чёрную дыру" +
                                System.Environment.NewLine +
                                "(4,297 ± 0,042)⋅106 M⊙" +
                                System.Environment.NewLine +
                                "не более 45 а. е. (6732 млн км), не менее 12,7 ± 1,1 млн км (радиус Шварцшильда)." +
                                System.Environment.NewLine +
                                "26 996 ± 100 световых лет";
            }

            if (carName == " Кластер  Феникс")
            {
                pictureBox1.Load("../../Pictures/PhoenixClaster_BlackHole.jpg");
                textBox1.Text = "Сверхмассивная черная дыра в центральной галактике скоплений качает энергию в систему" +
                                System.Environment.NewLine +
                                "Считается, что он в 20 миллиардов раз массивнее Солнца" +
                                System.Environment.NewLine +
                                "а его горизонт должен составлять порядка 118 миллиардов километров в диаметре." +
                                System.Environment.NewLine +
                                "Данные Чандры и различные наблюдения на других длинах волн показали, что эта черная дыра растет быстро со скоростью, в 60 раз превышающей массу Солнца каждый год" +
                                System.Environment.NewLine +
                                "Рост не может длиться более 100 миллионов лет.";
            }

        }

        private void CarForm_Load(object sender, EventArgs e)
        {

        }
    }
}
