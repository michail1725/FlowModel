namespace FlowModel.AdditionalForms
{
   partial class AdminForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.dataTable = new System.Windows.Forms.DataGridView();
         this.label1 = new System.Windows.Forms.Label();
         this.SQlrequest = new System.Windows.Forms.TextBox();
         this.makeRequest = new System.Windows.Forms.Button();
         this.currentTable = new System.Windows.Forms.ComboBox();
         this.label2 = new System.Windows.Forms.Label();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.addMaterial = new System.Windows.Forms.Button();
         this.materialName = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.button1 = new System.Windows.Forms.Button();
         this.propertyUnit = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.propertyName = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.addValue = new System.Windows.Forms.Button();
         this.groupBox3 = new System.Windows.Forms.GroupBox();
         this.propertyValue = new System.Windows.Forms.TextBox();
         this.label9 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.getPropertyNameForValue = new System.Windows.Forms.ComboBox();
         this.label6 = new System.Windows.Forms.Label();
         this.getMaterialNameForValue = new System.Windows.Forms.ComboBox();
         this.NewUser = new System.Windows.Forms.Button();
         this.label8 = new System.Windows.Forms.Label();
         this.propertyType = new System.Windows.Forms.ComboBox();
         ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.groupBox3.SuspendLayout();
         this.SuspendLayout();
         // 
         // dataTable
         // 
         this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataTable.Location = new System.Drawing.Point(12, 100);
         this.dataTable.Name = "dataTable";
         this.dataTable.Size = new System.Drawing.Size(548, 423);
         this.dataTable.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label1.Location = new System.Drawing.Point(9, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(84, 16);
         this.label1.TabIndex = 1;
         this.label1.Text = "SQL запрос";
         // 
         // SQlrequest
         // 
         this.SQlrequest.Location = new System.Drawing.Point(12, 28);
         this.SQlrequest.Name = "SQlrequest";
         this.SQlrequest.Size = new System.Drawing.Size(548, 20);
         this.SQlrequest.TabIndex = 2;
         // 
         // makeRequest
         // 
         this.makeRequest.Location = new System.Drawing.Point(485, 54);
         this.makeRequest.Name = "makeRequest";
         this.makeRequest.Size = new System.Drawing.Size(75, 23);
         this.makeRequest.TabIndex = 3;
         this.makeRequest.Text = "Выполнить";
         this.makeRequest.UseVisualStyleBackColor = true;
         this.makeRequest.Click += new System.EventHandler(this.makeRequest_Click);
         // 
         // currentTable
         // 
         this.currentTable.FormattingEnabled = true;
         this.currentTable.Items.AddRange(new object[] {
            "Материалы",
            "Свойства",
            "Таблица связи",
            "Пользователи"});
         this.currentTable.Location = new System.Drawing.Point(12, 73);
         this.currentTable.Name = "currentTable";
         this.currentTable.Size = new System.Drawing.Size(136, 21);
         this.currentTable.TabIndex = 4;
         this.currentTable.SelectedIndexChanged += new System.EventHandler(this.currentTable_SelectedIndexChanged);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label2.Location = new System.Drawing.Point(9, 54);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(65, 16);
         this.label2.TabIndex = 5;
         this.label2.Text = "Таблица";
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.addMaterial);
         this.groupBox1.Controls.Add(this.materialName);
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.groupBox1.Location = new System.Drawing.Point(584, 100);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(361, 72);
         this.groupBox1.TabIndex = 6;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Добавить материал";
         // 
         // addMaterial
         // 
         this.addMaterial.Location = new System.Drawing.Point(267, 38);
         this.addMaterial.Name = "addMaterial";
         this.addMaterial.Size = new System.Drawing.Size(88, 23);
         this.addMaterial.TabIndex = 13;
         this.addMaterial.Text = "Выполнить";
         this.addMaterial.UseVisualStyleBackColor = true;
         this.addMaterial.Click += new System.EventHandler(this.addMaterial_Click);
         // 
         // materialName
         // 
         this.materialName.Location = new System.Drawing.Point(6, 39);
         this.materialName.Name = "materialName";
         this.materialName.Size = new System.Drawing.Size(139, 22);
         this.materialName.TabIndex = 10;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(6, 20);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(74, 16);
         this.label3.TabIndex = 9;
         this.label3.Text = "Название";
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.label8);
         this.groupBox2.Controls.Add(this.propertyType);
         this.groupBox2.Controls.Add(this.button1);
         this.groupBox2.Controls.Add(this.propertyUnit);
         this.groupBox2.Controls.Add(this.label5);
         this.groupBox2.Controls.Add(this.propertyName);
         this.groupBox2.Controls.Add(this.label4);
         this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.groupBox2.Location = new System.Drawing.Point(584, 187);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(361, 131);
         this.groupBox2.TabIndex = 7;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Добавить свойства материала";
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(267, 95);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(88, 23);
         this.button1.TabIndex = 15;
         this.button1.Text = "Выполнить";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // propertyUnit
         // 
         this.propertyUnit.Location = new System.Drawing.Point(115, 48);
         this.propertyUnit.Name = "propertyUnit";
         this.propertyUnit.Size = new System.Drawing.Size(142, 22);
         this.propertyUnit.TabIndex = 14;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(115, 29);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(142, 16);
         this.label5.TabIndex = 13;
         this.label5.Text = "Единица измерения";
         // 
         // propertyName
         // 
         this.propertyName.Location = new System.Drawing.Point(9, 48);
         this.propertyName.Name = "propertyName";
         this.propertyName.Size = new System.Drawing.Size(103, 22);
         this.propertyName.TabIndex = 12;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(9, 29);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(74, 16);
         this.label4.TabIndex = 11;
         this.label4.Text = "Название";
         // 
         // addValue
         // 
         this.addValue.Location = new System.Drawing.Point(267, 97);
         this.addValue.Name = "addValue";
         this.addValue.Size = new System.Drawing.Size(88, 23);
         this.addValue.TabIndex = 15;
         this.addValue.Text = "Выполнить";
         this.addValue.UseVisualStyleBackColor = true;
         this.addValue.Click += new System.EventHandler(this.addValue_Click);
         // 
         // groupBox3
         // 
         this.groupBox3.Controls.Add(this.propertyValue);
         this.groupBox3.Controls.Add(this.label9);
         this.groupBox3.Controls.Add(this.label7);
         this.groupBox3.Controls.Add(this.getPropertyNameForValue);
         this.groupBox3.Controls.Add(this.label6);
         this.groupBox3.Controls.Add(this.getMaterialNameForValue);
         this.groupBox3.Controls.Add(this.addValue);
         this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.groupBox3.Location = new System.Drawing.Point(584, 324);
         this.groupBox3.Name = "groupBox3";
         this.groupBox3.Size = new System.Drawing.Size(361, 135);
         this.groupBox3.TabIndex = 8;
         this.groupBox3.TabStop = false;
         this.groupBox3.Text = "Добавить значение свойства";
         // 
         // propertyValue
         // 
         this.propertyValue.Location = new System.Drawing.Point(161, 47);
         this.propertyValue.Name = "propertyValue";
         this.propertyValue.Size = new System.Drawing.Size(103, 22);
         this.propertyValue.TabIndex = 21;
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(161, 28);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(73, 16);
         this.label9.TabIndex = 20;
         this.label9.Text = "Значение";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(6, 77);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(138, 16);
         this.label7.TabIndex = 19;
         this.label7.Text = "Название свойства";
         // 
         // getPropertyNameForValue
         // 
         this.getPropertyNameForValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.getPropertyNameForValue.FormattingEnabled = true;
         this.getPropertyNameForValue.Location = new System.Drawing.Point(9, 96);
         this.getPropertyNameForValue.Name = "getPropertyNameForValue";
         this.getPropertyNameForValue.Size = new System.Drawing.Size(146, 24);
         this.getPropertyNameForValue.TabIndex = 18;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(6, 28);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(149, 16);
         this.label6.TabIndex = 17;
         this.label6.Text = "Название материала";
         // 
         // getMaterialNameForValue
         // 
         this.getMaterialNameForValue.FormattingEnabled = true;
         this.getMaterialNameForValue.Location = new System.Drawing.Point(9, 47);
         this.getMaterialNameForValue.Name = "getMaterialNameForValue";
         this.getMaterialNameForValue.Size = new System.Drawing.Size(146, 24);
         this.getMaterialNameForValue.TabIndex = 16;
         // 
         // NewUser
         // 
         this.NewUser.Location = new System.Drawing.Point(758, 28);
         this.NewUser.Name = "NewUser";
         this.NewUser.Size = new System.Drawing.Size(187, 23);
         this.NewUser.TabIndex = 9;
         this.NewUser.Text = "Добавить нового пользователя";
         this.NewUser.UseVisualStyleBackColor = true;
         this.NewUser.Click += new System.EventHandler(this.NewUser_Click);
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(6, 76);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(97, 16);
         this.label8.TabIndex = 21;
         this.label8.Text = "Тип свойства";
         // 
         // propertyType
         // 
         this.propertyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.propertyType.FormattingEnabled = true;
         this.propertyType.Items.AddRange(new object[] {
            "Свойство материала",
            "Эмпирический коэффициент"});
         this.propertyType.Location = new System.Drawing.Point(9, 95);
         this.propertyType.Name = "propertyType";
         this.propertyType.Size = new System.Drawing.Size(146, 24);
         this.propertyType.TabIndex = 20;
         // 
         // AdminForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.LightBlue;
         this.ClientSize = new System.Drawing.Size(982, 535);
         this.Controls.Add(this.NewUser);
         this.Controls.Add(this.groupBox3);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.currentTable);
         this.Controls.Add(this.makeRequest);
         this.Controls.Add(this.SQlrequest);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.dataTable);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.Name = "AdminForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "AdminForm";
         this.Load += new System.EventHandler(this.AdminForm_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         this.groupBox3.ResumeLayout(false);
         this.groupBox3.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.DataGridView dataTable;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox SQlrequest;
      private System.Windows.Forms.Button makeRequest;
      private System.Windows.Forms.ComboBox currentTable;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.Button addMaterial;
      private System.Windows.Forms.TextBox materialName;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.TextBox propertyUnit;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox propertyName;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Button addValue;
      private System.Windows.Forms.GroupBox groupBox3;
      private System.Windows.Forms.TextBox propertyValue;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.ComboBox getPropertyNameForValue;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.ComboBox getMaterialNameForValue;
      private System.Windows.Forms.Button NewUser;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.ComboBox propertyType;
   }
}