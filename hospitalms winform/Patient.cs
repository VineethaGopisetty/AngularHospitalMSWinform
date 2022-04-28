using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Mobilize.WebMap.Common.Attributes;

namespace HospitalMS_Winform
{

   [Observable]
   public partial class Patient : Mobilize.Web.Form
   {
       public Patient()
       {
           InitializeComponent();
       }

      [Intercepted]
      SqlConnection Con { get; set; } = new SqlConnection(@"Data Source=INBLL000519;Initial Catalog=HospitalPatient;Integrated Security=True");

      private void button1_Click(object sender, EventArgs e)
      {
          if (PatientIdTb.Text == "" || PatientNameTb.Text == "" || PatientPhoneTb.Text == "" || PatientAddTb.Text == "")
         {
            Mobilize.Web.MessageBox.Show("Missing Information");
         }
         else
         {
             try
             {
                 Con.Open();
                 string query = "Insert into HospitalPatientTbl values('" + PatientIdTb.Text + "','" + PatientNameTb.Text + "','" + PatientGenCb.SelectedItem.ToString() + "','" + PatientAddTb.Text + "','" + PatientBGPCb.SelectedItem.ToString() + "','" + PatientAgeTb.Text + "','" + PatientPhoneTb.Text + "','"+ WordCb.SelectedItem.ToString() +"','" + PatientDisTb.Text+ "')";
                 SqlCommand cmd = new SqlCommand(query, Con);
                 cmd.ExecuteNonQuery();
               Mobilize.Web.MessageBox.Show("Patient Details Added Successfully");
               Con.Close();
               populate();
           }
           catch (Exception Ex)
           {
               Mobilize.Web.MessageBox.Show(Ex.Message);
            }
        }
    }
    private void populate()
    {
        Con.Open();
        string query = "Select * from HospitalPatientTbl";
        SqlDataAdapter sda = new SqlDataAdapter(query, Con);
        SqlCommandBuilder builder = new SqlCommandBuilder(sda);
        var ds = new DataSet();
        sda.Fill(ds);
        PatientDGV.DataSource = ds.Tables[0];
        Con.Close();
    }

    private void Patient_Load(object sender, EventArgs e)
    {
        populate();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
        Home home = new Home();
        home.Show();
        this.Hide();
    }

   }
}