using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clock.Controls.Clock
{
    public partial class ctlTrueAnClock : UserControl
    {
        public ctlTrueAnClock()
        {
            InitializeComponent();
            tmrTime.Start();
        }

        private void pcbTime_Paint(object sender, PaintEventArgs e)
        {
            //Задаем угол поворота стрелок с ориентиром на время:
            //6 в данном случае - градус на который надо поворачивать.
            int angel1 = DateTime.Now.Second * 6;

            //Объявляем объект myGraphicsPath класса GraphicsPath:
            GraphicsPath myGraphicsPath1 = new GraphicsPath();

            //Строим линии через выполнение процедуры AddLine
            myGraphicsPath1.AddLine(100, 5, 100, 100);

            //Создаем объект класса Matrix
            //В виде матрицы преобразований:
            Matrix myMatrix1 = new Matrix(1, 0, 0, 1, 1, 1);

            //Создаем объект PointF в структуре PointF
            //с координатами (100,100)
            //Вокруг этой точки будем вращать наши линии.
            PointF myPointF = new PointF(100, 100);

            //Поворачиваем линии вокруг точки через метод RotateAt:
            myMatrix1.RotateAt(angel1, myPointF);

            //Применяем метод Transform класса GraphicsPath
            //для трансформирования матрицы myMatrix:
            myGraphicsPath1.Transform(myMatrix1);

            //Рисуем трансформированные линии 
            //(+ Задаем визулизацию со сглаживанием):
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.DrawPath(new Pen(Color.Red, 3), myGraphicsPath1);

            //Увеличиваем угол поворота на 6 градусов:
            angel1 += 6;

            // ========= Отрисовываем минутную и часовую стрелки
            // ========= таким же способом
            int angel2 = DateTime.Now.Minute * 6;
            GraphicsPath myGraphicsPath2 = new GraphicsPath();
            myGraphicsPath2.AddLine(100, 10, 100, 100);
            Matrix myMatrix2 = new Matrix(1, 0, 0, 1, 1, 1);
            myMatrix2.RotateAt(angel2, myPointF);
            myGraphicsPath2.Transform(myMatrix2);
            e.Graphics.DrawPath(new Pen(Color.DarkRed, 3), myGraphicsPath2);
            angel2 += 6;

            int angel3 = DateTime.Now.Hour * 6;
            GraphicsPath myGraphicsPath3 = new GraphicsPath();
            myGraphicsPath3.AddLine(100, 20, 100, 100);
            Matrix myMatrix3 = new Matrix(1, 0, 0, 1, 1, 1);
            myMatrix3.RotateAt(angel3, myPointF);
            myGraphicsPath3.Transform(myMatrix3);
            e.Graphics.DrawPath(new Pen(Color.DarkBlue, 3), myGraphicsPath3);
            angel3 += 6;

            //Рисуем окружность (будущий циферблат)
            Pen ellipsePen = new Pen(Color.DarkBlue,3);
            ellipsePen.DashStyle = DashStyle.DashDotDot;
            e.Graphics.DrawEllipse(ellipsePen, 0, 0, 200, 200);

            //Рисуем еще 2 линии (оси симметрии окружности):
            e.Graphics.DrawLine(new Pen(Color.DarkGray, 1), 0, 100, 200, 100);
            e.Graphics.DrawLine(new Pen(Color.DarkGray, 1), 100, 0, 100, 200);

            
        }


        private void tmrTime_Tick(object sender, EventArgs e)
        {
            pcbTime.Refresh();
        }
    }
}
