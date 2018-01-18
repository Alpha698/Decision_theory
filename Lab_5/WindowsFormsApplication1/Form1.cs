using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gr = pictureBox1.CreateGraphics();
            colorDialog1.Color = Color.Black;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Выбираем перо "p" черного цвета Black толщиной в 1 пиксель:
            Pen myWind = new Pen(Color.Black, 2);

            //Объявляем объект "g" класса Graphics и предоставляем ему возможность рисования на pictureBox1:
            Graphics g = pictureBox1.CreateGraphics();

            // Создаем объекты для закрашивания фигур
            SolidBrush myCorp = new SolidBrush(Color.Black);
            SolidBrush myTrum = new SolidBrush(Color.Green);
            SolidBrush myTrub = new SolidBrush(Color.Gray);
            SolidBrush mySe = new SolidBrush(Color.Blue);

            // Закрашиваем фигуры
            g.FillRectangle(myTrub, 300, 125, 75, 75);
            g.FillRectangle(myTrub, 480, 125, 75, 75);
            g.FillPolygon(myCorp, new Point[] {new Point(100,300),new Point(700,300),
            new Point(700,300),new Point(600,400),new Point(600,400),new Point(200,400),
            new Point(200,400),new Point(100,300) });
            g.FillRectangle(myTrum, 250, 200, 350, 100);
            int x = 50, Radius = 50;

            // Море
            while (x <= pictureBox1.Width - Radius)
            {
                g.FillPie(mySe, 0 + x, 375, 50, 50, 0, -180);
                x += 50;
            }

            // Окошки
            for (int y = 300; y <= 550; y += 50) g.DrawEllipse(myWind, y, 240, 20, 20);

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        int Instrument = 0;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            toolStripButton2.Checked = false;
            toolStripButton3.Checked = false;
            toolStripButton5.Checked = false;
            (sender as ToolStripButton).Checked = true;
            Instrument = Convert.ToInt16((sender as ToolStripButton).Tag);
        }

        int StartPosX, StartPosY;
        bool mouseChecked;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            StartPosX = e.X;
            StartPosY = e.Y;
            mouseChecked = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseChecked = false;
            //  Graphics gr = pictureBox1.CreateGraphics();
            //   Pen p = new Pen(Color.Blue, 5);// цвет линии и ширина
            if (Instrument == 2)
            {
                gr.DrawLine(p, e.X, e.Y, StartPosX, StartPosY);// рисуем 
            }
            else if (Instrument == 3)
            {
                if (StartPosX > e.X && StartPosY > e.Y)
                {

                    gr.DrawEllipse(p, e.X, e.Y, StartPosX - e.X, StartPosY - e.Y);

                }
                else if (StartPosY > e.Y && StartPosX < e.X)
                {

                    gr.DrawEllipse(p, StartPosX, e.Y, Math.Abs(e.X - StartPosX), Math.Abs(e.Y - StartPosY));
                }
                else if (StartPosX > e.X && StartPosY < e.Y)
                {
                    gr.DrawEllipse(p, e.X, StartPosY, Math.Abs(e.X - StartPosX), Math.Abs(e.Y - StartPosY));
                }
                else gr.DrawEllipse(p, StartPosX, StartPosY, e.X - StartPosX, e.Y - StartPosY);
            }
            ///   gr.Dispose();
        }

        Graphics gr = null;
        Pen p = new Pen(Color.Black, 1);// цвет линии и ширина
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Instrument == 1 && mouseChecked)
            {
                gr.DrawLine(p, e.X, e.Y, StartPosX, StartPosY);// рисуем 

                // gr.Dispose();
                StartPosX = e.X;
                StartPosY = e.Y;
            }
            else if (Instrument == 5 && mouseChecked)
            {
                gr.FillRectangle(new SolidBrush(Color.White), e.X - 5, e.Y - 5, 10, 10);
            }
        }

 
        int PenWidth = 1;
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(16, 16);
            Graphics grt = Graphics.FromImage(bmp);
            grt.DrawLine(new Pen(Color.Black, Convert.ToInt16((sender as ToolStripMenuItem).Text)), 7, 0, 7, 16);
            p = new Pen(colorDialog1.Color, Convert.ToInt16((sender as ToolStripMenuItem).Text));
            PenWidth = Convert.ToInt16((sender as ToolStripMenuItem).Text);
            //Graphics gr = CreateGraphics();
            //Pen p = new Pen(Color.Black, Convert.ToInt16((sender as ToolStripMenuItem).Text));// цвет линии и ширина

        }

        private void toolStripButton6_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                p = new Pen(colorDialog1.Color, PenWidth);
                Bitmap bmp = new Bitmap(16, 16);
                Graphics grt = Graphics.FromImage(bmp);
                grt.FillRectangle(new SolidBrush(colorDialog1.Color),  0, 0, 16, 16);
   
            }
               // textBox1.ForeColor = MyDialog.Color;
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            gr = pictureBox1.CreateGraphics();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
          //  Pen myWind = new Pen(Color.Black, 2);
          //  Graphics g = pictureBox1.CreateGraphics();
        }
    }
}
