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
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void next_p_Click(object sender, EventArgs e)
        {
            next_p_form next_p = new next_p_form();
            next_p.Show();
            this.Hide();
        }

        private void Clinics_Statistics_Click(object sender, EventArgs e)
        {
            Display_all_patients dis_all = new Display_all_patients();
            dis_all.Show();
            this.Hide();
        }

        private void ADD_New_P_Click(object sender, EventArgs e)
        {
            add_new_patient ad_n_p = new add_new_patient();
            ad_n_p.Show();
            this.Hide();
        }

        

        private void Clinic_queue_Click(object sender, EventArgs e)
        {
            select_queue clin_q = new select_queue();
            clin_q.Show();
            this.Hide();
        }
        private void billibg_history_Click(object sender, EventArgs e)
        {
            payment_history_form pymnt_his = new payment_history_form();
            pymnt_his.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_form_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Home_menu_label_Click(object sender, EventArgs e)
        {

        }

    }
}
