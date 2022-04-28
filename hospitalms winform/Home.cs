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
   public partial class Home : Mobilize.Web.Form
   {
       public Home()
       {
           InitializeComponent();
       }

       private void label3_Click(object sender, EventArgs e)
       {
           Patient pat = new Patient();
           pat.Show();
       }

       private void label2_Click(object sender, EventArgs e)
       {
           Login log = new Login();
           log.Show();
           this.Hide();
       }

       private void label5_Click(object sender, EventArgs e)
       {
           ViewPatient vpatient = new ViewPatient();
           vpatient.Show();
       }

       private void label6_Click(object sender, EventArgs e)
       {
           Slip bill = new Slip();
           bill.Show();
       }

       private void label4_Click(object sender, EventArgs e)
       {
           About about = new About();
           about.Show();
       }

       private void Home_Load(object sender, EventArgs e)
       {

       }

   }
}