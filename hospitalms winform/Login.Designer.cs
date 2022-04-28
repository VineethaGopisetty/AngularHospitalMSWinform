using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace HospitalMS_Winform
{
    partial class Login
    {

      /// <summary>
      /// Required designer variable.
      /// </summary>
      [Intercepted]
      private Mobilize.Web.Controls.Interfaces.IContainer components { get; set; } = null;

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

      [Mobilize.WebMap.Common.Attributes.Designer]

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private
         void InitializeComponent()
      {
          this.label1 = new Mobilize.Web.Label();
          this.label2 = new Mobilize.Web.Label();
          this.label3 = new Mobilize.Web.Label();
          this.PassTb = new Mobilize.Web.TextBox();
          this.UidTb = new Mobilize.Web.TextBox();
          this.button1 = new Mobilize.Web.Button();
          this.button2 = new Mobilize.Web.Button();
          this.label4 = new Mobilize.Web.Label();
          this.SuspendLayout();
          // 
          // label1
          // 
          this.label1.AutoSize = true;
          this.label1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 28F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label1.Location = new System.Drawing.Point(219, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(801, 64);
         this.label1.TabIndex = 3;
         this.label1.Text = "Hospital Management System";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 18F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label2.Location = new System.Drawing.Point(209, 173);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(208, 40);
         this.label2.TabIndex = 4;
         this.label2.Text = "UserName:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 18F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label3.Location = new System.Drawing.Point(209, 268);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(194, 40);
         this.label3.TabIndex = 5;
         this.label3.Text = "Password:";
         // 
         // PassTb
         // 
         this.PassTb.Location = new System.Drawing.Point(445, 282);
         this.PassTb.Name = "PassTb";
         this.PassTb.PasswordChar = '*';
         this.PassTb.Size = new System.Drawing.Size(372, 26);
         this.PassTb.TabIndex = 7;
         // 
         // UidTb
         // 
         this.UidTb.Location = new System.Drawing.Point(445, 187);
         this.UidTb.Name = "UidTb";
         this.UidTb.Size = new System.Drawing.Size(372, 26);
         this.UidTb.TabIndex = 8;
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.button1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 14F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.button1.ForeColor = System.Drawing.Color.White;
         this.button1.Location = new System.Drawing.Point(253, 409);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(214, 79);
         this.button1.TabIndex = 9;
         this.button1.Text = "Login";
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // button2
         // 
         this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.button2.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 14F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.button2.ForeColor = System.Drawing.Color.White;
         this.button2.Location = new System.Drawing.Point(624, 409);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(219, 79);
         this.button2.TabIndex = 10;
         this.button2.Text = "Clear";
         this.button2.UseVisualStyleBackColor = false;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 20F, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label4.Location = new System.Drawing.Point(1203, 9);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(47, 46);
         this.label4.TabIndex = 11;
         this.label4.Text = "X";
         this.label4.Click += new System.EventHandler(this.label4_Click);
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1262, 712);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.UidTb);
         this.Controls.Add(this.PassTb);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.None;
         this.Name = "Login";
         this.Properties().StartPosition = Mobilize.Web.FormStartPosition.CenterScreen;
         this.Text = "Login";
         this.Load += new System.EventHandler(this.Login_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

     }

     #endregion

      [Intercepted]

      private Mobilize.Web.Label label1 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label2 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label3 { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox PassTb { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox UidTb { get; set; }

      [Intercepted]
      private Mobilize.Web.Button button1 { get; set; }

      [Intercepted]
      private Mobilize.Web.Button button2 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label4 { get; set; }
   }
}