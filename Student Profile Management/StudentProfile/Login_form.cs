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
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
            this.ActiveControl = text_StudentID;
            text_StudentID.Focus();
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration_form rf = new Registration_form();
            rf.ShowDialog();
        }

        private void Sign_In_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(@"Data Source=DESKTOP-R54EQ4I;Initial Catalog=Student_Profile;Integrated Security=True");
            String queary = "Select * from Student_Login where Student_ID = '" + text_StudentID.Text.Trim() + "' and Student_Passwrd = '" + text_StudentPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(queary, sqlconn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            if (dt.Rows.Count == 1 && text_StudentID.Text.Length>1 && text_StudentPassword.Text.Length>1)
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-R54EQ4I;Initial Catalog=Student_Profile;Integrated Security=True");
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("Update Student_updateloginId set Student_ID = '" + text_StudentID.Text + "'", sqlcon);
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                this.Hide();
                Student_Profile_Form spf = new Student_Profile_Form();
                spf.ShowDialog();
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

        private void Presskey_id(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = text_StudentPassword;
                text_StudentPassword.Focus();
            }
            
        }

        private void Presskey_password(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Sign_In.PerformClick();
            }
        }
    }
}
