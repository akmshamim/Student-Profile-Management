namespace StudentProfile
{
    partial class Registration_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Text_Student_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Text_Father_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Text_Mother_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Text_StudentID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Submit_button = new System.Windows.Forms.Button();
            this.combo_Department = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.combo_Program = new System.Windows.Forms.ComboBox();
            this.combo_Day = new System.Windows.Forms.ComboBox();
            this.combo_Month = new System.Windows.Forms.ComboBox();
            this.combo_Year = new System.Windows.Forms.ComboBox();
            this.combo_Gender = new System.Windows.Forms.ComboBox();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Text_Studentpass = new System.Windows.Forms.TextBox();
            this.Text_StudentConPass = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Text_Address = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(-8, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 369);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Registration";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(408, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name";
            // 
            // Text_Student_Name
            // 
            this.Text_Student_Name.Location = new System.Drawing.Point(508, 77);
            this.Text_Student_Name.Name = "Text_Student_Name";
            this.Text_Student_Name.Size = new System.Drawing.Size(239, 20);
            this.Text_Student_Name.TabIndex = 2;
            this.Text_Student_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Student_Name_Event);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(408, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Father Name";
            // 
            // Text_Father_Name
            // 
            this.Text_Father_Name.Location = new System.Drawing.Point(508, 106);
            this.Text_Father_Name.Name = "Text_Father_Name";
            this.Text_Father_Name.Size = new System.Drawing.Size(239, 20);
            this.Text_Father_Name.TabIndex = 2;
            this.Text_Father_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Father_Name_Event);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(408, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mother Name";
            // 
            // Text_Mother_Name
            // 
            this.Text_Mother_Name.Location = new System.Drawing.Point(508, 139);
            this.Text_Mother_Name.Name = "Text_Mother_Name";
            this.Text_Mother_Name.Size = new System.Drawing.Size(239, 20);
            this.Text_Mother_Name.TabIndex = 2;
            this.Text_Mother_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mother_Name_Event);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(408, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Department";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(408, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Date of Birth";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(408, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Gender";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(408, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Student ID";
            // 
            // Text_StudentID
            // 
            this.Text_StudentID.Location = new System.Drawing.Point(508, 318);
            this.Text_StudentID.Name = "Text_StudentID";
            this.Text_StudentID.Size = new System.Drawing.Size(239, 20);
            this.Text_StudentID.TabIndex = 2;
            this.Text_StudentID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Student_ID_Event);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(408, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Password";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(408, 384);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "Confirm Password";
            // 
            // Submit_button
            // 
            this.Submit_button.Location = new System.Drawing.Point(570, 415);
            this.Submit_button.Name = "Submit_button";
            this.Submit_button.Size = new System.Drawing.Size(113, 23);
            this.Submit_button.TabIndex = 3;
            this.Submit_button.Text = "Submit";
            this.Submit_button.UseVisualStyleBackColor = true;
            this.Submit_button.Click += new System.EventHandler(this.Submit_button_Click);
            // 
            // combo_Department
            // 
            this.combo_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Department.FormattingEnabled = true;
            this.combo_Department.Items.AddRange(new object[] {
            "CSE",
            "EEE",
            "Textile",
            "English",
            "Law"});
            this.combo_Department.Location = new System.Drawing.Point(508, 200);
            this.combo_Department.Name = "combo_Department";
            this.combo_Department.Size = new System.Drawing.Size(239, 21);
            this.combo_Department.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(408, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 1;
            this.label11.Text = "Program";
            // 
            // combo_Program
            // 
            this.combo_Program.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Program.FormattingEnabled = true;
            this.combo_Program.Items.AddRange(new object[] {
            "B.Sc.",
            "M.Sc.",
            "Phd"});
            this.combo_Program.Location = new System.Drawing.Point(508, 229);
            this.combo_Program.Name = "combo_Program";
            this.combo_Program.Size = new System.Drawing.Size(239, 21);
            this.combo_Program.TabIndex = 4;
            // 
            // combo_Day
            // 
            this.combo_Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Day.FormattingEnabled = true;
            this.combo_Day.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.combo_Day.Location = new System.Drawing.Point(508, 260);
            this.combo_Day.Name = "combo_Day";
            this.combo_Day.Size = new System.Drawing.Size(70, 21);
            this.combo_Day.TabIndex = 4;
            // 
            // combo_Month
            // 
            this.combo_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Month.FormattingEnabled = true;
            this.combo_Month.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "Jully",
            "Auguest",
            "September",
            "October",
            "November",
            "December"});
            this.combo_Month.Location = new System.Drawing.Point(587, 260);
            this.combo_Month.Name = "combo_Month";
            this.combo_Month.Size = new System.Drawing.Size(68, 21);
            this.combo_Month.TabIndex = 4;
            // 
            // combo_Year
            // 
            this.combo_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Year.FormattingEnabled = true;
            this.combo_Year.Items.AddRange(new object[] {
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000"});
            this.combo_Year.Location = new System.Drawing.Point(667, 260);
            this.combo_Year.Name = "combo_Year";
            this.combo_Year.Size = new System.Drawing.Size(80, 21);
            this.combo_Year.TabIndex = 4;
            // 
            // combo_Gender
            // 
            this.combo_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Gender.FormattingEnabled = true;
            this.combo_Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.combo_Gender.Location = new System.Drawing.Point(508, 290);
            this.combo_Gender.Name = "combo_Gender";
            this.combo_Gender.Size = new System.Drawing.Size(239, 21);
            this.combo_Gender.TabIndex = 4;
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(2, 9);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(75, 23);
            this.Back_Button.TabIndex = 5;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Text_Studentpass
            // 
            this.Text_Studentpass.Location = new System.Drawing.Point(508, 351);
            this.Text_Studentpass.Name = "Text_Studentpass";
            this.Text_Studentpass.Size = new System.Drawing.Size(239, 20);
            this.Text_Studentpass.TabIndex = 6;
            this.Text_Studentpass.UseSystemPasswordChar = true;
            this.Text_Studentpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_Event);
            // 
            // Text_StudentConPass
            // 
            this.Text_StudentConPass.Location = new System.Drawing.Point(508, 377);
            this.Text_StudentConPass.Name = "Text_StudentConPass";
            this.Text_StudentConPass.Size = new System.Drawing.Size(239, 20);
            this.Text_StudentConPass.TabIndex = 6;
            this.Text_StudentConPass.UseSystemPasswordChar = true;
            this.Text_StudentConPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConfirmPassword_Event);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(408, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 1;
            this.label12.Text = "Address";
            // 
            // Text_Address
            // 
            this.Text_Address.Location = new System.Drawing.Point(508, 167);
            this.Text_Address.Name = "Text_Address";
            this.Text_Address.Size = new System.Drawing.Size(239, 20);
            this.Text_Address.TabIndex = 2;
            this.Text_Address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Address_Event);
            // 
            // Registration_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Text_StudentConPass);
            this.Controls.Add(this.Text_Studentpass);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.combo_Year);
            this.Controls.Add(this.combo_Month);
            this.Controls.Add(this.combo_Day);
            this.Controls.Add(this.combo_Gender);
            this.Controls.Add(this.combo_Program);
            this.Controls.Add(this.combo_Department);
            this.Controls.Add(this.Submit_button);
            this.Controls.Add(this.Text_StudentID);
            this.Controls.Add(this.Text_Address);
            this.Controls.Add(this.Text_Mother_Name);
            this.Controls.Add(this.Text_Father_Name);
            this.Controls.Add(this.Text_Student_Name);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Registration_form";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Text_Student_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Text_Father_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Text_Mother_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Text_StudentID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Submit_button;
        private System.Windows.Forms.ComboBox combo_Department;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox combo_Program;
        private System.Windows.Forms.ComboBox combo_Day;
        private System.Windows.Forms.ComboBox combo_Month;
        private System.Windows.Forms.ComboBox combo_Year;
        private System.Windows.Forms.ComboBox combo_Gender;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.TextBox Text_Studentpass;
        private System.Windows.Forms.TextBox Text_StudentConPass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Text_Address;
    }
}