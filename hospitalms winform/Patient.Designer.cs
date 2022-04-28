using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace HospitalMS_Winform
{
    partial class Patient
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
          this.PatientGenCb = new Mobilize.Web.ComboBox();
          this.PatientBGPCb = new Mobilize.Web.ComboBox();
          this.PatientPhoneTb = new Mobilize.Web.TextBox();
          this.PatientAgeTb = new Mobilize.Web.TextBox();
          this.PatientAddTb = new Mobilize.Web.TextBox();
          this.PatientNameTb = new Mobilize.Web.TextBox();
          this.PatientIdTb = new Mobilize.Web.TextBox();
          this.button2 = new Mobilize.Web.Button();
          this.button1 = new Mobilize.Web.Button();
          this.label7 = new Mobilize.Web.Label();
          this.label6 = new Mobilize.Web.Label();
          this.label5 = new Mobilize.Web.Label();
          this.label4 = new Mobilize.Web.Label();
          this.label3 = new Mobilize.Web.Label();
          this.label2 = new Mobilize.Web.Label();
          this.label1 = new Mobilize.Web.Label();
          this.label8 = new Mobilize.Web.Label();
          this.label9 = new Mobilize.Web.Label();
          this.WordCb = new Mobilize.Web.ComboBox();
          this.PatientDisTb = new Mobilize.Web.TextBox();
          this.PatientDGV = new Mobilize.Web.DataGridView();
          this.SuspendLayout();
          // 
          // PatientGenCb
          // 
          this.PatientGenCb.Properties().FormattingEnabled = true;
         this.PatientGenCb.Items.AddRange(new object[] {
         "Male",
         "Female"});
         this.PatientGenCb.Location = new System.Drawing.Point(410, 47);
         this.PatientGenCb.Properties().Margin = new Mobilize.Web.Padding(3, 2, 3, 2);
         this.PatientGenCb.Name = "PatientGenCb";
         this.PatientGenCb.Size = new System.Drawing.Size(126, 24);
         this.PatientGenCb.TabIndex = 32;
         // 
         // PatientBGPCb
         // 
         this.PatientBGPCb.Properties().FormattingEnabled = true;
         this.PatientBGPCb.Items.AddRange(new object[] {
         "A+",
         "B+",
         "AB+",
         "AB-",
         "O+",
         "O-"});
         this.PatientBGPCb.Location = new System.Drawing.Point(37, 114);
         this.PatientBGPCb.Properties().Margin = new Mobilize.Web.Padding(3, 2, 3, 2);
         this.PatientBGPCb.Name = "PatientBGPCb";
         this.PatientBGPCb.Size = new System.Drawing.Size(158, 24);
         this.PatientBGPCb.TabIndex = 31;
         // 
         // PatientPhoneTb
         // 
         this.PatientPhoneTb.Location = new System.Drawing.Point(454, 127);
         this.PatientPhoneTb.Properties().Margin = new Mobilize.Web.Padding(3, 2, 3, 2);
         this.PatientPhoneTb.Name = "PatientPhoneTb";
         this.PatientPhoneTb.Size = new System.Drawing.Size(183, 22);
         this.PatientPhoneTb.TabIndex = 30;
         // 
         // PatientAgeTb
         // 
         this.PatientAgeTb.Location = new System.Drawing.Point(251, 114);
         this.PatientAgeTb.Properties().Margin = new Mobilize.Web.Padding(3, 2, 3, 2);
         this.PatientAgeTb.Name = "PatientAgeTb";
         this.PatientAgeTb.Size = new System.Drawing.Size(152, 22);
         this.PatientAgeTb.TabIndex = 29;
         // 
         // PatientAddTb
         // 
         this.PatientAddTb.Location = new System.Drawing.Point(615, 42);
         this.PatientAddTb.Properties().Margin = new Mobilize.Web.Padding(3, 2, 3, 2);
         this.PatientAddTb.Name = "PatientAddTb";
         this.PatientAddTb.Size = new System.Drawing.Size(136, 22);
         this.PatientAddTb.TabIndex = 28;
         // 
         // PatientNameTb
         // 
         this.PatientNameTb.Location = new System.Drawing.Point(225, 42);
         this.PatientNameTb.Properties().Margin = new Mobilize.Web.Padding(3, 2, 3, 2);
         this.PatientNameTb.Name = "PatientNameTb";
         this.PatientNameTb.Size = new System.Drawing.Size(136, 22);
         this.PatientNameTb.TabIndex = 27;
         // 
         // PatientIdTb
         // 
         this.PatientIdTb.Location = new System.Drawing.Point(38, 38);
         this.PatientIdTb.Properties().Margin = new Mobilize.Web.Padding(3, 2, 3, 2);
         this.PatientIdTb.Name = "PatientIdTb";
         this.PatientIdTb.Size = new System.Drawing.Size(125, 22);
         this.PatientIdTb.TabIndex = 26;
         // 
         // button2
         // 
         this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.button2.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 14F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.button2.ForeColor = System.Drawing.Color.White;
         this.button2.Location = new System.Drawing.Point(755, 114);
         this.button2.Properties().Margin = new Mobilize.Web.Padding(3, 2, 3, 2);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(114, 40);
         this.button2.TabIndex = 25;
         this.button2.Text = "Home";
         this.button2.UseVisualStyleBackColor = false;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.button1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 14F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.button1.ForeColor = System.Drawing.Color.White;
         this.button1.Location = new System.Drawing.Point(756, 47);
         this.button1.Properties().Margin = new Mobilize.Web.Padding(3, 2, 3, 2);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(114, 45);
         this.button1.TabIndex = 24;
         this.button1.Text = "Add";
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label7.Location = new System.Drawing.Point(205, 7);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(135, 25);
         this.label7.TabIndex = 23;
         this.label7.Text = "PatientName";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label6.Location = new System.Drawing.Point(410, 7);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(119, 25);
         this.label6.TabIndex = 22;
         this.label6.Text = "PatientGen";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label5.Location = new System.Drawing.Point(615, 7);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(118, 25);
         this.label5.TabIndex = 21;
         this.label5.Text = "PatientAdd";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label4.Location = new System.Drawing.Point(33, 74);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(123, 25);
         this.label4.TabIndex = 20;
         this.label4.Text = "PatientBGP";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label3.Location = new System.Drawing.Point(461, 85);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(141, 25);
         this.label3.TabIndex = 19;
         this.label3.Text = "PatientPhone";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label2.Location = new System.Drawing.Point(265, 74);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(118, 25);
         this.label2.TabIndex = 18;
         this.label2.Text = "PatientAge";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label1.Location = new System.Drawing.Point(44, 7);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(97, 25);
         this.label1.TabIndex = 17;
         this.label1.Text = "PatientId";
         this.label1.Click += new System.EventHandler(this.label1_Click);
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label8.Location = new System.Drawing.Point(33, 159);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(136, 25);
         this.label8.TabIndex = 34;
         this.label8.Text = "TypeOfWord";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 12F, Mobilize.Web.FontStyle.Bold, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label9.Location = new System.Drawing.Point(405, 162);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(157, 25);
         this.label9.TabIndex = 35;
         this.label9.Text = "PatientDisease";
         // 
         // WordCb
         // 
         this.WordCb.Properties().FormattingEnabled = true;
         this.WordCb.Items.AddRange(new object[] {
         "ICU",
         "DoubleBed",
         "General"});
         this.WordCb.Location = new System.Drawing.Point(193, 162);
         this.WordCb.Properties().Margin = new Mobilize.Web.Padding(3, 2, 3, 2);
         this.WordCb.Name = "WordCb";
         this.WordCb.Size = new System.Drawing.Size(158, 24);
         this.WordCb.TabIndex = 36;
         // 
         // PatientDisTb
         // 
         this.PatientDisTb.Location = new System.Drawing.Point(579, 166);
         this.PatientDisTb.Properties().Margin = new Mobilize.Web.Padding(3, 2, 3, 2);
         this.PatientDisTb.Name = "PatientDisTb";
         this.PatientDisTb.Size = new System.Drawing.Size(152, 22);
         this.PatientDisTb.TabIndex = 37;
         // 
         // PatientDGV
         // 
         this.PatientDGV.ColumnHeadersHeightSizeMode = Mobilize.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.PatientDGV.Location = new System.Drawing.Point(12, 208);
         this.PatientDGV.Name = "PatientDGV";
         this.PatientDGV.RowHeadersWidth = 51;
         this.PatientDGV.RowTemplate.Height = 24;
         this.PatientDGV.Size = new System.Drawing.Size(1031, 261);
         this.PatientDGV.TabIndex = 38;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(1055, 481);
         this.Controls.Add(this.PatientDGV);
         this.Controls.Add(this.PatientDisTb);
         this.Controls.Add(this.WordCb);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.PatientGenCb);
         this.Controls.Add(this.PatientBGPCb);
         this.Controls.Add(this.PatientPhoneTb);
         this.Controls.Add(this.PatientAgeTb);
         this.Controls.Add(this.PatientAddTb);
         this.Controls.Add(this.PatientNameTb);
         this.Controls.Add(this.PatientIdTb);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.None;
         this.Properties().Margin = new Mobilize.Web.Padding(3, 2, 3, 2);
         this.Name = "Patient";
         this.Properties().StartPosition = Mobilize.Web.FormStartPosition.CenterScreen;
         this.Text = "Patient";
         this.Load += new System.EventHandler(this.Patient_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

     }

     #endregion

      [Intercepted]

      private Mobilize.Web.ComboBox PatientGenCb { get; set; }

      [Intercepted]
      private Mobilize.Web.ComboBox PatientBGPCb { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox PatientPhoneTb { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox PatientAgeTb { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox PatientAddTb { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox PatientNameTb { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox PatientIdTb { get; set; }

      [Intercepted]
      private Mobilize.Web.Button button2 { get; set; }

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
      private Mobilize.Web.Label label9 { get; set; }

      [Intercepted]
      private Mobilize.Web.ComboBox WordCb { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox PatientDisTb { get; set; }

      [Intercepted]
      private Mobilize.Web.DataGridView PatientDGV { get; set; }
   }
}