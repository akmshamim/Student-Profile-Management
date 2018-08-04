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
    public partial class Registration_form : Form
    {
        public Registration_form()
        {
            InitializeComponent();
            this.ActiveControl = Text_Student_Name;
            Text_Student_Name.Focus();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_form lf = new Login_form();
            lf.ShowDialog();
        }

        private void Submit_button_Click(object sender, EventArgs e)
        {
            String DateOfBirth = combo_Day.Text + " " + combo_Month.Text + " " + combo_Year.Text;
            String Student_CGPA = "0";

            if (Text_Student_Name.Text.Length > 1 && Text_Father_Name.Text.Length > 1 && Text_Mother_Name.Text.Length > 1 && Text_Address.Text.Length > 1 && combo_Department.Text.Length > 1 && combo_Program.Text.Length > 1 && DateOfBirth.Length > 1 && combo_Gender.Text.Length > 1 && Text_StudentID.Text.Length > 1 && Text_Studentpass.Text.Length > 1 && Text_StudentConPass.Text.Length > 1)
            {
                SqlConnection sqlconn = new SqlConnection(@"Data Source=DESKTOP-R54EQ4I;Initial Catalog=Student_Profile;Integrated Security=True");
                String queary = "Select * from Student_Registration where Student_ID = '" + Text_StudentID.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(queary, sqlconn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("This Student ID Already Exist");
                }
                else
                {
                    if (Text_Studentpass.Text == Text_StudentConPass.Text)
                    {
                        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-R54EQ4I;Initial Catalog=Student_Profile;Integrated Security=True");
                        sqlcon.Open();
                        SqlCommand cmd = new SqlCommand("insert into Student_Registration(Student_Name,Father_Name,Mother_Name,Student_address,Department,Program,Birthday,Gender,cgpa,Student_ID) values('" + Text_Student_Name.Text + "','" + Text_Father_Name.Text + "','" + Text_Mother_Name.Text + "','" + Text_Address.Text + "','" + combo_Department.Text + "','" + combo_Program.Text + "','" + DateOfBirth + "','" + combo_Gender.Text + "','" + Student_CGPA + "','" + Text_StudentID.Text + "')", sqlcon);
                        SqlCommand cmd2 = new SqlCommand("insert into Student_Login values('" + Text_StudentID.Text + "','" + Text_Studentpass.Text + "')", sqlcon);
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        sqlcon.Close();
                        MessageBox.Show("Registration Successfull");

                        this.Hide();
                        Registration_form rf = new Registration_form();
                        rf.ShowDialog();
                        
                    }

                    else
                        MessageBox.Show("Password and Confirm don't Match");

                }
            }
            else
                MessageBox.Show("Fill In The All Information");


        }

        private void Student_Name_Event(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = Text_Father_Name;
                Text_Father_Name.Focus();
            }
        }

        private void Father_Name_Event(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = Text_Mother_Name;
                Text_Mother_Name.Focus();
            }
        }

        private void Mother_Name_Event(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = Text_Address;
                Text_Address.Focus();
            }
        }

        private void Address_Event(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = Text_StudentID;
                Text_StudentID.Focus();
            }
        }

        private void Student_ID_Event(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = Text_Studentpass;
                Text_Studentpass.Focus();
            }
        }

        private void Password_Event(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = Text_StudentConPass;
                Text_StudentConPass.Focus();
            }
        }

        private void ConfirmPassword_Event(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Submit_button.PerformClick();
            }
        }
    }
}
