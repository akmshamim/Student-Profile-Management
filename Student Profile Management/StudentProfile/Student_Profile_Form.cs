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
    public partial class Student_Profile_Form : Form
    {
        public Student_Profile_Form()
        {
            InitializeComponent();

            SqlConnection sqlconn2 = new SqlConnection(@"Data Source=DESKTOP-R54EQ4I;Initial Catalog=Student_Profile;Integrated Security=True");
            String queary2 = "Select * from Student_updateloginId";

            sqlconn2.Open();
            SqlCommand cmd2 = new SqlCommand(queary2, sqlconn2);
            SqlDataReader sdr2 = cmd2.ExecuteReader();
            if (sdr2.Read())
            {
                label_Student_ID.Text = (sdr2["Student_ID"].ToString());
            }


            SqlConnection sqlconn = new SqlConnection(@"Data Source=DESKTOP-R54EQ4I;Initial Catalog=Student_Profile;Integrated Security=True");
            String queary = "Select * from Student_Registration where Student_ID = '" + label_Student_ID.Text.Trim() + "'";

            sqlconn.Open();
            SqlCommand cmd = new SqlCommand(queary, sqlconn);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                label_Student_name.Text = (sdr["Student_Name"].ToString());
                label_Student_ID.Text = label_Student_ID.Text;
                label_Father_Name.Text = (sdr["Father_Name"].ToString());
                label_Mother_Name.Text = (sdr["Mother_Name"].ToString());
                label_Address.Text = (sdr["Student_address"].ToString());
                label_Department.Text = (sdr["Department"].ToString());
                label_Program.Text = (sdr["Program"].ToString());
                label_Birthday.Text = (sdr["Birthday"].ToString());
                label_Gender.Text = (sdr["Gender"].ToString());
                label_cgpa.Text = (sdr["cgpa"].ToString());


            }
        }

        private void Sign_Out_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_form mf = new main_form();
            mf.ShowDialog();
        }

        private void Change_password_Click(object sender, EventArgs e)
        {
            this.Hide();
            Password_Change_Form pcf = new Password_Change_Form();
            pcf.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_CompleteCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompleteCourseForm ccf = new CompleteCourseForm();
            ccf.ShowDialog();
        }

        private void Student_Profile_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
