using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace HospitalMS_Winform
{
    partial class ViewPatient
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
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPatient));
          this.PatientidTb = new Mobilize.Web.TextBox();
          this.button1 = new Mobilize.Web.Button();
          this.label7 = new Mobilize.Web.Label();
          this.label6 = new Mobilize.Web.Label();
          this.label5 = new Mobilize.Web.Label();
          this.label4 = new Mobilize.Web.Label();
          this.label3 = new Mobilize.Web.Label();
          this.label2 = new Mobilize.Web.Label();
          this.label1 = new Mobilize.Web.Label();
          this.label8 = new Mobilize.Web.Label();
          this.PatientIdlbl = new Mobilize.Web.Label();
          this.PatientAddlbl = new Mobilize.Web.Label();
          this.PatientBGPlbl = new Mobilize.Web.Label();
          this.PatientAgelbl = new Mobilize.Web.Label();
          this.PatientNamelbl = new Mobilize.Web.Label();
          this.PatientGenlbl = new Mobilize.Web.Label();
          this.Patientphonelbl = new Mobilize.Web.Label();
          this.button3 = new Mobilize.Web.Button();
          this.button4 = new Mobilize.Web.Button();
          this.label9 = new Mobilize.Web.Label();
          this.label10 = new Mobilize.Web.Label();
          this.PatientDislbl = new Mobilize.Web.Label();
          this.Wordlbl = new Mobilize.Web.Label();
          this.printPreviewDialog1 = new Stub._System.Windows.Forms.PrintPreviewDialog();
          this.printDocument1 = new Stub._System.Drawing.Printing.PrintDocument();
          this.SuspendLayout();
          // 
          // PatientidTb
          // 
          this.PatientidTb.Location = new System.Drawing.Point(457, 30);
          this.PatientidTb.Name = "PatientidTb";
          this.PatientidTb.Size = new System.Drawing.Size(195, 26);
          this.PatientidTb.TabIndex = 43;
          // 
          // button1
          // 
          this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
          this.button1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 10F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.button1.ForeColor = System.Drawing.Color.White;
         this.button1.Location = new System.Drawing.Point(676, 13);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(189, 56);
         this.button1.TabIndex = 41;
         this.button1.Text = "Refresh";
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label7.Location = new System.Drawing.Point(645, 96);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(163, 29);
         this.label7.TabIndex = 40;
         this.label7.Text = "PatientName";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label6.Location = new System.Drawing.Point(645, 164);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(142, 29);
         this.label6.TabIndex = 39;
         this.label6.Text = "PatientGen";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label5.Location = new System.Drawing.Point(159, 153);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(140, 29);
         this.label5.TabIndex = 38;
         this.label5.Text = "PatientAdd";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label4.Location = new System.Drawing.Point(159, 213);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(147, 29);
         this.label4.TabIndex = 37;
         this.label4.Text = "PatientBGP";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label3.Location = new System.Drawing.Point(645, 242);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(169, 29);
         this.label3.TabIndex = 36;
         this.label3.Text = "PatientPhone";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label2.Location = new System.Drawing.Point(159, 284);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(140, 29);
         this.label2.TabIndex = 35;
         this.label2.Text = "PatientAge";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label1.Location = new System.Drawing.Point(278, 26);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(116, 29);
         this.label1.TabIndex = 34;
         this.label1.Text = "PatientId";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label8.Location = new System.Drawing.Point(159, 87);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(116, 29);
         this.label8.TabIndex = 44;
         this.label8.Text = "PatientId";
         // 
         // PatientIdlbl
         // 
         this.PatientIdlbl.AutoSize = true;
         this.PatientIdlbl.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.PatientIdlbl.ForeColor = System.Drawing.Color.Blue;
         this.PatientIdlbl.Location = new System.Drawing.Point(396, 87);
         this.PatientIdlbl.Name = "PatientIdlbl";
         this.PatientIdlbl.Size = new System.Drawing.Size(116, 29);
         this.PatientIdlbl.TabIndex = 48;
         this.PatientIdlbl.Text = "PatientId";
         this.PatientIdlbl.Visible = false;
         // 
         // PatientAddlbl
         // 
         this.PatientAddlbl.AutoSize = true;
         this.PatientAddlbl.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.PatientAddlbl.ForeColor = System.Drawing.Color.Blue;
         this.PatientAddlbl.Location = new System.Drawing.Point(396, 153);
         this.PatientAddlbl.Name = "PatientAddlbl";
         this.PatientAddlbl.Size = new System.Drawing.Size(140, 29);
         this.PatientAddlbl.TabIndex = 47;
         this.PatientAddlbl.Text = "PatientAdd";
         this.PatientAddlbl.Visible = false;
         // 
         // PatientBGPlbl
         // 
         this.PatientBGPlbl.AutoSize = true;
         this.PatientBGPlbl.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.PatientBGPlbl.ForeColor = System.Drawing.Color.Blue;
         this.PatientBGPlbl.Location = new System.Drawing.Point(389, 223);
         this.PatientBGPlbl.Name = "PatientBGPlbl";
         this.PatientBGPlbl.Size = new System.Drawing.Size(147, 29);
         this.PatientBGPlbl.TabIndex = 46;
         this.PatientBGPlbl.Text = "PatientBGP";
         this.PatientBGPlbl.Visible = false;
         // 
         // PatientAgelbl
         // 
         this.PatientAgelbl.AutoSize = true;
         this.PatientAgelbl.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.PatientAgelbl.ForeColor = System.Drawing.Color.Blue;
         this.PatientAgelbl.Location = new System.Drawing.Point(389, 294);
         this.PatientAgelbl.Name = "PatientAgelbl";
         this.PatientAgelbl.Size = new System.Drawing.Size(140, 29);
         this.PatientAgelbl.TabIndex = 45;
         this.PatientAgelbl.Text = "PatientAge";
         this.PatientAgelbl.Visible = false;
         // 
         // PatientNamelbl
         // 
         this.PatientNamelbl.AutoSize = true;
         this.PatientNamelbl.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.PatientNamelbl.ForeColor = System.Drawing.Color.Blue;
         this.PatientNamelbl.Location = new System.Drawing.Point(859, 96);
         this.PatientNamelbl.Name = "PatientNamelbl";
         this.PatientNamelbl.Size = new System.Drawing.Size(163, 29);
         this.PatientNamelbl.TabIndex = 51;
         this.PatientNamelbl.Text = "PatientName";
         this.PatientNamelbl.Visible = false;
         // 
         // PatientGenlbl
         // 
         this.PatientGenlbl.AutoSize = true;
         this.PatientGenlbl.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.PatientGenlbl.ForeColor = System.Drawing.Color.Blue;
         this.PatientGenlbl.Location = new System.Drawing.Point(859, 164);
         this.PatientGenlbl.Name = "PatientGenlbl";
         this.PatientGenlbl.Size = new System.Drawing.Size(142, 29);
         this.PatientGenlbl.TabIndex = 50;
         this.PatientGenlbl.Text = "PatientGen";
         this.PatientGenlbl.Visible = false;
         // 
         // Patientphonelbl
         // 
         this.Patientphonelbl.AutoSize = true;
         this.Patientphonelbl.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.Patientphonelbl.ForeColor = System.Drawing.Color.Blue;
         this.Patientphonelbl.Location = new System.Drawing.Point(859, 242);
         this.Patientphonelbl.Name = "Patientphonelbl";
         this.Patientphonelbl.Size = new System.Drawing.Size(169, 29);
         this.Patientphonelbl.TabIndex = 49;
         this.Patientphonelbl.Text = "PatientPhone";
         this.Patientphonelbl.Visible = false;
         // 
         // button3
         // 
         this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.button3.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 10F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.button3.ForeColor = System.Drawing.Color.White;
         this.button3.Location = new System.Drawing.Point(323, 431);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(189, 56);
         this.button3.TabIndex = 52;
         this.button3.Text = "Print";
         this.button3.UseVisualStyleBackColor = false;
         this.button3.Click += new System.EventHandler(this.button3_Click);
         // 
         // button4
         // 
         this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.button4.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 10F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.button4.ForeColor = System.Drawing.Color.White;
         this.button4.Location = new System.Drawing.Point(617, 431);
         this.button4.Name = "button4";
         this.button4.Size = new System.Drawing.Size(189, 56);
         this.button4.TabIndex = 53;
         this.button4.Text = "Home";
         this.button4.UseVisualStyleBackColor = false;
         this.button4.Click += new System.EventHandler(this.button4_Click);
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label9.Location = new System.Drawing.Point(645, 323);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(161, 29);
         this.label9.TabIndex = 54;
         this.label9.Text = "TypeOfWord";
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label10.Location = new System.Drawing.Point(159, 357);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(189, 29);
         this.label10.TabIndex = 55;
         this.label10.Text = "PatientDisease";
         // 
         // PatientDislbl
         // 
         this.PatientDislbl.AutoSize = true;
         this.PatientDislbl.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.PatientDislbl.ForeColor = System.Drawing.Color.Blue;
         this.PatientDislbl.Location = new System.Drawing.Point(389, 357);
         this.PatientDislbl.Name = "PatientDislbl";
         this.PatientDislbl.Size = new System.Drawing.Size(189, 29);
         this.PatientDislbl.TabIndex = 56;
         this.PatientDislbl.Text = "PatientDisease";
         this.PatientDislbl.Visible = false;
         // 
         // Wordlbl
         // 
         this.Wordlbl.AutoSize = true;
         this.Wordlbl.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.Wordlbl.ForeColor = System.Drawing.Color.Blue;
         this.Wordlbl.Location = new System.Drawing.Point(859, 323);
         this.Wordlbl.Name = "Wordlbl";
         this.Wordlbl.Size = new System.Drawing.Size(161, 29);
         this.Wordlbl.TabIndex = 57;
         this.Wordlbl.Text = "TypeOfWord";
         this.Wordlbl.Visible = false;
         // 
         // printPreviewDialog1
         // 
         this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
         this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
         this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
         this.printPreviewDialog1.Document = this.printDocument1;
         this.printPreviewDialog1.Enabled = true;
         this.printPreviewDialog1.Icon = ((Mobilize.Web.Icon)(new Mobilize.Web.Icon("assets/images/HospitalMS_Winform.ViewPatient.printPreviewDialog1.Icon.png")));
         this.printPreviewDialog1.Name = "printPreviewDialog1";
         this.printPreviewDialog1.Visible = false;
         this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
         // 
         // printDocument1
         // 
         this.printDocument1.PrintPage += new Stub._System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(1167, 601);
         this.Controls.Add(this.Wordlbl);
         this.Controls.Add(this.PatientDislbl);
         this.Controls.Add(this.label10);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.button4);
         this.Controls.Add(this.button3);
         this.Controls.Add(this.PatientNamelbl);
         this.Controls.Add(this.PatientGenlbl);
         this.Controls.Add(this.Patientphonelbl);
         this.Controls.Add(this.PatientIdlbl);
         this.Controls.Add(this.PatientAddlbl);
         this.Controls.Add(this.PatientBGPlbl);
         this.Controls.Add(this.PatientAgelbl);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.PatientidTb);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.None;
         this.Name = "ViewPatient";
         this.Properties().StartPosition = Mobilize.Web.FormStartPosition.CenterScreen;
         this.Text = "ViewPatient";
         this.Load += new System.EventHandler(this.ViewPatient_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

     }

     #endregion

      [Intercepted]
      private Mobilize.Web.TextBox PatientidTb { get; set; }

      [Intercepted]
      private Mobilize.Web.Button button1 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label7 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label6 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label5 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label4 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label3 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label2 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label1 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label8 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label PatientIdlbl { get; set; }

      [Intercepted]
      private Mobilize.Web.Label PatientAddlbl { get; set; }

      [Intercepted]
      private Mobilize.Web.Label PatientBGPlbl { get; set; }

      [Intercepted]
      private Mobilize.Web.Label PatientAgelbl { get; set; }

      [Intercepted]
      private Mobilize.Web.Label PatientNamelbl { get; set; }

      [Intercepted]
      private Mobilize.Web.Label PatientGenlbl { get; set; }

      [Intercepted]
      private Mobilize.Web.Label Patientphonelbl { get; set; }

      [Intercepted]
      private Mobilize.Web.Button button3 { get; set; }

      [Intercepted]
      private Mobilize.Web.Button button4 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label9 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label10 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label PatientDislbl { get; set; }

      [Intercepted]
      private Mobilize.Web.Label Wordlbl { get; set; }

      [Intercepted]
      private Stub._System.Windows.Forms.PrintPreviewDialog printPreviewDialog1 { get; set; }

      [Intercepted]
      private Stub._System.Drawing.Printing.PrintDocument printDocument1 { get; set; }
   }
}