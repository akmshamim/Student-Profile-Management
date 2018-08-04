namespace StudentProfile
{
    partial class Admin_Login_From
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Login_From));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.text_AdminID = new System.Windows.Forms.TextBox();
            this.Admin_Login_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_AdminPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Back_Button = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(-1, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 209);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(-1, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 225);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.text_AdminID);
            this.panel3.Controls.Add(this.Admin_Login_Button);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.text_AdminPassword);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(412, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(470, 209);
            this.panel3.TabIndex = 0;
            // 
            // text_AdminID
            // 
            this.text_AdminID.Location = new System.Drawing.Point(163, 63);
            this.text_AdminID.Name = "text_AdminID";
            this.text_AdminID.Size = new System.Drawing.Size(196, 20);
            this.text_AdminID.TabIndex = 17;
            this.text_AdminID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.User_Name_Event);
            // 
            // Admin_Login_Button
            // 
            this.Admin_Login_Button.Location = new System.Drawing.Point(163, 147);
            this.Admin_Login_Button.Name = "Admin_Login_Button";
            this.Admin_Login_Button.Size = new System.Drawing.Size(75, 23);
            this.Admin_Login_Button.TabIndex = 16;
            this.Admin_Login_Button.Text = "Sign In";
            this.Admin_Login_Button.UseVisualStyleBackColor = true;
            this.Admin_Login_Button.Click += new System.EventHandler(this.Admin_Login_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(35, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "User Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_AdminPassword
            // 
            this.text_AdminPassword.Location = new System.Drawing.Point(163, 97);
            this.text_AdminPassword.Name = "text_AdminPassword";
            this.text_AdminPassword.Size = new System.Drawing.Size(196, 20);
            this.text_AdminPassword.TabIndex = 12;
            this.text_AdminPassword.UseSystemPasswordChar = true;
            this.text_AdminPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_Event);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(35, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(2, 2);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(75, 23);
            this.Back_Button.TabIndex = 15;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Admin_Login_From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Admin_Login_From";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_AdminPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Admin_Login_Button;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.TextBox text_AdminID;
    }
}