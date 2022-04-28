using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace HospitalMS_Winform
{
    partial class Home
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
          this.panel1 = new Mobilize.Web.Panel();
          this.label6 = new Mobilize.Web.Label();
          this.label4 = new Mobilize.Web.Label();
          this.label5 = new Mobilize.Web.Label();
          this.label3 = new Mobilize.Web.Label();
          this.label1 = new Mobilize.Web.Label();
          this.label2 = new Mobilize.Web.Label();
          this.SuspendLayout();
          // 
          // panel1
          // 
          this.panel1.BackColor = System.Drawing.Color.White;
          this.panel1.Location = new System.Drawing.Point(0, 54);
          this.panel1.Name = "panel1";
          this.panel1.Size = new System.Drawing.Size(1234, 622);
          this.panel1.TabIndex = 1;
          // 
          // label6
          // 
          this.label6.AutoSize = true;
          this.label6.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 14F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label6.ForeColor = System.Drawing.Color.White;
         this.label6.Location = new System.Drawing.Point(644, 9);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(171, 32);
         this.label6.TabIndex = 5;
         this.label6.Text = "PatientBills";
         this.label6.Click += new System.EventHandler(this.label6_Click);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 14F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label4.ForeColor = System.Drawing.Color.White;
         this.label4.Location = new System.Drawing.Point(903, 9);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(95, 32);
         this.label4.TabIndex = 4;
         this.label4.Text = "About";
         this.label4.Click += new System.EventHandler(this.label4_Click);
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 14F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label5.ForeColor = System.Drawing.Color.White;
         this.label5.Location = new System.Drawing.Point(377, 9);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(176, 32);
         this.label5.TabIndex = 3;
         this.label5.Text = "ViewDetails";
         this.label5.Click += new System.EventHandler(this.label5_Click);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 14F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.Color.White;
         this.label3.Location = new System.Drawing.Point(177, 9);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(112, 32);
         this.label3.TabIndex = 1;
         this.label3.Text = "Patient";
         this.label3.Click += new System.EventHandler(this.label3_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 14F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.White;
         this.label1.Location = new System.Drawing.Point(12, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(94, 32);
         this.label1.TabIndex = 6;
         this.label1.Text = "Home";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 14F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.White;
         this.label2.Location = new System.Drawing.Point(1079, 9);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(109, 32);
         this.label2.TabIndex = 6;
         this.label2.Text = "Logout";
         this.label2.Click += new System.EventHandler(this.label2_Click);
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.ClientSize = new System.Drawing.Size(1232, 713);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.label3);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.None;
         this.Name = "Home";
         this.Properties().StartPosition = Mobilize.Web.FormStartPosition.CenterScreen;
         this.Text = "Home";
         this.Load += new System.EventHandler(this.Home_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

     }

     #endregion

      [Intercepted]

      private Mobilize.Web.Panel panel1 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label6 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label4 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label5 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label3 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label1 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label2 { get; set; }
   }
}