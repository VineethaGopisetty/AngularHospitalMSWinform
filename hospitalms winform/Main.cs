using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobilize.WebMap.Common.Attributes;

namespace HospitalMS_Winform
{

   [Observable]
   public partial class Main : Mobilize.Web.Form
   {
       public Main()
       {
           InitializeComponent();
       }

       private void button1_Click(object sender, EventArgs e)
       {
           Login log = new Login();
           log.Show();
           this.Hide();
       }

   }
}