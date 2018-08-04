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
    public partial class Admin_Profile_From : Form
    {
        public Admin_Profile_From()
        {
            InitializeComponent();
        }

        private void Admin_SignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_form mf = new main_form();
            mf.ShowDialog();
        }

        private void Find_button_Click(object sender, EventArgs e)
        {
            if (Text_Search_Student_ID.Text.Length > 1)
            {
                SqlConnection sqlconn = new SqlConnection(@"Data Source=DESKTOP-R54EQ4I;Initial Catalog=Student_Profile;Integrated Security=True");
                String queary = "Select * from Student_Registration where Student_ID = '" + Text_Search_Student_ID.Text.Trim() + "'";

                sqlconn.Open();
                SqlCommand cmd = new SqlCommand(queary, sqlconn);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    label_Student_name.Text = (sdr["Student_Name"].ToString());
                    label_Student_ID.Text = Text_Search_Student_ID.Text;
                    label_Father_Name.Text = (sdr["Father_Name"].ToString());
                    label_Mother_Name.Text = (sdr["Mother_Name"].ToString());
                    label_Address.Text = (sdr["Student_address"].ToString());
                    label_Department.Text = (sdr["Department"].ToString());
                    label_Program.Text = (sdr["Program"].ToString());
                    label_Birthday.Text = (sdr["Birthday"].ToString());
                    label_Gender.Text = (sdr["Gender"].ToString());
                    label_cgpa.Text = (sdr["cgpa"].ToString());
                    sqlconn.Close();
                    comboBox_SubName.Items.Clear();

                    if(label_Department.Text=="CSE")
                    {
                        SqlConnection sqlconn2 = new SqlConnection(@"Data Source=DESKTOP-R54EQ4I;Initial Catalog=Student_Profile;Integrated Security=True");
                        sqlconn2.Open();

                        SqlCommand cmd2 = new SqlCommand("select Subject_Name from dep_cse", sqlconn2);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        sda.Fill(dt2);

                        for (int i = 0; i < dt2.Rows.Count; i++)
                        {
                            comboBox_SubName.Items.Add(dt2.Rows[i]["Subject_Name"]);
                        }
                        sqlconn2.Close();
                    }
                    else if (label_Department.Text == "EEE")
                    {
                        SqlConnection sqlconn2 = new SqlConnection(@"Data Source=DESKTOP-R54EQ4I;Initial Catalog=Student_Profile;Integrated Security=True");
                        sqlconn2.Open();

                        SqlCommand cmd2 = new SqlCommand("select Subject_Name from dep_eee", sqlconn2);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        sda.Fill(dt2);

                        for (int i = 0; i < dt2.Rows.Count; i++)
                        {
                            comboBox_SubName.Items.Add(dt2.Rows[i]["Subject_Name"]);
                        }
                        sqlconn2.Close();
                    }
                    else if (label_Department.Text == "Textile")
                    {
                        SqlConnection sqlconn2 = new SqlConnection(@"Data Source=DESKTOP-R54EQ4I;Initial Catalog=Student_Profile;Integrated Security=True");
                        sqlconn2.Open();

                        SqlCommand cmd2 = new SqlCommand("select Subject_Name from dep_textile", sqlconn2);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        sda.Fill(dt2);

                        for (int i = 0; i < dt2.Rows.Count; i++)
                        {
                            comboBox_SubName.Items.Add(dt2.Rows[i]["Subject_Name"]);
                        }
                        sqlconn2.Close();
                    }
                    else if (label_Department.Text == "English")
                    {
                        SqlConnection sqlconn2 = new SqlConnection(@"Data Source=DESKTOP-R54EQ4I;Initial Catalog=Student_Profile;Integrated Security=True");
                        sqlconn2.Open();

                        SqlCommand cmd2 = new SqlCommand("select Subject_Name from dep_English", sqlconn2);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        sda.Fill(dt2);

                        for (int i = 0; i < dt2.Rows.Count; i++)
                        {
                            comboBox_SubName.Items.Add(dt2.Rows[i]["Subject_Name"]);
                        }
                        sqlconn2.Close();
                    }
                    else if (label_Department.Text == "Law")
                    {
                        SqlConnection sqlconn2 = new SqlConnection(@"Data Source=DESKTOP-R54EQ4I;Initial Catalog=Student_Profile;Integrated Security=True");
                        sqlconn2.Open();

                        SqlCommand cmd2 = new SqlCommand("select Subject_Name from dep_law", sqlconn2);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        sda.Fill(dt2);

                        for (int i = 0; i < dt2.Rows.Count; i++)
                        {
                            comboBox_SubName.Items.Add(dt2.Rows[i]["Subject_Name"]);
                        }
                        sqlconn2.Close();
                    }


                }
                else
                {
                    MessageBox.Show("Student ID Don't Match");
                    label_Student_name.Text = "";
                    label_Student_ID.Text = "";
                    label_Father_Name.Text = "";
                    label_Mother_Name.Text = "";
                    label_Address.Text = "";
                    label_Department.Text = "";
                    label_Program.Text = "";
                    label_Birthday.Text = "";
                    label_Gender.Text = "";
                    label_cgpa.Text = "";
                    sqlconn.Close();
                    comboBox_SubName.Items.Clear();

                }

                //sqlconn.Close();
            }
            else
                MessageBox.Show("Enter Student ID After Find");
            
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if(label_Student_ID.Text.Length > 1)
            {
                SqlConnection sqlconn = new SqlConnection(@"Data Source=DESKTOP-R54EQ4I;Initial Catalog=Student_Profile;Integrated Security=True");
                String queary = "Select * from Student_Registration where Student_ID = '" + Text_Search_Student_ID.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(queary, sqlconn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count >= 1 && text_cgpa.Text.Length > 1)
                {

                    SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-R54EQ4I;Initial Catalog=Student_Profile;Integrated Security=True");
                    sqlcon.Open();
                    SqlCommand cmd = new SqlCommand("insert into Student_Registration(cgpa) values('" + text_cgpa.Text + "')", sqlcon);
                    
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();
                    label_cgpa.Text = text_cgpa.Text;
                    MessageBox.Show("Update Successfull");

                    SqlConnection sqlcon2 = new SqlConnection(@"Data Source=DESKTOP-R54EQ4I;Initial Catalog=Student_Profile;Integrated Security=True");
                    sqlcon2.Open();
                    SqlCommand cmd2 = new SqlCommand("Update Student_Registration set cgpa = '" + label_cgpa.Text + "'where Student_ID = '" + Text_Search_Student_ID.Text + "'", sqlcon2);
                    cmd2.ExecuteNonQuery();
                    sqlcon2.Close();

                }
                else
                    MessageBox.Show("Enter CGPA After Update");
            }
            else
                MessageBox.Show("Find Student Id After Update CGPA");


        }

        private void Student_ID_Search_Event(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Find_button.PerformClick();
            }
        }

        private void Cgpa_Event(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Update_button.PerformClick();
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {

           

                if (comboBox_SubName.Text.Length > 1 && comboBox_Grade.Text.Length > 1)
                {

                    SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-R54EQ4I;Initial Catalog=Student_Profile;Integrated Security=True");
                    sqlcon.Open();
                    SqlCommand cmd = new SqlCommand("insert into sub_list(Student_ID,Subject_Name,Subject_Grade) values('" + Text_Search_Student_ID.Text + "','" + comboBox_SubName.Text + "','" + comboBox_Grade.Text + "')", sqlcon);
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();
                    MessageBox.Show("Save Succesfully");


                }
                else
                    MessageBox.Show("Select Course and Grade After Save");
            
        }
    }
}
