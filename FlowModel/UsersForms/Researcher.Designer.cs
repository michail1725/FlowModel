
namespace FlowModel
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.Lenght = new System.Windows.Forms.TextBox();
         this.Depth = new System.Windows.Forms.TextBox();
         this.Width = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.CapSpeed = new System.Windows.Forms.TextBox();
         this.label7 = new System.Windows.Forms.Label();
         this.CapTemperature = new System.Windows.Forms.TextBox();
         this.label6 = new System.Windows.Forms.Label();
         this.groupBox3 = new System.Windows.Forms.GroupBox();
         this.label8 = new System.Windows.Forms.Label();
         this.Step = new System.Windows.Forms.TextBox();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.label2 = new System.Windows.Forms.Label();
         this.StartCalc = new System.Windows.Forms.Button();
         this.Properties = new System.Windows.Forms.Label();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.label9 = new System.Windows.Forms.Label();
         this.MaterialName = new System.Windows.Forms.ComboBox();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.groupBox3.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.Lenght);
         this.groupBox1.Controls.Add(this.Depth);
         this.groupBox1.Controls.Add(this.Width);
         this.groupBox1.Controls.Add(this.label5);
         this.groupBox1.Controls.Add(this.label4);
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Location = new System.Drawing.Point(7, 330);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(317, 69);
         this.groupBox1.TabIndex = 0;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Геометрические параметры канала";
         // 
         // Lenght
         // 
         this.Lenght.Location = new System.Drawing.Point(141, 40);
         this.Lenght.Name = "Lenght";
         this.Lenght.Size = new System.Drawing.Size(62, 20);
         this.Lenght.TabIndex = 14;
         this.Lenght.Text = "9,5";
         this.Lenght.TextChanged += new System.EventHandler(this.lenghtChanged);
         // 
         // Depth
         // 
         this.Depth.Location = new System.Drawing.Point(73, 40);
         this.Depth.Name = "Depth";
         this.Depth.Size = new System.Drawing.Size(62, 20);
         this.Depth.TabIndex = 13;
         this.Depth.Text = "0,01";
         this.Depth.TextChanged += new System.EventHandler(this.depthChanged);
         // 
         // Width
         // 
         this.Width.Location = new System.Drawing.Point(5, 40);
         this.Width.Name = "Width";
         this.Width.Size = new System.Drawing.Size(62, 20);
         this.Width.TabIndex = 12;
         this.Width.Text = "0,25";
         this.Width.TextChanged += new System.EventHandler(this.widthChanged);
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(138, 24);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(60, 13);
         this.label5.TabIndex = 11;
         this.label5.Text = "Длина (м):";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(70, 24);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(68, 13);
         this.label4.TabIndex = 10;
         this.label4.Text = "Глубина (м):";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(2, 26);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(66, 13);
         this.label3.TabIndex = 9;
         this.label3.Text = "Ширина (м):";
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.CapSpeed);
         this.groupBox2.Controls.Add(this.label7);
         this.groupBox2.Controls.Add(this.CapTemperature);
         this.groupBox2.Controls.Add(this.label6);
         this.groupBox2.Location = new System.Drawing.Point(6, 405);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(318, 74);
         this.groupBox2.TabIndex = 1;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Варьируемые параметры";
         // 
         // CapSpeed
         // 
         this.CapSpeed.Location = new System.Drawing.Point(157, 37);
         this.CapSpeed.Name = "CapSpeed";
         this.CapSpeed.Size = new System.Drawing.Size(77, 20);
         this.CapSpeed.TabIndex = 5;
         this.CapSpeed.Text = "1,5";
         this.CapSpeed.TextChanged += new System.EventHandler(this.capSpeedChanged);
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(153, 21);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(129, 13);
         this.label7.TabIndex = 4;
         this.label7.Text = "Скорость крышки (м/с):";
         // 
         // CapTemperature
         // 
         this.CapTemperature.Location = new System.Drawing.Point(10, 37);
         this.CapTemperature.Name = "CapTemperature";
         this.CapTemperature.Size = new System.Drawing.Size(78, 20);
         this.CapTemperature.TabIndex = 3;
         this.CapTemperature.Text = "150";
         this.CapTemperature.TextChanged += new System.EventHandler(this.capTempChanged);
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(7, 21);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(140, 13);
         this.label6.TabIndex = 2;
         this.label6.Text = "Температура крышки (°C):";
         // 
         // groupBox3
         // 
         this.groupBox3.Controls.Add(this.label8);
         this.groupBox3.Controls.Add(this.Step);
         this.groupBox3.Location = new System.Drawing.Point(6, 485);
         this.groupBox3.Name = "groupBox3";
         this.groupBox3.Size = new System.Drawing.Size(318, 72);
         this.groupBox3.TabIndex = 5;
         this.groupBox3.TabStop = false;
         this.groupBox3.Text = "Параметры методов решения";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(7, 20);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(134, 13);
         this.label8.TabIndex = 11;
         this.label8.Text = "Шаг по длине канала (м):";
         // 
         // Step
         // 
         this.Step.Location = new System.Drawing.Point(10, 36);
         this.Step.Name = "Step";
         this.Step.Size = new System.Drawing.Size(78, 20);
         this.Step.TabIndex = 10;
         this.Step.Text = "0,1";
         this.Step.TextChanged += new System.EventHandler(this.stepChanged);
         // 
         // pictureBox1
         // 
         this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
         this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.pictureBox1.InitialImage = null;
         this.pictureBox1.Location = new System.Drawing.Point(330, 30);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(675, 575);
         this.pictureBox1.TabIndex = 6;
         this.pictureBox1.TabStop = false;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(327, 9);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(131, 13);
         this.label2.TabIndex = 7;
         this.label2.Text = "Объект моделирования:";
         // 
         // StartCalc
         // 
         this.StartCalc.Location = new System.Drawing.Point(840, 611);
         this.StartCalc.Name = "StartCalc";
         this.StartCalc.Size = new System.Drawing.Size(165, 34);
         this.StartCalc.TabIndex = 8;
         this.StartCalc.Text = "Начать моделирование";
         this.StartCalc.UseVisualStyleBackColor = true;
         this.StartCalc.Click += new System.EventHandler(this.StartCalc_Click);
         // 
         // Properties
         // 
         this.Properties.AutoSize = true;
         this.Properties.Location = new System.Drawing.Point(7, 52);
         this.Properties.Name = "Properties";
         this.Properties.Size = new System.Drawing.Size(191, 13);
         this.Properties.TabIndex = 12;
         this.Properties.Text = "Полный список свойств материала:";
         // 
         // dataGridView1
         // 
         this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
         this.dataGridView1.Location = new System.Drawing.Point(6, 68);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.RowHeadersVisible = false;
         this.dataGridView1.Size = new System.Drawing.Size(318, 256);
         this.dataGridView1.TabIndex = 11;
         // 
         // Column1
         // 
         this.Column1.Frozen = true;
         this.Column1.HeaderText = "Название параметра";
         this.Column1.Name = "Column1";
         this.Column1.ReadOnly = true;
         this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.Column1.Width = 180;
         // 
         // Column2
         // 
         this.Column2.Frozen = true;
         this.Column2.HeaderText = "Единица измерения";
         this.Column2.Name = "Column2";
         this.Column2.ReadOnly = true;
         this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.Column2.Width = 70;
         // 
         // Column3
         // 
         this.Column3.Frozen = true;
         this.Column3.HeaderText = "Значение";
         this.Column3.Name = "Column3";
         this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.Column3.Width = 60;
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(7, 9);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(87, 13);
         this.label9.TabIndex = 10;
         this.label9.Text = "Тип материала:";
         // 
         // MaterialName
         // 
         this.MaterialName.FormattingEnabled = true;
         this.MaterialName.Items.AddRange(new object[] {
            "Поливинилхлорид"});
         this.MaterialName.Location = new System.Drawing.Point(6, 28);
         this.MaterialName.Name = "MaterialName";
         this.MaterialName.Size = new System.Drawing.Size(146, 21);
         this.MaterialName.TabIndex = 9;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.LightBlue;
         this.ClientSize = new System.Drawing.Size(1013, 649);
         this.Controls.Add(this.Properties);
         this.Controls.Add(this.dataGridView1);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.MaterialName);
         this.Controls.Add(this.StartCalc);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.groupBox3);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.MaximumSize = new System.Drawing.Size(1029, 688);
         this.MinimumSize = new System.Drawing.Size(1029, 688);
         this.Name = "Form1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "FlowModel";
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         this.groupBox3.ResumeLayout(false);
         this.groupBox3.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Lenght;
        private System.Windows.Forms.TextBox Depth;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox CapSpeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CapTemperature;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartCalc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Step;
        private System.Windows.Forms.Label Properties;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox MaterialName;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
   }
}

