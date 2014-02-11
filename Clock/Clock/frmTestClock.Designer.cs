namespace Clock
{
    partial class frmTestClock
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctlClock1 = new Clock.Controls.Clock.ctlTrueClock();
            this.ctlTrueAnClock1 = new Clock.Controls.Clock.ctlTrueAnClock();
            this.SuspendLayout();
            // 
            // ctlClock1
            // 
            this.ctlClock1.Location = new System.Drawing.Point(100, 0);
            this.ctlClock1.Name = "ctlClock1";
            this.ctlClock1.Size = new System.Drawing.Size(50, 20);
            this.ctlClock1.TabIndex = 1;
            // 
            // ctlTrueAnClock1
            // 
            this.ctlTrueAnClock1.Location = new System.Drawing.Point(25, 26);
            this.ctlTrueAnClock1.Name = "ctlTrueAnClock1";
            this.ctlTrueAnClock1.Size = new System.Drawing.Size(200, 200);
            this.ctlTrueAnClock1.TabIndex = 2;
            // 
            // frmTestClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 273);
            this.Controls.Add(this.ctlTrueAnClock1);
            this.Controls.Add(this.ctlClock1);
            this.Name = "frmTestClock";
            this.Text = "Clock";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Clock.ctlTrueClock ctlClock1;
        private Controls.Clock.ctlTrueAnClock ctlTrueAnClock1;
    }
}

