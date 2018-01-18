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
    public partial class tabl2 : Form
    {

        public tabl2()
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

            //1-ы столбец таблицы
            double[] array52 = { ras, ras2, ras3, ras4, ras5 };
            double max27 = double.MinValue;
            for (int i = 0; i < array52.Length; i++)
            {
                if (array52[i] > max27)
                    max27 = array52[i];
            }
            double maxz1 = max27 - ras;
            double maxz2 = max27 - ras2;
            double maxz3 = max27 - ras3;
            double maxz4 = max27 - ras4;
            double maxz5 = max27 - ras5;
            //2-ой столбец таблицы
            double[] array53 = { ras6, ras7, ras8, ras9, ras10 };
            double max28 = double.MinValue;
            for (int i = 0; i < array53.Length; i++)
            {
                if (array53[i] > max28)
                    max28 = array53[i];
            }
            double maxz6 = max28 - ras6;
            double maxz7 = max28 - ras7;
            double maxz8 = max28 - ras8;
            double maxz9 = max28 - ras9;
            double maxz10 = max28 - ras10;
            //3-ий столбец таблицы
            double[] array54 = { ras11, ras12, ras13, ras14, ras15 };
            double max29 = double.MinValue;
            for (int i = 0; i < array54.Length; i++)
            {
                if (array54[i] > max29)
                    max29 = array54[i];
            }
            double maxz11 = max29 - ras11;
            double maxz12 = max29 - ras12;
            double maxz13 = max29 - ras13;
            double maxz14 = max29 - ras14;
            double maxz15 = max29 - ras15;
            //4-ый столбец таблицы
            double[] array55 = { ras16, ras17, ras18, ras19, ras20 };
            double max30 = double.MinValue;
            for (int i = 0; i < array55.Length; i++)
            {
                if (array55[i] > max30)
                    max30 = array55[i];
            }
            double maxz16 = max30 - ras16;
            double maxz17 = max30 - ras17;
            double maxz18 = max30 - ras18;
            double maxz19 = max30 - ras19;
            double maxz20 = max30 - ras20;
            //5-ый столбец таблицы
            double[] array56 = { ras21, ras22, ras23, ras24, ras25 };
            double max31 = double.MinValue;
            for (int i = 0; i < array56.Length; i++)
            {
                if (array56[i] > max31)
                    max31 = array56[i];
            }
            double maxz21 = max31 - ras21;
            double maxz22 = max31 - ras22;
            double maxz23 = max31 - ras23;
            double maxz24 = max31 - ras24;
            double maxz25 = max31 - ras25;
            //6-ой столбец таблицы
            double[] array57 = { maxz1, maxz2, maxz3, maxz4, maxz5 };
            double max32 = double.MinValue;
            for (int i = 0; i < array57.Length; i++)
            {
                if (array57[i] > max32)
                    max32 = array57[i];
            }
            double[] array58 = { maxz6, maxz7, maxz8, maxz9, maxz10 };
            double max33 = double.MinValue;
            for (int i = 0; i < array58.Length; i++)
            {
                if (array58[i] > max33)
                    max33 = array58[i];
            }
            double[] array59 = { maxz11, maxz12, maxz13, maxz14, maxz15 };
            double max34 = double.MinValue;
            for (int i = 0; i < array59.Length; i++)
            {
                if (array59[i] > max34)
                    max34 = array59[i];
            }
            double[] array60 = { maxz16, maxz17, maxz18, maxz19, maxz20 };
            double max35 = double.MinValue;
            for (int i = 0; i < array60.Length; i++)
            {
                if (array60[i] > max35)
                    max35 = array60[i];
            }
            double[] array61 = { maxz21, maxz22, maxz23, maxz24, maxz25 };
            double max36 = double.MinValue;
            for (int i = 0; i < array61.Length; i++)
            {
                if (array61[i] > max36)
                    max36 = array61[i];
            }


            //Конечный минимум
            double[] array75 = { max32, max33, max34, max35, max36 };
            double min32 = double.MaxValue;
            for (int i = 0; i < array75.Length; i++)
            {
                if (array75[i] < min32)
                    min32 = array75[i];
            }
            label7.Text = min32.ToString();

            dataGridView1.Rows.Add(maxz1, maxz6, maxz11, maxz16, maxz21, max36);
            dataGridView1.Rows.Add(maxz2, maxz7, maxz12, maxz17, maxz22, max35);
            dataGridView1.Rows.Add(maxz3, maxz8, maxz13, maxz18, maxz23, max34);
            dataGridView1.Rows.Add(maxz4, maxz9, maxz14, maxz19, maxz24, max33);
            dataGridView1.Rows.Add(maxz5, maxz10, maxz15, maxz20, maxz25, max32);


            Form1.min32 = min32;

            Form1.max36 = max36;
            Form1.max35 = max35;
            Form1.max34 = max34;
            Form1.max33 = max33;
            Form1.max32 = max32;
            //Form1.sred2two = sred2;
            //Form1.sred3two = sred3;
        }
    }
}
