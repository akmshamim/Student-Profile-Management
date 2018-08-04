namespace StudentProfile
{
    partial class Password_Change_Form
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
            this.text_OldPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_NewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_NewConPass = new System.Windows.Forms.TextBox();
            this.Back_Button = new System.Windows.Forms.Button();
            this.ChangePassword_Button = new System.Windows.Forms.Button();
            this.label_Student_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_OldPassword
            // 
            this.text_OldPassword.Location = new System.Drawing.Point(374, 159);
            this.text_OldPassword.Name = "text_OldPassword";
            this.text_OldPassword.Size = new System.Drawing.Size(196, 20);
            this.text_OldPassword.TabIndex = 5;
            this.text_OldPassword.UseSystemPasswordChar = true;
            this.text_OldPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Old_Password_Event);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(209, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Old Password";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(209, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Password";
            // 
            // text_NewPassword
            // 
            this.text_NewPassword.Location = new System.Drawing.Point(374, 197);
            this.text_NewPassword.Name = "text_NewPassword";
            this.text_NewPassword.Size = new System.Drawing.Size(196, 20);
            this.text_NewPassword.TabIndex = 5;
            this.text_NewPassword.UseSystemPasswordChar = true;
            this.text_NewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.New_Password_Event);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(209, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirm Password";
            // 
            // text_NewConPass
            // 
            this.text_NewConPass.Location = new System.Drawing.Point(374, 235);
            this.text_NewConPass.Name = "text_NewConPass";
            this.text_NewConPass.Size = new System.Drawing.Size(196, 20);
            this.text_NewConPass.TabIndex = 5;
            this.text_NewConPass.UseSystemPasswordChar = true;
            this.text_NewConPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Confirm_Password_Event);
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(28, 38);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(75, 23);
            this.Back_Button.TabIndex = 7;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // ChangePassword_Button
            // 
            this.ChangePassword_Button.Location = new System.Drawing.Point(391, 279);
            this.ChangePassword_Button.Name = "ChangePassword_Button";
            this.ChangePassword_Button.Size = new System.Drawing.Size(75, 23);
            this.ChangePassword_Button.TabIndex = 8;
            this.ChangePassword_Button.Text = "Save";
            this.ChangePassword_Button.UseVisualStyleBackColor = true;
            this.ChangePassword_Button.Click += new System.EventHandler(this.ChangePassword_Button_Click);
            // 
            // label_Student_ID
            // 
            this.label_Student_ID.AutoSize = true;
            this.label_Student_ID.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Student_ID.Location = new System.Drawing.Point(598, 38);
            this.label_Student_ID.Name = "label_Student_ID";
            this.label_Student_ID.Size = new System.Drawing.Size(0, 13);
            this.label_Student_ID.TabIndex = 9;
            // 
            // Password_Change_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Student_ID);
            this.Controls.Add(this.ChangePassword_Button);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.text_NewConPass);
            this.Controls.Add(this.text_NewPassword);
            this.Controls.Add(this.text_OldPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Password_Change_Form";
            this.Text = "Password Change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox text_OldPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_NewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_NewConPass;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button ChangePassword_Button;
        private System.Windows.Forms.Label label_Student_ID;
    }
}