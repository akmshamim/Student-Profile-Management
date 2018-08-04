using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentProfile
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void SignInOrRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_form sif = new Login_form();
            sif.ShowDialog();
        }

        private void Manage_form_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Login_From alf = new Admin_Login_From();
            alf.ShowDialog();
        }
    }
}
