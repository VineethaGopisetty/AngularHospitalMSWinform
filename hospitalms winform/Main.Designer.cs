using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace HospitalMS_Winform
{
    partial class Main
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
          this.button1 = new Mobilize.Web.Button();
          this.SuspendLayout();
          // 
          // label1
          // 
          this.label1.AutoSize = true;
          this.label1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 28F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.White;
         this.label1.Location = new System.Drawing.Point(214, 208);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(801, 64);
         this.label1.TabIndex = 2;
         this.label1.Text = "Hospital Management System";
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.Color.Azure;
         this.button1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 16F, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.button1.ForeColor = System.Drawing.Color.Black;
         this.button1.Location = new System.Drawing.Point(423, 358);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(290, 94);
         this.button1.TabIndex = 3;
         this.button1.Text = "Next";
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.ClientSize = new System.Drawing.Size(1262, 712);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.label1);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.None;
         this.Name = "Main";
         this.Properties().StartPosition = Mobilize.Web.FormStartPosition.CenterScreen;
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

     }

     #endregion

      [Intercepted]

      private Mobilize.Web.Label label1 { get; set; }

      [Intercepted]
      private Mobilize.Web.Button button1 { get; set; }
   }
}