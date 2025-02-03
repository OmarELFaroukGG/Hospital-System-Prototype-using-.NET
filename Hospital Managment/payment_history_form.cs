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
    public partial class payment_history_form : Form
    {
        public payment_history_form()
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
                string query = "select * from Payment";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var dataSet = new DataSet();
                sda.Fill(dataSet);
                bills_table.DataSource = dataSet.Tables[0];
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void back_payment_history_Click(object sender, EventArgs e)
        {
            Application.OpenForms[1].Show();
            this.Close();
        }

        private void payment_history_form_Load(object sender, EventArgs e)
        {
            Display_Function();
        }

        private void bills_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
