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
    public partial class tabl4 : Form
    {
        public tabl4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string per = textBox34.Text;
            string wto = textBox35.Text;
            string tre = textBox36.Text;
            string che = textBox37.Text;
            string pia = textBox38.Text;
            double a = Convert.ToDouble(per);
            double b = Convert.ToDouble(wto);
            double c = Convert.ToDouble(tre);
            double d = Convert.ToDouble(che);
            double f = Convert.ToDouble(pia);

            string per2 = textBox39.Text;
            string wto2 = textBox40.Text;
            string tre2 = textBox41.Text;
            string che2 = textBox42.Text;
            string pia2 = textBox43.Text;
            double a2 = Convert.ToDouble(per2);
            double b2 = Convert.ToDouble(wto2);
            double c2 = Convert.ToDouble(tre2);
            double d2 = Convert.ToDouble(che2);
            double f2 = Convert.ToDouble(pia2);



            string koe = textBox26.Text;
            string koef = textBox27.Text;
            string koefi = textBox28.Text;
            double koe2 = Convert.ToDouble(koe);
            double koef2 = Convert.ToDouble(koef);
            double koefi2 = Convert.ToDouble(koefi);


            //ПЕРВАЯ ЯЧЕЙКА
            double[] array2 = { a, a2 };
            double min = double.MaxValue;
            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i] < min)
                    min = array2[i];
            }
            double razn = a - a2;
            double[] array = { razn, 0 };
            double max = double.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            double ras = koe2 * min - koef2 * a2 - koefi2 * max;
            textBox1.Text = ras.ToString();
            //ВТОРАЯ ЯЧЕЙКА
            double[] array3 = { a, b2 };
            double min2 = double.MaxValue;
            for (int i = 0; i < array3.Length; i++)
            {
                if (array3[i] < min2)
                    min2 = array3[i];
            }
            double razn2 = a - a2;
            double[] array4 = { razn2, 0 };
            double max2 = double.MinValue;
            for (int i = 0; i < array4.Length; i++)
            {
                if (array4[i] > max2)
                    max2 = array4[i];
            }
            double ras2 = koe2 * min2 - koef2 * b2 - koefi2 * max2;
            textBox2.Text = ras2.ToString();
            //ТРЕТЬЯ ЯЧЕЙКА
            double[] array5 = { a, c2 };
            double min3 = double.MaxValue;
            for (int i = 0; i < array5.Length; i++)
            {
                if (array5[i] < min3)
                    min3 = array5[i];
            }
            double razn3 = a - a2;
            double[] array6 = { razn3, 0 };
            double max3 = double.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array6[i] > max3)
                    max3 = array6[i];
            }
            double ras3 = koe2 * min3 - koef2 * c2 - koefi2 * max3;
            textBox3.Text = ras3.ToString();
            //ЧЕТВЕРТАЯ ЯЧЕЙКА
            double[] array7 = { a, d2 };
            double min4 = double.MaxValue;
            for (int i = 0; i < array7.Length; i++)
            {
                if (array7[i] < min4)
                    min4 = array7[i];
            }
            double razn4 = a - a2;
            double[] array8 = { razn4, 0 };
            double max4 = double.MinValue;
            for (int i = 0; i < array8.Length; i++)
            {
                if (array8[i] > max4)
                    max4 = array8[i];
            }
            double ras4 = koe2 * min4 - koef2 * d2 - koefi2 * max4;
            textBox4.Text = ras4.ToString();
            //Пятая ЯЧЕЙКА
            double[] array9 = { a, f2 };
            double min5 = double.MaxValue;
            for (int i = 0; i < array9.Length; i++)
            {
                if (array9[i] < min5)
                    min5 = array9[i];
            }
            double razn5 = a - a2;
            double[] array10 = { razn5, 0 };
            double max5 = double.MinValue;
            for (int i = 0; i < array10.Length; i++)
            {
                if (array10[i] > max5)
                    max5 = array10[i];
            }
            double ras5 = koe2 * min5 - koef2 * f2 - koefi2 * max5;
            textBox5.Text = ras5.ToString();
            //ШЕСТАЯ ЯЧЕЙКА
            double[] array11 = { b, a2 };
            double min6 = double.MaxValue;
            for (int i = 0; i < array11.Length; i++)
            {
                if (array11[i] < min6)
                    min6 = array11[i];
            }
            double razn6 = b - a2;
            double[] array12 = { razn6, 0 };
            double max6 = double.MinValue;
            for (int i = 0; i < array12.Length; i++)
            {
                if (array12[i] > max6)
                    max6 = array12[i];
            }
            double ras6 = koe2 * min6 - koef2 * a2 - koefi2 * max6;
            textBox6.Text = ras6.ToString();
            //Седьмая ЯЧЕЙКА
            double[] array13 = { b, b2 };
            double min7 = double.MaxValue;
            for (int i = 0; i < array13.Length; i++)
            {
                if (array13[i] < min7)
                    min7 = array13[i];
            }
            double razn7 = b - b2;
            double[] array14 = { razn7, 0 };
            double max7 = double.MinValue;
            for (int i = 0; i < array14.Length; i++)
            {
                if (array14[i] > max7)
                    max7 = array14[i];
            }
            double ras7 = koe2 * min7 - koef2 * b2 - koefi2 * max7;
            textBox7.Text = ras7.ToString();
            //Восьмая ЯЧЕЙКА
            double[] array15 = { b, c2 };
            double min8 = double.MaxValue;
            for (int i = 0; i < array15.Length; i++)
            {
                if (array15[i] < min8)
                    min8 = array15[i];
            }
            double razn8 = b - b2;
            double[] array16 = { razn8, 0 };
            double max8 = double.MinValue;
            for (int i = 0; i < array16.Length; i++)
            {
                if (array16[i] > max8)
                    max8 = array16[i];
            }
            double ras8 = koe2 * min8 - koef2 * c2 - koefi2 * max8;
            textBox8.Text = ras8.ToString();
            //Девятая ЯЧЕЙКА
            double[] array17 = { b, d2 };
            double min9 = double.MaxValue;
            for (int i = 0; i < array17.Length; i++)
            {
                if (array17[i] < min9)
                    min9 = array17[i];
            }
            double razn9 = b - b2;
            double[] array18 = { razn9, 0 };
            double max9 = double.MinValue;
            for (int i = 0; i < array18.Length; i++)
            {
                if (array18[i] > max9)
                    max9 = array18[i];
            }
            double ras9 = koe2 * min9 - koef2 * d2 - koefi2 * max9;
            textBox9.Text = ras9.ToString();
            //Десятая ЯЧЕЙКА
            double[] array19 = { b, f2 };
            double min10 = double.MaxValue;
            for (int i = 0; i < array19.Length; i++)
            {
                if (array19[i] < min10)
                    min10 = array19[i];
            }
            double razn10 = b - b2;
            double[] array20 = { razn10, 0 };
            double max10 = double.MinValue;
            for (int i = 0; i < array20.Length; i++)
            {
                if (array20[i] > max10)
                    max10 = array20[i];
            }
            double ras10 = koe2 * min9 - koef2 * f2 - koefi2 * max9;
            textBox10.Text = ras10.ToString();
            //11-Я ЯЧЕЙКА
            double[] array21 = { c, a2 };
            double min11 = double.MaxValue;
            for (int i = 0; i < array21.Length; i++)
            {
                if (array21[i] < min11)
                    min11 = array21[i];
            }
            double razn11 = c - a2;
            double[] array22 = { razn11, 0 };
            double max11 = double.MinValue;
            for (int i = 0; i < array22.Length; i++)
            {
                if (array22[i] > max11)
                    max11 = array22[i];
            }
            double ras11 = koe2 * min11 - koef2 * a2 - koefi2 * max11;
            textBox11.Text = ras11.ToString();
            //12-Я ЯЧЕЙКА
            double[] array23 = { c, b2 };
            double min12 = double.MaxValue;
            for (int i = 0; i < array21.Length; i++)
            {
                if (array23[i] < min12)
                    min12 = array23[i];
            }
            double razn12 = c - b2;
            double[] array24 = { razn12, 0 };
            double max12 = double.MinValue;
            for (int i = 0; i < array24.Length; i++)
            {
                if (array24[i] > max12)
                    max12 = array24[i];
            }
            double ras12 = koe2 * min12 - koef2 * b2 - koefi2 * max12;
            textBox12.Text = ras12.ToString();
            //13-Я ЯЧЕЙКА
            double[] array25 = { c, c2 };
            double min13 = double.MaxValue;
            for (int i = 0; i < array25.Length; i++)
            {
                if (array25[i] < min13)
                    min13 = array25[i];
            }
            double razn13 = c - c2;
            double[] array26 = { razn13, 0 };
            double max13 = double.MinValue;
            for (int i = 0; i < array26.Length; i++)
            {
                if (array26[i] > max13)
                    max13 = array26[i];
            }
            double ras13 = koe2 * min13 - koef2 * c2 - koefi2 * max13;
            textBox13.Text = ras13.ToString();
            //14-Я ЯЧЕЙКА
            double[] array27 = { c, d2 };
            double min14 = double.MaxValue;
            for (int i = 0; i < array27.Length; i++)
            {
                if (array27[i] < min14)
                    min14 = array27[i];
            }
            double razn14 = c - c2;
            double[] array28 = { razn14, 0 };
            double max14 = double.MinValue;
            for (int i = 0; i < array28.Length; i++)
            {
                if (array28[i] > max14)
                    max14 = array28[i];
            }
            double ras14 = koe2 * min14 - koef2 * d2 - koefi2 * max14;
            textBox14.Text = ras14.ToString();
            //15-Я ЯЧЕЙКА
            double[] array29 = { c, f2 };
            double min15 = double.MaxValue;
            for (int i = 0; i < array29.Length; i++)
            {
                if (array29[i] < min15)
                    min15 = array29[i];
            }
            double razn15 = c - c2;
            double[] array30 = { razn15, 0 };
            double max15 = double.MinValue;
            for (int i = 0; i < array30.Length; i++)
            {
                if (array30[i] > max15)
                    max15 = array30[i];
            }
            double ras15 = koe2 * min15 - koef2 * f2 - koefi2 * max15;
            textBox15.Text = ras15.ToString();
            //16-я ЯЧЕЙКА
            double[] array31 = { d, a2 };
            double min16 = double.MaxValue;
            for (int i = 0; i < array31.Length; i++)
            {
                if (array31[i] < min16)
                    min16 = array31[i];
            }
            double razn16 = d - a2;
            double[] array32 = { razn16, 0 };
            double max16 = double.MinValue;
            for (int i = 0; i < array32.Length; i++)
            {
                if (array32[i] > max16)
                    max16 = array32[i];
            }
            double ras16 = koe2 * min16 - koef2 * a2 - koefi2 * max16;
            textBox16.Text = ras16.ToString();
            //17-я ЯЧЕЙКА
            double[] array33 = { d, b2 };
            double min17 = double.MaxValue;
            for (int i = 0; i < array33.Length; i++)
            {
                if (array33[i] < min17)
                    min17 = array33[i];
            }
            double razn17 = d - b2;
            double[] array34 = { razn17, 0 };
            double max17 = double.MinValue;
            for (int i = 0; i < array34.Length; i++)
            {
                if (array34[i] > max17)
                    max17 = array34[i];
            }
            double ras17 = koe2 * min17 - koef2 * b2 - koefi2 * max17;
            textBox17.Text = ras17.ToString();
            //18-я ЯЧЕЙКА
            double[] array35 = { d, c2 };
            double min18 = double.MaxValue;
            for (int i = 0; i < array35.Length; i++)
            {
                if (array35[i] < min18)
                    min18 = array35[i];
            }
            double razn18 = d - c2;
            double[] array36 = { razn18, 0 };
            double max18 = double.MinValue;
            for (int i = 0; i < array36.Length; i++)
            {
                if (array36[i] > max18)
                    max18 = array36[i];
            }
            double ras18 = koe2 * min18 - koef2 * c2 - koefi2 * max18;
            textBox18.Text = ras18.ToString();
            //19-я ЯЧЕЙКА
            double[] array37 = { d, d2 };
            double min19 = double.MaxValue;
            for (int i = 0; i < array37.Length; i++)
            {
                if (array37[i] < min19)
                    min19 = array37[i];
            }
            double razn19 = d - d2;
            double[] array38 = { razn19, 0 };
            double max19 = double.MinValue;
            for (int i = 0; i < array38.Length; i++)
            {
                if (array38[i] > max19)
                    max19 = array38[i];
            }
            double ras19 = koe2 * min19 - koef2 * d2 - koefi2 * max19;
            textBox19.Text = ras19.ToString();
            //20-я ЯЧЕЙКА
            double[] array39 = { d, f2 };
            double min20 = double.MaxValue;
            for (int i = 0; i < array39.Length; i++)
            {
                if (array39[i] < min20)
                    min20 = array39[i];
            }
            double razn20 = d - d2;
            double[] array40 = { razn20, 0 };
            double max20 = double.MinValue;
            for (int i = 0; i < array40.Length; i++)
            {
                if (array40[i] > max20)
                    max20 = array40[i];
            }
            double ras20 = koe2 * min20 - koef2 * f2 - koefi2 * max20;
            textBox20.Text = ras20.ToString();
            //21-я ЯЧЕЙКА
            double[] array41 = { f, a2 };
            double min21 = double.MaxValue;
            for (int i = 0; i < array41.Length; i++)
            {
                if (array41[i] < min21)
                    min21 = array41[i];
            }
            double razn21 = f - a2;
            double[] array42 = { razn21, 0 };
            double max21 = double.MinValue;
            for (int i = 0; i < array42.Length; i++)
            {
                if (array42[i] > max21)
                    max21 = array42[i];
            }
            double ras21 = koe2 * min21 - koef2 * a2 - koefi2 * max21;
            textBox21.Text = ras21.ToString();
            //22-я ЯЧЕЙКА
            double[] array43 = { f, b2 };
            double min22 = double.MaxValue;
            for (int i = 0; i < array43.Length; i++)
            {
                if (array43[i] < min22)
                    min22 = array43[i];
            }
            double razn22 = f - b2;
            double[] array44 = { razn22, 0 };
            double max22 = double.MinValue;
            for (int i = 0; i < array44.Length; i++)
            {
                if (array44[i] > max22)
                    max22 = array44[i];
            }
            double ras22 = koe2 * min22 - koef2 * b2 - koefi2 * max22;
            textBox22.Text = ras22.ToString();
            //23-я ЯЧЕЙКА
            double[] array45 = { f, c2 };
            double min23 = double.MaxValue;
            for (int i = 0; i < array45.Length; i++)
            {
                if (array45[i] < min23)
                    min23 = array45[i];
            }
            double razn23 = f - c2;
            double[] array46 = { razn23, 0 };
            double max23 = double.MinValue;
            for (int i = 0; i < array46.Length; i++)
            {
                if (array46[i] > max23)
                    max23 = array46[i];
            }
            double ras23 = koe2 * min23 - koef2 * c2 - koefi2 * max23;
            textBox23.Text = ras23.ToString();
            //24-я ЯЧЕЙКА
            double[] array47 = { f, d2 };
            double min24 = double.MaxValue;
            for (int i = 0; i < array47.Length; i++)
            {
                if (array47[i] < min24)
                    min24 = array47[i];
            }
            double razn24 = f - d2;
            double[] array48 = { razn24, 0 };
            double max24 = double.MinValue;
            for (int i = 0; i < array48.Length; i++)
            {
                if (array48[i] > max24)
                    max24 = array48[i];
            }
            double ras24 = koe2 * min24 - koef2 * d2 - koefi2 * max24;
            textBox24.Text = ras24.ToString();
            //25-я ЯЧЕЙКА
            double[] array49 = { f, f2 };
            double min25 = double.MaxValue;
            for (int i = 0; i < array49.Length; i++)
            {
                if (array49[i] < min25)
                    min25 = array49[i];
            }
            double razn25 = f - f2;
            double[] array50 = { razn25, 0 };
            double max25 = double.MinValue;
            for (int i = 0; i < array50.Length; i++)
            {
                if (array50[i] > max25)
                    max25 = array50[i];
            }
            double ras25 = koe2 * min25 - koef2 * f2 - koefi2 * max25;
            textBox25.Text = ras25.ToString();


            //1-ый столбец таблицы
            double[] array149 = { ras, ras6, ras11, ras16, ras21 };
            double min125 = double.MaxValue;
            for (int i = 0; i < array149.Length; i++)
            {
                if (array149[i] < min125)
                    min125 = array149[i];
            }
            double[] array249 = { ras2, ras7, ras12, ras17, ras22 };
            double min225 = double.MaxValue;
            for (int i = 0; i < array249.Length; i++)
            {
                if (array249[i] < min225)
                    min225 = array249[i];
            }
            double[] array349 = { ras3, ras8, ras13, ras18, ras23 };
            double min325 = double.MaxValue;
            for (int i = 0; i < array349.Length; i++)
            {
                if (array349[i] < min325)
                    min325 = array349[i];
            }
            double[] array449 = { ras4, ras9, ras14, ras19, ras24 };
            double min425 = double.MaxValue;
            for (int i = 0; i < array449.Length; i++)
            {
                if (array449[i] < min425)
                    min425 = array449[i];
            }
            double[] array549 = { ras5, ras10, ras15, ras20, ras25 };
            double min525 = double.MaxValue;
            for (int i = 0; i < array549.Length; i++)
            {
                if (array549[i] < min525)
                    min525 = array549[i];
            }


            //Конечный максимум
            double[] array75 = { min125, min225, min325, min425, min525 };
            double max332 = double.MinValue;
            for (int i = 0; i < array75.Length; i++)
            {
                if (array75[i] > max332)
                    max332 = array75[i];
            }
            label7.Text = max332.ToString();

            textBox29.Text = min125.ToString(); 
            textBox45.Text = min225.ToString();
            textBox46.Text = min325.ToString();
            textBox47.Text = min425.ToString();
            textBox48.Text = min525.ToString();

            double max333 = max332;
            Form1.max333 = max333;

            Form1.max322 = min125;
            Form1.max332t = min225;
            Form1.max342 = min325;
            Form1.max352 = min425;
            Form1.max362 = min525;
        }
    }
}
