using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace Labka_1
{
    public partial class Form1 : Form
    {
        internal static double max26;
        internal static double min32;
        internal static double max332;
        internal static double max333;

        internal static double sums1pod1;
        internal static double sums1pod2;
        internal static double sums1pod3;
        internal static double sums1pod4;
        internal static double sums1pod5;

        internal static double max36;
        internal static double max35;
        internal static double max34;
        internal static double max33;
        internal static double max32;

        internal static double max321;
        internal static double max331;
        internal static double max341;
        internal static double max351;
        internal static double max361;

        internal static double max322;
        internal static double max332t;
        internal static double max342;
        internal static double max352;
        internal static double max362;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        //засейвить статистику через дата грю?
        public void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = max26.ToString();
            textBox2.Text = min32.ToString();
            textBox3.Text = max332.ToString();
            textBox4.Text = max333.ToString();

            textBox5.Text = "6";
            textBox6.Text = "6";
            textBox7.Text = "7";
            textBox8.Text = "5";

    //График
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Критерий Лапласа",
                    Values = new ChartValues<double> { sums1pod1, sums1pod2, sums1pod3, sums1pod4, sums1pod5 },
                    PointGeometry = DefaultGeometries.Diamond,
                    PointGeometrySize = 10,
                   // Fill = System.Windows.Media.Brushes.Blue
        },
                new LineSeries
                {
                    Title = "Критерий Сэвиджа",
                    Values = new ChartValues<double> { max36, max35, max34, max33, max32 },
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 10,
                     //Fill = System.Windows.Media.Brushes.White
                },
                new LineSeries
                {
                    Title = "Критерий Гурвица",
                    Values = new ChartValues<double> { max321, max331, max341, max351, max361},
                    PointGeometry = DefaultGeometries.Square,
                    // Fill = System.Windows.Media.Brushes.None,
                    PointGeometrySize = 10
                },
                new LineSeries
                {
                    Title = "Критерий Max(Min)",
                    Values = new ChartValues<double> {max322, max332t, max342, max352, max362},
                    PointGeometry = DefaultGeometries.Triangle,
                    PointGeometrySize = 10
                    // Fill = System.Windows.Media.Brushes.White

                }
            };

            cartesianChart1.LegendLocation = LegendLocation.Right;

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

    }
}
