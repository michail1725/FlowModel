namespace FlowModel.UsersForms
{
   partial class LoginForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
         this.label2 = new System.Windows.Forms.Label();
         this.password = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.name = new System.Windows.Forms.TextBox();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.loginButton = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.BackColor = System.Drawing.Color.Transparent;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label2.Location = new System.Drawing.Point(164, 47);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(71, 20);
         this.label2.TabIndex = 8;
         this.label2.Text = "Пароль:";
         // 
         // password
         // 
         this.password.Location = new System.Drawing.Point(164, 70);
         this.password.Name = "password";
         this.password.PasswordChar = '*';
         this.password.Size = new System.Drawing.Size(167, 20);
         this.password.TabIndex = 7;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.Color.Transparent;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label1.Location = new System.Drawing.Point(164, 1);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(59, 20);
         this.label1.TabIndex = 10;
         this.label1.Text = "Логин:";
         // 
         // name
         // 
         this.name.Location = new System.Drawing.Point(164, 24);
         this.name.Name = "name";
         this.name.Size = new System.Drawing.Size(167, 20);
         this.name.TabIndex = 9;
         // 
         // pictureBox1
         // 
         this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
         this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.Location = new System.Drawing.Point(8, 2);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(150, 150);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 11;
         this.pictureBox1.TabStop = false;
         // 
         // loginButton
         // 
         this.loginButton.Location = new System.Drawing.Point(256, 125);
         this.loginButton.Name = "loginButton";
         this.loginButton.Size = new System.Drawing.Size(75, 27);
         this.loginButton.TabIndex = 12;
         this.loginButton.Text = "Войти";
         this.loginButton.UseVisualStyleBackColor = true;
         this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
         // 
         // LoginForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.LightBlue;
         this.ClientSize = new System.Drawing.Size(343, 160);
         this.Controls.Add(this.loginButton);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.name);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.password);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.Name = "LoginForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "LoginForm";
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox password;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox name;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Button loginButton;
   }
}