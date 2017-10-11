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

        public void Form1_Load(object sender, EventArgs e)
        {


        }

        private void результатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Результаты результат = new Результаты();
            результат.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string per = textBox1.Text;
            string wto = textBox6.Text;
            string tre = textBox11.Text;
            string che = textBox16.Text;
            string pat = textBox21.Text;
            double a = Convert.ToDouble(per);
            double b = Convert.ToDouble(wto);
            double c = Convert.ToDouble(tre);
            double d = Convert.ToDouble(che);
            double eb = Convert.ToDouble(pat);

            string per2 = textBox2.Text;
            string wto2 = textBox7.Text;
            string tre2 = textBox12.Text;
            string che2 = textBox17.Text;
            string pat2 = textBox22.Text;
            double a2 = Convert.ToDouble(per2);
            double b2 = Convert.ToDouble(wto2);
            double c2 = Convert.ToDouble(tre2);
            double d2 = Convert.ToDouble(che2);
            double eb2 = Convert.ToDouble(pat2);

            string per3 = textBox3.Text;
            string wto3 = textBox8.Text;
            string tre3 = textBox13.Text;
            string che3 = textBox18.Text;
            string pat3 = textBox23.Text;
            double a3 = Convert.ToDouble(per3);
            double b3 = Convert.ToDouble(wto3);
            double c3 = Convert.ToDouble(tre3);
            double d3 = Convert.ToDouble(che3);
            double eb3 = Convert.ToDouble(pat3);

            string per4 = textBox4.Text;
            string wto4 = textBox9.Text;
            string tre4 = textBox14.Text;
            string che4 = textBox19.Text;
            string pat4 = textBox24.Text;
            double a4 = Convert.ToDouble(per4);
            double b4 = Convert.ToDouble(wto4);
            double c4 = Convert.ToDouble(tre4);
            double d4 = Convert.ToDouble(che4);
            double eb4 = Convert.ToDouble(pat4);

            string per5 = textBox5.Text;
            string wto5 = textBox10.Text;
            string tre5 = textBox15.Text;
            string che5 = textBox20.Text;
            string pat5 = textBox25.Text;
            double a5 = Convert.ToDouble(per5);
            double b5 = Convert.ToDouble(wto5);
            double c5 = Convert.ToDouble(tre5);
            double d5 = Convert.ToDouble(che5);
            double eb5 = Convert.ToDouble(pat5);

            double r1 = Math.Pow(a * b * c * d * eb, 0.2);
            double r2 = Math.Pow(a2 * b2 * c2 * d2 * eb2, 0.2);
            double r3 = Math.Pow(a3 * b3 * c3 * d3 * eb3, 0.2);
            double r4 = Math.Pow(a4 * b4 * c4 * d4 * eb4, 0.2);
            double r5 = Math.Pow(a5 * b5 * c5 * d5 * eb5, 0.2);//double pers = a * b * c * d * eb; 

            double sum = r1+r2+r3+r4+r5;

            double roz = r1 / sum;
            double roz2 = r2 / sum;
            double roz3 = r3 / sum;
            double roz4 = r4 / sum;
            double roz5 = r5 / sum;

            double sums1 = a + a2 + a3 + a4 + a5;
            double sums2 = b + b2 + b3 + b4 + b5;
            double sums3 = c + c2 + c3 + c4 + c5;
            double sums4 = d + d2 + d3 + d4 + d5;
            double sums5 = eb + eb2 + eb3 + eb4 + eb5;///////////////////

            double pro = sums1 * roz;
            double pro2 = sums2 * roz2;
            double pro3 = sums3 * roz3;
            double pro4 = sums4 * roz4;
            double pro5 = sums5 * roz5;

            double lmax = pro + pro2 + pro3 + pro4 + pro5;
            double ies = (lmax-5)/4;
            double os = (ies / 0.58)*100;

            dataGridView1.Rows.Add(a, b, c, d, eb, r1, roz);
            dataGridView1.Rows.Add(a2, b2, c2, d2, eb2, r2, roz2);
            dataGridView1.Rows.Add(a3, b3, c3, d3, eb3, r3, roz3);
            dataGridView1.Rows.Add(a4, b4, c4, d4, eb4, r4, roz4);
            dataGridView1.Rows.Add(a5, b5, c5, d5, eb5, r5, roz5);

            label12.Text = sum.ToString();

            label14.Text = sums1.ToString();
            label15.Text = sums2.ToString();
            label16.Text = sums3.ToString();
            label17.Text = sums4.ToString();
            label18.Text = sums5.ToString();

            label20.Text = pro.ToString();
            label21.Text = pro2.ToString();
            label22.Text = pro3.ToString();
            label23.Text = pro4.ToString();
            label24.Text = pro5.ToString();

            label26.Text = lmax.ToString();
            label28.Text = ies.ToString();
            label30.Text = os.ToString()+"%";

            double[] array = { roz, roz2, roz3, roz4, roz5 };
            double max = double.MinValue;
            for(int i =0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            label32.Text = max.ToString();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void критерий1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabl1 критерии = new tabl1();
            критерии.ShowDialog();

        }

        private void критерий2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabl2 критерии = new tabl2();
            критерии.ShowDialog();
        }

        private void критерий3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabl3 критерии = new tabl3();
            критерии.ShowDialog();
        }

        private void критерий4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabl4 критерии = new tabl4();
            критерии.ShowDialog();
        }

        private void критерий5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabl5 критерии = new tabl5();
            критерии.ShowDialog();
        }
    }
}
