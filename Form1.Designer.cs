namespace wolf_island
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timeoutLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wolfsCounter = new System.Windows.Forms.NumericUpDown();
            this.rabbitsCounter = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wolfessCounter = new System.Windows.Forms.NumericUpDown();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wolfsCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabbitsCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wolfessCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.stopBtn);
            this.groupBox1.Controls.Add(this.startBtn);
            this.groupBox1.Location = new System.Drawing.Point(611, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 597);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.timeoutLabel);
            this.groupBox3.Controls.Add(this.trackBar1);
            this.groupBox3.Location = new System.Drawing.Point(11, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 107);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Швидкість оновлення";
            // 
            // timeoutLabel
            // 
            this.timeoutLabel.AutoSize = true;
            this.timeoutLabel.Location = new System.Drawing.Point(121, 81);
            this.timeoutLabel.Name = "timeoutLabel";
            this.timeoutLabel.Size = new System.Drawing.Size(42, 13);
            this.timeoutLabel.TabIndex = 6;
            this.timeoutLabel.Text = "500 мс";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 2;
            this.trackBar1.Location = new System.Drawing.Point(6, 40);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(266, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.wolfsCounter);
            this.groupBox2.Controls.Add(this.rabbitsCounter);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.wolfessCounter);
            this.groupBox2.Location = new System.Drawing.Point(11, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 109);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Кількість тварин кожного виду:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вовчиць:";
            // 
            // wolfsCounter
            // 
            this.wolfsCounter.Location = new System.Drawing.Point(137, 29);
            this.wolfsCounter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.wolfsCounter.Name = "wolfsCounter";
            this.wolfsCounter.Size = new System.Drawing.Size(55, 20);
            this.wolfsCounter.TabIndex = 3;
            // 
            // rabbitsCounter
            // 
            this.rabbitsCounter.Location = new System.Drawing.Point(137, 69);
            this.rabbitsCounter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rabbitsCounter.Name = "rabbitsCounter";
            this.rabbitsCounter.Size = new System.Drawing.Size(55, 20);
            this.rabbitsCounter.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кроликів:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вовків:";
            // 
            // wolfessCounter
            // 
            this.wolfessCounter.Location = new System.Drawing.Point(137, 50);
            this.wolfessCounter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.wolfessCounter.Name = "wolfessCounter";
            this.wolfessCounter.Size = new System.Drawing.Size(55, 20);
            this.wolfessCounter.TabIndex = 4;
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(150, 540);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(136, 44);
            this.stopBtn.TabIndex = 6;
            this.stopBtn.Text = "Стоп";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(13, 540);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(131, 44);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Старт";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 610);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Wolf Island";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wolfsCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabbitsCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wolfessCounter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label timeoutLabel;
        public System.Windows.Forms.NumericUpDown rabbitsCounter;
        public System.Windows.Forms.NumericUpDown wolfessCounter;
        public System.Windows.Forms.NumericUpDown wolfsCounter;
    }
}

