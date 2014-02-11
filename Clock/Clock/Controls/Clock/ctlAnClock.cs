using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clock
{
    public partial class ctlAnClock : UserControl
    {
        private const float R = 75f;
        private float angle1;
        private float angle2;
        private float angle3;

        Pen pen1 = new Pen(Color.Red,(float)1.0);
            
        Pen pen2 = new Pen(Color.DarkBlue, (float)1.0);
        Pen pen3 = new Pen(Color.Black, (float)1.0);
        Pen pen4 = new Pen(Color.DarkGray, (float)3.0);

        public ctlAnClock()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            var graf = e.Graphics;
            graf.SmoothingMode = SmoothingMode.HighQuality;

            //==секундная стрелка
            var x1 = R - R * (float)Math.Cos(angle1);
            var y1 = R - R * (float)Math.Sin(angle1);
            pen1.EndCap = LineCap.DiamondAnchor;
            pen1.StartCap = LineCap.Round;
            graf.DrawLine(pen1, R, R, x1, y1);

            //==минутная стрелка
            var x2 = R - R * (float)Math.Cos(angle2);
            var y2 = R - R * (float)Math.Sin(angle2);
            pen2.EndCap = LineCap.DiamondAnchor;
            pen2.StartCap = LineCap.Round;
            graf.DrawLine(pen2, R, R, x2, y2);

            //==часовая стрелка
            var x3 = R - R * (float)Math.Cos(angle3);
            var y3 = R - R * (float)Math.Sin(angle3);
            pen3.EndCap = LineCap.DiamondAnchor;
            pen3.StartCap = LineCap.Round;
            graf.DrawLine(pen3, R, R, x3, y3);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            angle1 = (float)(DateTime.Now.Second * Math.PI / 30);
            angle2 = (float)(DateTime.Now.Minute * Math.PI / 30);
            angle3 = (float)(DateTime.Now.Hour * Math.PI / 30);
            pictureBox1.Invalidate();
            
        }
    }
}
