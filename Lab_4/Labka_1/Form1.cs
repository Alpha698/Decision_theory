using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labka_1
{
    public partial class Form1 : Form
    {
        public object dataGridView2;

        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Обработчик нажатия на кнопку
        public void button1_Click(object sender, EventArgs e)
        {
            //Ввод Лямбды, Мю и кол-ва узлов
            string lam = textBox1.Text;
            string miy = textBox2.Text;
            string n = textBox3.Text;
            double a = Convert.ToDouble(lam);
            double b = Convert.ToDouble(miy);
            double c = Convert.ToDouble(n);
            
            double fir = (c-(c-1))*a;
            double sec = c * b;
            //Расчет k
            double k = 0;
            double k1 = 1;
            double k2 = 2;
            double k3 = 3;
            double k4 = 4;

            double lak = (c-k)*a;
            double lak1 = (c - k1) * a;
            double lak2 = (c - k2) * a;
            double lak3 = (c - k3) * a;
            double lak4 = (c - k4) * a;

            double miyk = k * b;
            double miyk1 = k1 * b;
            double miyk2 = k2 * b;
            double miyk3 = k3 * b;
            double miyk4 = k4 * b;

            double Pi = lak/miyk1;
            double Pi1 = (lak*lak1) / (miyk2*miyk1);
            double Pi2 = (lak * lak1 * lak2) / (miyk3 * miyk1 * miyk2);
            double Pi3 = (lak * lak1 * lak2 * lak3) / (miyk3 * miyk1 * miyk2 * miyk4);
            double sumPi = Pi+ Pi1+ Pi2+ Pi3;

            double pro = Math.Pow(2.71828, ((lak * miyk1) * (-1)));
            double Pk = 1 - pro;
            double pro1 = Math.Pow(2.71828, ((lak1 * miyk2) * (-1)));
            double Pk1 = 1 - pro1;
            double pro2 = Math.Pow(2.71828, ((lak2 * miyk3) * (-1)));
            double Pk2 = 1 - pro2;
            double pro3 = Math.Pow(2.71828, ((lak3 * miyk4) * (-1)));
            double Pk3 = 1 - pro3;
            double sumPk = Pk+Pk1+ Pk2+ Pk3;
            //Вывод таблицы
            dataGridView1.Rows.Add(k, lak, miyk, Pi, Pk);
            dataGridView1.Rows.Add(k1, lak1, miyk1, Pi1, Pk1);
            dataGridView1.Rows.Add(k2, lak2, miyk2, Pi2, Pk2);
            dataGridView1.Rows.Add(k3, lak3, miyk3, Pi3, Pk3);
            dataGridView1.Rows.Add(k4, lak4, miyk4);
            //Вывод значений
            label9.Text = fir.ToString();
            label10.Text = sec.ToString();
            label13.Text = sumPi.ToString();
            label14.Text = sumPk.ToString();
            //char lambda = '\u03BB';
            //this.label7.Text = lambda.ToString() + "k-1.k";

            //Вывод гистограммы
            chart3.Series["Info"].Points.AddXY("1", Pk);
            chart3.Series["Info"].Points.AddXY("2", Pk1);
            chart3.Series["Info"].Points.AddXY("3", Pk2);
            chart3.Series["Info"].Points.AddXY("4", Pk3);

        }
    }
}
