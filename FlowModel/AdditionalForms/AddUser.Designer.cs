namespace FlowModel.AdditionalForms
{
   partial class AddUser
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
         this.UserRole = new System.Windows.Forms.ComboBox();
         this.label4 = new System.Windows.Forms.Label();
         this.Login = new System.Windows.Forms.TextBox();
         this.Password = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.add = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // UserRole
         // 
         this.UserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.UserRole.FormattingEnabled = true;
         this.UserRole.Items.AddRange(new object[] {
            "Администратор",
            "Исследователь"});
         this.UserRole.Location = new System.Drawing.Point(66, 64);
         this.UserRole.Name = "UserRole";
         this.UserRole.Size = new System.Drawing.Size(96, 21);
         this.UserRole.TabIndex = 29;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.BackColor = System.Drawing.Color.Transparent;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label4.Location = new System.Drawing.Point(3, 68);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(40, 16);
         this.label4.TabIndex = 28;
         this.label4.Text = "Роль";
         // 
         // Login
         // 
         this.Login.Location = new System.Drawing.Point(66, 8);
         this.Login.Name = "Login";
         this.Login.Size = new System.Drawing.Size(96, 20);
         this.Login.TabIndex = 26;
         // 
         // Password
         // 
         this.Password.Location = new System.Drawing.Point(66, 37);
         this.Password.Name = "Password";
         this.Password.PasswordChar = '*';
         this.Password.Size = new System.Drawing.Size(96, 20);
         this.Password.TabIndex = 25;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.BackColor = System.Drawing.Color.Transparent;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label3.Location = new System.Drawing.Point(3, 41);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(57, 16);
         this.label3.TabIndex = 24;
         this.label3.Text = "Пароль";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.BackColor = System.Drawing.Color.Transparent;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label2.Location = new System.Drawing.Point(3, 12);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(47, 16);
         this.label2.TabIndex = 23;
         this.label2.Text = "Логин";
         // 
         // add
         // 
         this.add.Location = new System.Drawing.Point(87, 91);
         this.add.Name = "add";
         this.add.Size = new System.Drawing.Size(75, 23);
         this.add.TabIndex = 30;
         this.add.Text = "Добавить";
         this.add.UseVisualStyleBackColor = true;
         this.add.Click += new System.EventHandler(this.add_Click);
         // 
         // AddUser
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.LightBlue;
         this.ClientSize = new System.Drawing.Size(166, 121);
         this.Controls.Add(this.add);
         this.Controls.Add(this.UserRole);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.Login);
         this.Controls.Add(this.Password);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.MaximizeBox = false;
         this.Name = "AddUser";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "AddUser";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ComboBox UserRole;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox Login;
      private System.Windows.Forms.TextBox Password;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button add;
   }
}