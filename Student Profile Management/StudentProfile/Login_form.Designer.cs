namespace StudentProfile
{
    partial class Login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_form));
            this.label1 = new System.Windows.Forms.Label();
            this.text_StudentID = new System.Windows.Forms.TextBox();
            this.text_StudentPassword = new System.Windows.Forms.TextBox();
            this.Sign_In = new System.Windows.Forms.Button();
            this.Registration = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Back_Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(22, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // text_StudentID
            // 
            this.text_StudentID.Location = new System.Drawing.Point(128, 69);
            this.text_StudentID.Name = "text_StudentID";
            this.text_StudentID.Size = new System.Drawing.Size(196, 20);
            this.text_StudentID.TabIndex = 1;
            this.text_StudentID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Presskey_id);
            // 
            // text_StudentPassword
            // 
            this.text_StudentPassword.Location = new System.Drawing.Point(128, 113);
            this.text_StudentPassword.Name = "text_StudentPassword";
            this.text_StudentPassword.Size = new System.Drawing.Size(196, 20);
            this.text_StudentPassword.TabIndex = 1;
            this.text_StudentPassword.UseSystemPasswordChar = true;
            this.text_StudentPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Presskey_password);
            // 
            // Sign_In
            // 
            this.Sign_In.Location = new System.Drawing.Point(153, 158);
            this.Sign_In.Name = "Sign_In";
            this.Sign_In.Size = new System.Drawing.Size(75, 23);
            this.Sign_In.TabIndex = 2;
            this.Sign_In.Text = "Sign In";
            this.Sign_In.UseVisualStyleBackColor = true;
            this.Sign_In.Click += new System.EventHandler(this.Sign_In_Click);
            // 
            // Registration
            // 
            this.Registration.Location = new System.Drawing.Point(137, 194);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(114, 23);
            this.Registration.TabIndex = 2;
            this.Registration.Text = "Registration Here";
            this.Registration.UseVisualStyleBackColor = true;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(22, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Registration);
            this.panel1.Controls.Add(this.Sign_In);
            this.panel1.Controls.Add(this.text_StudentPassword);
            this.panel1.Controls.Add(this.text_StudentID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(456, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 267);
            this.panel1.TabIndex = 3;
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(12, 12);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(75, 23);
            this.Back_Button.TabIndex = 4;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.panel1);
            this.Name = "Login_form";
            this.Text = "Sign In / Registration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_StudentID;
        private System.Windows.Forms.TextBox text_StudentPassword;
        private System.Windows.Forms.Button Sign_In;
        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Back_Button;
    }
}