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
    public partial class next_p_form : Form
    {
        public next_p_form()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void next_p_form_Load(object sender, EventArgs e)
        {

        }

        private void back_next_pateint_Click(object sender, EventArgs e)
        {
            Application.OpenForms[1].Show();
            this.Close();
        }

        private void clinic1_Click(object sender, EventArgs e)
        {

        }

        private void internist_q_Click(object sender, EventArgs e)
        {

        }

        private void clinic3_Click(object sender, EventArgs e)
        {

        }

        private void clinic4_Click(object sender, EventArgs e)
        {

        }
    }
}
