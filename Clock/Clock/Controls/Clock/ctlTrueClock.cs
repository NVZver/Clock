using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clock.Controls.Clock
{
    public partial class ctlTrueClock : UserControl
    {
        public ctlTrueClock()
        {
            InitializeComponent();
            
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
