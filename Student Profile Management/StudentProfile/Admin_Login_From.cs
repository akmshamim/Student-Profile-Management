using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentProfile
{
    public partial class Admin_Login_From : Form
    {
        public Admin_Login_From()
        {
            InitializeComponent();
            this.ActiveControl = text_AdminID;
            text_AdminID.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Login_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(@"Data Source=DESKTOP-R54EQ4I;Initial Catalog=Student_Profile;Integrated Security=True");
            String queary = "Select * from Admin_Login where Admin_ID = '" + text_AdminID.Text.Trim() + "' and Admin_Password = '" + text_AdminPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(queary, sqlconn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                this.Hide();
                Admin_Profile_From apf = new Admin_Profile_From();
                apf.ShowDialog();
            }
            else
                MessageBox.Show("Wrong ID / Password");
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_form mf = new main_form();
            mf.ShowDialog();
        }

        private void User_Name_Event(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = text_AdminPassword;
                text_AdminPassword.Focus();
            }
        }

        private void Password_Event(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Admin_Login_Button.PerformClick();
            }
        }
    }
}
