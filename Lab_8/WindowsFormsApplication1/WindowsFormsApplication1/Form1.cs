using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            double perv1 = 8; double perv2 = 6; double perv3 = 2; double perv4 = 4;
            double vto1 = 8; double vto2 = 9; double vto3 = 4; double vto4 = 5; 
            double tre1 = 7; double tre2 = 5; double tre3 = 3; double tre4 = 5; 

            dataGridView1.Rows.Add(perv1, perv2, perv3, perv4);
            dataGridView1.Rows.Add(vto1, vto2, vto3, vto4);
            dataGridView1.Rows.Add(tre1, tre2, tre3, tre4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s1 = dataGridView1[0, 0].Value.ToString();
            double as1 = Convert.ToDouble(s1);
            String s2 = dataGridView1[1, 0].Value.ToString();
            double as2 = Convert.ToDouble(s2);
            String s3 = dataGridView1[2, 0].Value.ToString();
            double as3 = Convert.ToDouble(s3);
            String s4 = dataGridView1[3, 0].Value.ToString();
            double as4 = Convert.ToDouble(s4);

            double[] array = { as1, as2, as3, as4 };
            double min = double.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            textBox5.Text = min.ToString();
            ///////////////////////////////////////////////////////
            String a1 = dataGridView1[0, 1].Value.ToString();
            double aa1 = Convert.ToDouble(a1);
            String a2 = dataGridView1[1, 1].Value.ToString();
            double aa2 = Convert.ToDouble(a2);
            String a3 = dataGridView1[2, 1].Value.ToString();
            double aa3 = Convert.ToDouble(a3);
            String a4 = dataGridView1[3, 1].Value.ToString();
            double aa4 = Convert.ToDouble(a4);

            double[] arraya = { aa1, aa2, aa3, aa4 };
            double mina = double.MaxValue;
            for (int i = 0; i < arraya.Length; i++)
            {
                if (arraya[i] < mina)
                    mina = arraya[i];
            }
            textBox6.Text = mina.ToString();
            ///////////////////////////////////////////////////////
            String b1 = dataGridView1[0, 2].Value.ToString();
            double ab1 = Convert.ToDouble(b1);
            String b2 = dataGridView1[1, 2].Value.ToString();
            double ab2 = Convert.ToDouble(b2);
            String b3 = dataGridView1[2, 2].Value.ToString();
            double ab3 = Convert.ToDouble(b3);
            String b4 = dataGridView1[3, 2].Value.ToString();
            double ab4 = Convert.ToDouble(b4);

            double[] arrayb = { ab1, ab2, ab3, ab4 };
            double minb = double.MaxValue;
            for (int i = 0; i < arrayb.Length; i++)
            {
                if (arrayb[i] < minb)
                    minb = arrayb[i];
            }
            textBox7.Text = minb.ToString();
            ///////////////////////////////////////////////////////
            ///MAX B
            ///////////////////////////////////////////////////////
            double[] arrays = { min, mina, minb };
            double maxs = double.MinValue;
            for (int i = 0; i < arrays.Length; i++)
            {
                if (arrays[i] > maxs)
                    maxs = arrays[i];
            }
            label4.Text = maxs.ToString();
            ///////////////////////////////////////////////////////////////////////////////
            String c1 = dataGridView1[0, 0].Value.ToString();
            double ac1 = Convert.ToDouble(c1);
            String c2 = dataGridView1[0, 1].Value.ToString();
            double ac2 = Convert.ToDouble(c2);
            String c3 = dataGridView1[0, 2].Value.ToString();
            double ac3 = Convert.ToDouble(c3);

            double[] arrayc = { ac1, ac2, ac3 };
            double minc = double.MaxValue;
            for (int i = 0; i < arrayc.Length; i++)
            {
                if (arrayc[i] < minc)
                    minc = arrayc[i];
            }
            textBox1.Text = minc.ToString();
            ///////////////////////////////////////////////////////
            String d1 = dataGridView1[1, 0].Value.ToString();
            double ad1 = Convert.ToDouble(d1);
            String d2 = dataGridView1[1, 1].Value.ToString();
            double ad2 = Convert.ToDouble(d2);
            String d3 = dataGridView1[1, 2].Value.ToString();
            double ad3 = Convert.ToDouble(d3);

            double[] arrayd = { ad1, ad2, ad3 };
            double mind = double.MaxValue;
            for (int i = 0; i < arrayd.Length; i++)
            {
                if (arrayd[i] < mind)
                    mind = arrayd[i];
            }
            textBox2.Text = mind.ToString();
            ///////////////////////////////////////////////////////
            String e1 = dataGridView1[2, 0].Value.ToString();
            double ae1 = Convert.ToDouble(e1);
            String e2 = dataGridView1[2, 1].Value.ToString();
            double ae2 = Convert.ToDouble(e2);
            String e3 = dataGridView1[2, 2].Value.ToString();
            double ae3 = Convert.ToDouble(e3);

            double[] arraye = { ae1, ae2, ae3};
            double mine = double.MaxValue;
            for (int i = 0; i < arraye.Length; i++)
            {
                if (arraye[i] < mine)
                    mine = arraye[i];
            }
            textBox3.Text = mine.ToString();
            ///////////////////////////////////////////////////////
            String f1 = dataGridView1[3, 0].Value.ToString();
            double af1 = Convert.ToDouble(f1);
            String f2 = dataGridView1[3, 1].Value.ToString();
            double af2 = Convert.ToDouble(f2);
            String f3 = dataGridView1[3, 2].Value.ToString();
            double af3 = Convert.ToDouble(f3);

            double[] arrayf = { af1, af2, af3 };
            double minf = double.MaxValue;
            for (int i = 0; i < arrayf.Length; i++)
            {
                if (arrayf[i] < minf)
                    minf = arrayf[i];
            }
            textBox4.Text = minf.ToString();
            ///////////////////////////////////////////////////////
            ///MAX A
            ///////////////////////////////////////////////////////
            double[] arrayss = { minc, mind, mine,minf };
            double maxss = double.MinValue;
            for (int i = 0; i < arrayss.Length; i++)
            {
                if (arrayss[i] > maxss)
                    maxss = arrayss[i];
            }
            label3.Text = maxss.ToString();
            ///////////////////////////////////////////////////////

        }
    }
}
