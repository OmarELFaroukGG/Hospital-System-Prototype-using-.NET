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
    public partial class select_queue : Form
    {
        public select_queue()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void select_queue_Load(object sender, EventArgs e)
        {

        }

        private void clinic1_Click(object sender, EventArgs e)
        {
            clinic_queue one = new clinic_queue();
            one.Show();
            this.Hide();
        }

        private void internist_q_Click(object sender, EventArgs e)
        {
            clinic_queue two = new clinic_queue();
            two.Show();
            this.Hide();
        }

        private void clinic4_Click(object sender, EventArgs e)
        {
            clinic_queue three = new clinic_queue();
            three.Show();
            this.Hide();
        }

        private void clinic3_Click(object sender, EventArgs e)
        {
            clinic_queue three = new clinic_queue();
            three.Show();
            this.Hide();
        }

        private void back_next_pateint_Click(object sender, EventArgs e)
        {
            Application.OpenForms[1].Show();
            this.Close();
        }
    }
}
