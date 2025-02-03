using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Managment
{
    public partial class add_new_patient : Form
    {
        public add_new_patient()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        readonly SqlConnection conn = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\SE C# Codes\project full\Hospital Managment\Hospital Managment\Databases\Patients.mdf"";Integrated Security=True;Connect Timeout=30");
        

        private void patient_name_Click(object sender, EventArgs e)
        {

        }

        private void picture_name_Click(object sender, EventArgs e)
        {

        }

        private void Back_add_patient_Click(object sender, EventArgs e)
        {
            Application.OpenForms[1].Show();
            this.Close();
        }

        private void add_new_patient_Load(object sender, EventArgs e)
        {

        }

        private void sign_in_button_Click(object sender, EventArgs e)//add patinet button
        {
            try
            {
                if (text_name.Text == "" || textBox1.Text == "" || clinics_list.Text == " " || comboBox1.Text == " ")
                {
                    MessageBox.Show("Missing Info");
                }
                else {
                     int payment=0;
                    if (clinics_list.Text == "1")
                    {
                        payment = 1000;
                    }
                    else if(clinics_list.Text == "2") { payment = 2000; }
                    else if(clinics_list.Text=="3") { payment = 3000; }
                    else if (clinics_list.Text=="4") { payment = 4000; }

                    conn.Open();
                    string Query = "insert into Patients Values(' " + text_name.Text + "' , ' " + comboBox1.Text + "' , ' " + textBox1.Text + "' , ' " + clinics_list.Text + "' ) ; insert into Payment Values(' " + text_name.Text + "' ,' " + payment + "')";
                    SqlCommand cmd = new SqlCommand(Query, conn);  
                    cmd.ExecuteNonQuery();

                   
                   
                    conn.Close();
                    MessageBox.Show("Reccord Entered Succesfully");

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }

        }

        private void text_name_TextChanged(object sender, EventArgs e)//patient name box
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//patient phone box
        {

        }

        private void clinics_list_SelectedIndexChanged(object sender, EventArgs e) //clinic number box
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//patient status box
        {

        }
    }
}
