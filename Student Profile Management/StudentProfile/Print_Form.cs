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
    public partial class Print_Form : Form
    {
        public Print_Form()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-R54EQ4I;Initial Catalog=Student_Profile;Integrated Security=True");

        private void Print_Form_Load(object sender, EventArgs e)
        {
            string query = "SELECT sub_list.Subject_Name,sub_list.Subject_Grade FROM sub_list,Student_updateloginId WHERE sub_list.Student_ID = Student_updateloginId.Student_ID";
            SqlCommand cmd = new SqlCommand(query, sqlcon);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            CrystalReport1 cr = new CrystalReport1();
            cr.Database.Tables["Report"].SetDataSource(dt);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
