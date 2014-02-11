namespace Clock.Controls.Clock
{
    partial class ctlTrueAnClock
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pcbTime = new System.Windows.Forms.PictureBox();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTime)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbTime
            // 
            this.pcbTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbTime.Location = new System.Drawing.Point(0, 0);
            this.pcbTime.Name = "pcbTime";
            this.pcbTime.Size = new System.Drawing.Size(200, 200);
            this.pcbTime.TabIndex = 0;
            this.pcbTime.TabStop = false;
            this.pcbTime.Paint += new System.Windows.Forms.PaintEventHandler(this.pcbTime_Paint);
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(92, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "12";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(95, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(180, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(5, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "9";
            // 
            // ctlTrueAnClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbTime);
            this.Name = "ctlTrueAnClock";
            this.Size = new System.Drawing.Size(200, 200);
            ((System.ComponentModel.ISupportInitialize)(this.pcbTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbTime;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
