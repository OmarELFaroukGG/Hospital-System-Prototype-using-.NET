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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_Managment
{
    public partial class Display_all_patients : Form
    {
        public Display_all_patients()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        readonly SqlConnection conn = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\SE C# Codes\project full\Hospital Managment\Hospital Managment\Databases\Patients.mdf"";Integrated Security=True;Connect Timeout=30");

        private void Display_Function()
        {
            try
            {
                conn.Open();
                string query = "select * from Patients";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var dataSet = new DataSet();
                sda.Fill(dataSet);
                PatientsGrid.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in Display_Function: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void DisplayFilteredPatients(int selectedClinicNumber)
        {
            try
            {
                conn.Open();

                string query;
                SqlCommand cmd;

                if (selectedClinicNumber == 0)
                {
                    // Display all patients
                    query = "SELECT * FROM Patients";
                    cmd = new SqlCommand(query, conn);
                }
                else
                {
                    // Display filtered patients based on clinic number
                    query = "SELECT * FROM Patients WHERE PclincNo = @ClinicNumber";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ClinicNumber", selectedClinicNumber);
                }

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                PatientsGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in DisplayFilteredPatients: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }


        private void Back_button_displayform_Click(object sender, EventArgs e)
        {
            Application.OpenForms[1].Show();
            this.Close();
        }

        private void Display_all_patients_Load(object sender, EventArgs e)//on loading form
        {
            Display_Function();

        }


        private void Display_All_patients_label_Click(object sender, EventArgs e)
        {

        }


        private void PatientsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                // Get the selected clinic number from the ComboBox
                if (comboBox1.SelectedItem != null)
                {
                    int selectedClinicNumber = Convert.ToInt32(comboBox1.SelectedItem);
                    DisplayFilteredPatients(selectedClinicNumber);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in comboBox1_SelectedIndexChanged: {ex.Message}");
            }
        }
    }
}
