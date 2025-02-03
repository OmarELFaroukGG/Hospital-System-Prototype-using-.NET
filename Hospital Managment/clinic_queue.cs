using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Managment
{
    public partial class clinic_queue : Form
    {
        public clinic_queue()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void clinic_queue_Load(object sender, EventArgs e)
        {

        }

        private void back_clinic_queue_Click(object sender, EventArgs e)
        {
            Application.OpenForms[2].Show();
            this.Close();
        }

        private void Clinic2Datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
