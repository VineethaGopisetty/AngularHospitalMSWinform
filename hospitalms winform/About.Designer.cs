using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace HospitalMS_Winform
{
    partial class About
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
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
          this.label1 = new Mobilize.Web.Label();
          this.richTextBox1 = new Mobilize.Web.RichTextBox();
          this.pictureBox1 = new Mobilize.Web.PictureBox();
          this.SuspendLayout();
          // 
          // label1
          // 
          this.label1.AutoSize = true;
          this.label1.Font = new Mobilize.Web.Font("Times New Roman", 20F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label1.Location = new System.Drawing.Point(403, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(288, 45);
         this.label1.TabIndex = 0;
         this.label1.Text = "About Hosipital";
         // 
         // richTextBox1
         // 
         this.richTextBox1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 14F, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.richTextBox1.Location = new System.Drawing.Point(60, 329);
         this.richTextBox1.Name = "richTextBox1";
         this.richTextBox1.Size = new System.Drawing.Size(1033, 185);
         this.richTextBox1.TabIndex = 1;
         this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = "assets/images/HospitalMSWinform.About.pictureBox1.Image.png";
         this.pictureBox1.Location = new System.Drawing.Point(437, 66);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(200, 231);
         this.pictureBox1.Properties().TabIndex = 2;
         this.pictureBox1.Properties().TabStop = false;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(1105, 541);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.richTextBox1);
         this.Controls.Add(this.label1);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.None;
         this.Name = "About";
         this.Properties().StartPosition = Mobilize.Web.FormStartPosition.CenterScreen;
         this.Text = "About";
         this.ResumeLayout(false);
         this.PerformLayout();

     }

     #endregion

      [Intercepted]

      private Mobilize.Web.Label label1 { get; set; }

      [Intercepted]
      private Mobilize.Web.RichTextBox richTextBox1 { get; set; }

      [Intercepted]
      private Mobilize.Web.PictureBox pictureBox1 { get; set; }
   }
}