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
   public partial class Login : Mobilize.Web.Form
   {
       public Login()
       {
           InitializeComponent();
       }

       private void Login_Load(object sender, EventArgs e)
       {

       }

       private void label4_Click(object sender, EventArgs e)
       {
           Main main = new Main();
           main.Show();
           this.Hide();
       }

       private void button1_Click(object sender, EventArgs e)
       {
           if (UidTb.Text == "" || PassTb.Text == "")
         {
            Mobilize.Web.MessageBox.Show("Enter UserName or Password");
         }
         else if (UidTb.Text == "Admin" && PassTb.Text == "Admin123")
         {
             //this.Hide();
             Home home = new Home();
             home.Show();
         }
         else
         {
            Mobilize.Web.MessageBox.Show("Wrong userName or Password");
         }
     }

     private void button2_Click(object sender, EventArgs e)
     {
         UidTb.Text = "";
         PassTb.Text = "";
     }

   }
}