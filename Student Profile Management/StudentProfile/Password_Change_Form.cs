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
    public partial class Password_Change_Form : Form
    {
        public Password_Change_Form()
        {
            InitializeComponent();
            this.ActiveControl = text_OldPassword;
            text_OldPassword.Focus();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Profile_Form spf = new Student_Profile_Form();
            spf.ShowDialog();
        }

        private void Sign_In_Click(object sender, EventArgs e)
        {

        }

        private void ChangePassword_Button_Click(object sender, EventArgs e)
        {

            SqlConnection sqlconn2 = new SqlConnection(@"Data Source=DESKTOP-R54EQ4I;Initial Catalog=Student_Profile;Integrated Security=True");
            String queary2 = "Select * from Student_updateloginId";

            sqlconn2.Open();
            SqlCommand cmd2 = new SqlCommand(queary2, sqlconn2);
            SqlDataReader sdr2 = cmd2.ExecuteReader();
            if (sdr2.Read())
            {
                label_Student_ID.Text = (sdr2["Student_ID"].ToString());
            }

            sqlconn2.Close();

            if (text_OldPassword.Text.Length > 1 && text_NewPassword.Text.Length >1 && text_NewConPass.Text.Length > 1)
            {
                SqlConnection sqlconn = new SqlConnection(@"Data Source=DESKTOP-R54EQ4I;Initial Catalog=Student_Profile;Integrated Security=True");
                String queary = "Select * from Student_Login where Student_Passwrd = '" + text_OldPassword.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(queary, sqlconn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    if (text_NewPassword.Text == text_NewConPass.Text)
                    {
                        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-R54EQ4I;Initial Catalog=Student_Profile;Integrated Security=True");
                        sqlcon.Open();
                        SqlCommand cmd = new SqlCommand("Update Student_Login set Student_Passwrd = '" + text_NewPassword.Text + "'where Student_ID = '"+ label_Student_ID.Text + "'", sqlcon);
                        cmd.ExecuteNonQuery();
                        sqlcon.Close();
                        MessageBox.Show("Password Change Successfull");
                        text_NewConPass.Text = "";
                        text_NewPassword.Text = "";
                        text_OldPassword.Text = "";

                    }
                    else
                        MessageBox.Show("New Password and Confirm New Password Don't Match");
                }
                else
                    MessageBox.Show("Wrong Old Password");
            }
            else
                MessageBox.Show("Fill In The All Information");

        }

        private void Old_Password_Event(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = text_NewPassword;
                text_NewPassword.Focus();
            }
        }

        private void New_Password_Event(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = text_NewConPass;
                text_NewConPass.Focus();
            }
        }

        private void Confirm_Password_Event(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChangePassword_Button.PerformClick();
            }
        }
    }
}
