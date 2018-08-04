namespace StudentProfile
{
    partial class main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.label1 = new System.Windows.Forms.Label();
            this.SignInOrRegistration = new System.Windows.Forms.Button();
            this.Manage_form = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(83, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(618, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Profile Information";
            // 
            // SignInOrRegistration
            // 
            this.SignInOrRegistration.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SignInOrRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInOrRegistration.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SignInOrRegistration.Location = new System.Drawing.Point(69, 357);
            this.SignInOrRegistration.Name = "SignInOrRegistration";
            this.SignInOrRegistration.Size = new System.Drawing.Size(204, 62);
            this.SignInOrRegistration.TabIndex = 1;
            this.SignInOrRegistration.Text = "Sign In/Registration ( Only For Student )";
            this.SignInOrRegistration.UseVisualStyleBackColor = false;
            this.SignInOrRegistration.Click += new System.EventHandler(this.SignInOrRegistration_Click);
            // 
            // Manage_form
            // 
            this.Manage_form.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Manage_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage_form.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Manage_form.Location = new System.Drawing.Point(395, 357);
            this.Manage_form.Name = "Manage_form";
            this.Manage_form.Size = new System.Drawing.Size(338, 62);
            this.Manage_form.TabIndex = 1;
            this.Manage_form.Text = "    Manage Result/Everything        ( Only For Application Controller )";
            this.Manage_form.UseVisualStyleBackColor = false;
            this.Manage_form.Click += new System.EventHandler(this.Manage_form_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Manage_form);
            this.Controls.Add(this.SignInOrRegistration);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Profile";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SignInOrRegistration;
        private System.Windows.Forms.Button Manage_form;
    }
}

