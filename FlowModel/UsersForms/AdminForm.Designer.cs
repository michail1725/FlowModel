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
         this.materialId = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.materialName = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
         this.groupBox1.SuspendLayout();
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
         this.SQlrequest.Size = new System.Drawing.Size(524, 20);
         this.SQlrequest.TabIndex = 2;
         // 
         // makeRequest
         // 
         this.makeRequest.Location = new System.Drawing.Point(461, 54);
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
            "Значения"});
         this.currentTable.Location = new System.Drawing.Point(12, 73);
         this.currentTable.Name = "currentTable";
         this.currentTable.Size = new System.Drawing.Size(121, 21);
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
         this.groupBox1.Controls.Add(this.materialId);
         this.groupBox1.Controls.Add(this.label4);
         this.groupBox1.Controls.Add(this.materialName);
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.groupBox1.Location = new System.Drawing.Point(584, 100);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(352, 72);
         this.groupBox1.TabIndex = 6;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Добавить материал";
         // 
         // addMaterial
         // 
         this.addMaterial.Location = new System.Drawing.Point(258, 38);
         this.addMaterial.Name = "addMaterial";
         this.addMaterial.Size = new System.Drawing.Size(88, 23);
         this.addMaterial.TabIndex = 13;
         this.addMaterial.Text = "Выполнить";
         this.addMaterial.UseVisualStyleBackColor = true;
         this.addMaterial.Click += new System.EventHandler(this.addMaterial_Click);
         // 
         // materialId
         // 
         this.materialId.Location = new System.Drawing.Point(6, 38);
         this.materialId.Name = "materialId";
         this.materialId.Size = new System.Drawing.Size(44, 22);
         this.materialId.TabIndex = 12;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(3, 19);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(19, 16);
         this.label4.TabIndex = 11;
         this.label4.Text = "id";
         // 
         // materialName
         // 
         this.materialName.Location = new System.Drawing.Point(56, 38);
         this.materialName.Name = "materialName";
         this.materialName.Size = new System.Drawing.Size(139, 22);
         this.materialName.TabIndex = 10;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(53, 19);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(74, 16);
         this.label3.TabIndex = 9;
         this.label3.Text = "Название";
         // 
         // groupBox2
         // 
         this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.groupBox2.Location = new System.Drawing.Point(584, 187);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(352, 133);
         this.groupBox2.TabIndex = 7;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Добавить свойства материала";
         // 
         // AdminForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.LightBlue;
         this.ClientSize = new System.Drawing.Size(982, 535);
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
         ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
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
      private System.Windows.Forms.TextBox materialId;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox materialName;
      private System.Windows.Forms.Label label3;
   }
}