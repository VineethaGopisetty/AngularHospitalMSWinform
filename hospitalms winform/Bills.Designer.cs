using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace HospitalMS_Winform
{
    partial class Slip
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
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Slip));
          this.label8 = new Mobilize.Web.Label();
          this.label7 = new Mobilize.Web.Label();
          this.label1 = new Mobilize.Web.Label();
          this.label2 = new Mobilize.Web.Label();
          this.button3 = new Mobilize.Web.Button();
          this.button1 = new Mobilize.Web.Button();
          this.button2 = new Mobilize.Web.Button();
          this.PatientIdlbl = new Mobilize.Web.TextBox();
          this.PatientNamelbl = new Mobilize.Web.TextBox();
          this.Dayslbl = new Mobilize.Web.TextBox();
          this.button4 = new Mobilize.Web.Button();
          this.label6 = new Mobilize.Web.Label();
          this.WordTb = new Mobilize.Web.TextBox();
          this.PatientGenTb = new Mobilize.Web.TextBox();
          this.BillSlip = new Mobilize.Web.RichTextBox();
          this.printDocument1 = new Stub._System.Drawing.Printing.PrintDocument();
          this.printPreviewDialog1 = new Stub._System.Windows.Forms.PrintPreviewDialog();
          this.SuspendLayout();
          // 
          // label8
          // 
          this.label8.AutoSize = true;
          this.label8.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label8.Location = new System.Drawing.Point(79, 25);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(116, 29);
         this.label8.TabIndex = 45;
         this.label8.Text = "PatientId";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label7.Location = new System.Drawing.Point(79, 109);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(163, 29);
         this.label7.TabIndex = 46;
         this.label7.Text = "PatientName";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label1.Location = new System.Drawing.Point(77, 278);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(161, 29);
         this.label1.TabIndex = 47;
         this.label1.Text = "TypeOfWord";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label2.Location = new System.Drawing.Point(77, 386);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(196, 29);
         this.label2.TabIndex = 48;
         this.label2.Text = "Treatment Days";
         // 
         // button3
         // 
         this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.button3.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 10F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.button3.ForeColor = System.Drawing.Color.White;
         this.button3.Location = new System.Drawing.Point(814, 485);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(189, 56);
         this.button3.TabIndex = 53;
         this.button3.Text = "Print";
         this.button3.UseVisualStyleBackColor = false;
         this.button3.Click += new System.EventHandler(this.button3_Click);
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.button1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 10F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.button1.ForeColor = System.Drawing.Color.White;
         this.button1.Location = new System.Drawing.Point(314, 51);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(189, 56);
         this.button1.TabIndex = 54;
         this.button1.Text = "FetchData";
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // button2
         // 
         this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.button2.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 10F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.button2.ForeColor = System.Drawing.Color.White;
         this.button2.Location = new System.Drawing.Point(381, 476);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(189, 56);
         this.button2.TabIndex = 55;
         this.button2.Text = "View";
         this.button2.UseVisualStyleBackColor = false;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // PatientIdlbl
         // 
         this.PatientIdlbl.Location = new System.Drawing.Point(82, 68);
         this.PatientIdlbl.Name = "PatientIdlbl";
         this.PatientIdlbl.Size = new System.Drawing.Size(210, 26);
         this.PatientIdlbl.TabIndex = 56;
         // 
         // PatientNamelbl
         // 
         this.PatientNamelbl.Enabled = false;
         this.PatientNamelbl.Location = new System.Drawing.Point(93, 150);
         this.PatientNamelbl.Name = "PatientNamelbl";
         this.PatientNamelbl.Size = new System.Drawing.Size(210, 26);
         this.PatientNamelbl.TabIndex = 58;
         this.PatientNamelbl.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         // 
         // Dayslbl
         // 
         this.Dayslbl.Location = new System.Drawing.Point(103, 437);
         this.Dayslbl.Name = "Dayslbl";
         this.Dayslbl.Size = new System.Drawing.Size(210, 26);
         this.Dayslbl.TabIndex = 59;
         // 
         // button4
         // 
         this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.button4.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 10F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.button4.ForeColor = System.Drawing.Color.White;
         this.button4.Location = new System.Drawing.Point(103, 476);
         this.button4.Name = "button4";
         this.button4.Size = new System.Drawing.Size(189, 56);
         this.button4.TabIndex = 61;
         this.button4.Text = "Home";
         this.button4.UseVisualStyleBackColor = false;
         this.button4.Click += new System.EventHandler(this.button4_Click);
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label6.Location = new System.Drawing.Point(79, 194);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(142, 29);
         this.label6.TabIndex = 62;
         this.label6.Text = "PatientGen";
         // 
         // WordTb
         // 
         this.WordTb.Enabled = false;
         this.WordTb.Location = new System.Drawing.Point(93, 334);
         this.WordTb.Name = "WordTb";
         this.WordTb.Size = new System.Drawing.Size(210, 26);
         this.WordTb.TabIndex = 63;
         this.WordTb.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         // 
         // PatientGenTb
         // 
         this.PatientGenTb.Enabled = false;
         this.PatientGenTb.Location = new System.Drawing.Point(93, 237);
         this.PatientGenTb.Name = "PatientGenTb";
         this.PatientGenTb.Size = new System.Drawing.Size(210, 26);
         this.PatientGenTb.TabIndex = 64;
         this.PatientGenTb.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         // 
         // BillSlip
         // 
         this.BillSlip.BorderStyle = Mobilize.Web.BorderStyle.FixedSingle;
         this.BillSlip.Font = new Mobilize.Web.Font("Times New Roman", 12F, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.BillSlip.ForeColor = Mobilize.Web.SystemColors.MenuHighlight;
         this.BillSlip.Location = new System.Drawing.Point(580, 30);
         this.BillSlip.Name = "BillSlip";
         this.BillSlip.Size = new System.Drawing.Size(559, 407);
         this.BillSlip.TabIndex = 65;
         this.BillSlip.Text = "";
         // 
         // printDocument1
         // 
         this.printDocument1.PrintPage += new Stub._System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
         // 
         // printPreviewDialog1
         // 
         this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
         this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
         this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
         this.printPreviewDialog1.Document = this.printDocument1;
         this.printPreviewDialog1.Enabled = true;
         this.printPreviewDialog1.Icon = ((Mobilize.Web.Icon)(new Mobilize.Web.Icon("assets/images/HospitalMS_Winform.Slip.printPreviewDialog1.Icon.png")));
         this.printPreviewDialog1.Name = "printPreviewDialog1";
         this.printPreviewDialog1.Visible = false;
         this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(1187, 601);
         this.Controls.Add(this.BillSlip);
         this.Controls.Add(this.PatientGenTb);
         this.Controls.Add(this.WordTb);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.button4);
         this.Controls.Add(this.Dayslbl);
         this.Controls.Add(this.PatientNamelbl);
         this.Controls.Add(this.PatientIdlbl);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.button3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label8);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.None;
         this.Name = "Slip";
         this.Properties().StartPosition = Mobilize.Web.FormStartPosition.CenterScreen;
         this.Load += new System.EventHandler(this.Bills_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

     }

     #endregion

      [Intercepted]

      private Mobilize.Web.Label label8 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label7 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label1 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label2 { get; set; }

      [Intercepted]
      private Mobilize.Web.Button button3 { get; set; }

      [Intercepted]
      private Mobilize.Web.Button button1 { get; set; }

      [Intercepted]
      private Mobilize.Web.Button button2 { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox PatientIdlbl { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox PatientNamelbl { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox Dayslbl { get; set; }

      [Intercepted]
      private Mobilize.Web.Button button4 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label6 { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox WordTb { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox PatientGenTb { get; set; }

      [Intercepted]
      private Mobilize.Web.RichTextBox BillSlip { get; set; }

      [Intercepted]
      private Stub._System.Drawing.Printing.PrintDocument printDocument1 { get; set; }

      [Intercepted]
      private Stub._System.Windows.Forms.PrintPreviewDialog printPreviewDialog1 { get; set; }
   }
}