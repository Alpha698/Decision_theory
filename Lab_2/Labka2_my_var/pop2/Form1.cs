using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pop2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string per = textBox1.Text;
            string wto = textBox2.Text;
            double a = Convert.ToDouble(per);
            double b = Convert.ToDouble(wto);

            string per2 = textBox6.Text;
            string wto2 = textBox7.Text;
            double a2 = Convert.ToDouble(per2);
            double b2 = Convert.ToDouble(wto2);

            string per3 = textBox11.Text;
            string wto3 = textBox12.Text;
            double a3 = Convert.ToDouble(per3);
            double b3 = Convert.ToDouble(wto3);


            string r1 = textBox5.Text;
            string r2 = textBox10.Text;
            double rr1 = Convert.ToDouble(r1);
            double rr2 = Convert.ToDouble(r2);
           

            double summ = rr1 + rr2;
            double z1 = rr1/summ;
            double z2 = rr2 / summ;

            label12.Text = z1.ToString();
            label26.Text = z2.ToString();


            double W1 = a * z1 + b * z2;
            double W2 = a2 * z1 + b2 * z2;
            double W3 = a3 * z1 + b3 * z2;
            double WS = W1 + W2 + W3;

            label14.Text = W1.ToString();
            label15.Text = W2.ToString();
            label16.Text = W3.ToString();
            label32.Text = WS.ToString();


            double[] array = { W1, W2, W3 };
            double max = double.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            label18.Text = max.ToString();

        }


    }

    }


