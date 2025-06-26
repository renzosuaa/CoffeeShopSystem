namespace CoffeeShopForm
{
    partial class RegistrationForm
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
            lblSignUp = new Label();
            lblEmail = new Label();
            lblPassword1 = new Label();
            lblPassword2 = new Label();
            txtEmail = new TextBox();
            txtPassword1 = new TextBox();
            txtPassword2 = new TextBox();
            btnRegister = new Button();
            btnSignIn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Font = new Font("Constantia", 30F);
            lblSignUp.ForeColor = Color.FromArgb(218, 216, 227);
            lblSignUp.Location = new Point(184, 67);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(325, 49);
            lblSignUp.TabIndex = 0;
            lblSignUp.Text = "Create an account";
            lblSignUp.Click += label1_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Constantia", 12.75F);
            lblEmail.ForeColor = Color.FromArgb(218, 216, 227);
            lblEmail.Location = new Point(138, 151);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 21);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // lblPassword1
            // 
            lblPassword1.AutoSize = true;
            lblPassword1.Font = new Font("Constantia", 12.75F);
            lblPassword1.ForeColor = Color.FromArgb(218, 216, 227);
            lblPassword1.Location = new Point(112, 199);
            lblPassword1.Name = "lblPassword1";
            lblPassword1.Size = new Size(80, 21);
            lblPassword1.TabIndex = 2;
            lblPassword1.Text = "Password";
            // 
            // lblPassword2
            // 
            lblPassword2.AutoSize = true;
            lblPassword2.Font = new Font("Constantia", 12.75F);
            lblPassword2.ForeColor = Color.FromArgb(218, 216, 227);
            lblPassword2.Location = new Point(47, 247);
            lblPassword2.Name = "lblPassword2";
            lblPassword2.Size = new Size(146, 21);
            lblPassword2.TabIndex = 3;
            lblPassword2.Text = "Confirm Password";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(57, 53, 76);
            txtEmail.Font = new Font("Constantia", 12.75F);
            txtEmail.ForeColor = Color.FromArgb(86, 82, 105);
            txtEmail.Location = new Point(199, 151);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(289, 28);
            txtEmail.TabIndex = 4;
            // 
            // txtPassword1
            // 
            txtPassword1.BackColor = Color.FromArgb(57, 53, 76);
            txtPassword1.Font = new Font("Constantia", 12.75F);
            txtPassword1.ForeColor = Color.FromArgb(86, 82, 105);
            txtPassword1.Location = new Point(199, 199);
            txtPassword1.Name = "txtPassword1";
            txtPassword1.Size = new Size(355, 28);
            txtPassword1.TabIndex = 5;
            // 
            // txtPassword2
            // 
            txtPassword2.BackColor = Color.FromArgb(57, 53, 76);
            txtPassword2.Font = new Font("Constantia", 12.75F);
            txtPassword2.ForeColor = Color.FromArgb(86, 82, 105);
            txtPassword2.Location = new Point(199, 245);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.Size = new Size(355, 28);
            txtPassword2.TabIndex = 6;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(117, 82, 186);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Constantia", 12.75F);
            btnRegister.ForeColor = Color.FromArgb(218, 216, 227);
            btnRegister.Location = new Point(274, 315);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(148, 38);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegisterEvent;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(44, 42, 56);
            btnSignIn.BackgroundImageLayout = ImageLayout.None;
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Constantia", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.FromArgb(218, 216, 227);
            btnSignIn.Location = new Point(387, 370);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(54, 23);
            btnSignIn.TabIndex = 8;
            btnSignIn.Text = "Log in";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignInEvent;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 9F);
            label1.ForeColor = Color.FromArgb(218, 216, 227);
            label1.Location = new Point(255, 375);
            label1.Name = "label1";
            label1.Size = new Size(142, 14);
            label1.TabIndex = 10;
            label1.Text = "Already have an account?";
            label1.Click += label1_Click_1;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 42, 56);
            ClientSize = new Size(691, 456);
            Controls.Add(label1);
            Controls.Add(btnSignIn);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword2);
            Controls.Add(txtPassword1);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword2);
            Controls.Add(lblPassword1);
            Controls.Add(lblEmail);
            Controls.Add(lblSignUp);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            Load += RegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        protected void btnRegisterEvent(object sender, EventArgs e)
        {
            if (txtEmail.Text == string.Empty || txtPassword1.Text == string.Empty || txtPassword2.Text == string.Empty)
            {
                MessageBox.Show("ERROR: Enter All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtPassword1.Text != txtPassword2.Text)
            {
                MessageBox.Show("ERROR: Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CoffeeShop.userProcess.RegisterUser(txtEmail.Text, txtPassword1.Text);
            MessageBox.Show("Successful: Account Created!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new SignInForm().Show();
            this.Dispose();
        }

        protected void btnSignInEvent(object sender, EventArgs e)
        {
            this.Hide();
            new SignInForm().ShowDialog();
            this.Close();
        }

        #endregion

        private Label lblSignUp;
        private Label lblEmail;
        private Label lblPassword1;
        private Label lblPassword2;
        private TextBox txtEmail;
        private TextBox txtPassword1;
        private TextBox txtPassword2;
        private Button btnRegister;
        private Button btnSignIn;
        private Label label1;
    }
}