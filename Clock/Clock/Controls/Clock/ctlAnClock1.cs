using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Clock.Controls.Clock
{
    public partial class ctlAnClock1 : UserControl
    {
        public ctlAnClock1()
        {
            InitializeComponent();
            timer1.Start();
        }
        //Объявляем глобальную переменную для угла "angle"

        //и приравниваем ее нулю:

      

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Перерисовываем клиентскую область элемента управления

            //pictureBox1 через каждый Interval времени:
            
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int angle = DateTime.Now.Second*6;
            
            //Объявляем объект myGraphicsPath класса GraphicsPath:

            GraphicsPath myGraphicsPath = new GraphicsPath();

            //На объекте myGraphicsPath выполняем процедуру

            //AddLine для построения линии по двум точкам

            //с координатами (29, 29) и (100, 100):

            myGraphicsPath.AddLine(100, 0, 100, 100);

            //В классе Matrix создаем объект myMatrix

            //в виде матицы преобразований:

            Matrix myMatrix = new Matrix(1, 0, 0, 1, 1, 1);

            //В структуре PointF создаем объект myPointF

            //с координатами точки (100, 100);,

            //вокруг которой будет вращаться линия:

            PointF myPointF = new PointF(100, 100);

            //Поворачиваем линию вокруг точки (100, 100)

            //на один шаг при помощи метода RotateAt

            //класса Matrix:

            myMatrix.RotateAt(angle, myPointF);

            //Применяем метод Transform класса GraphicsPath

            //для трансформирования матрицы myMatrix:

            myGraphicsPath.Transform(myMatrix);

            //Рисуем на экране трансформированную линию

            //черным пером толщиной 3 (Pen(Color.Black, 3)):

            e.Graphics.DrawPath(new Pen(Color.Black, 3),myGraphicsPath);

            //Увеличиваем текущий угол поворота линии

            //на один шаг, равный 6 градусам:

            angle = angle + 6;

            //Обнуляем угол поворота линии,

            //когда линия сделает полный оборот в 360 градусов:

            //if (angle == 360) angle = 0;

            //Для наглядности внутри квадрата 200x200

            //рисуем окружность (типа циферблата часов)

            //синим пером толщиной 2 (Pen(Color.Blue, 2),

            //внутри которой будет вращаться линия:

            e.Graphics.DrawEllipse(new Pen(Color.Blue, 2),

            0, 0, 200, 200);

            //Рисуем две оси симметрии окружности,

            //горизонтальную и вертикальную:

            e.Graphics.DrawLine(new Pen(Color.Red, 1),

            0, 100, 200, 100);

            e.Graphics.DrawLine(new Pen(Color.Red, 1),

            100, 0, 100, 200);

        }
        }
    }

