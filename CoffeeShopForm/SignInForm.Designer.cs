namespace CoffeeShopForm
{
    partial class SignInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSignIn = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogIn = new Button();
            btnRegister = new Button();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label4 = new Label();
            btnGuest = new Button();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.Font = new Font("Yu Gothic Medium", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignIn.ForeColor = Color.FromArgb(218, 216, 227);
            lblSignIn.Location = new Point(389, 72);
            lblSignIn.Margin = new Padding(4, 0, 4, 0);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(131, 43);
            lblSignIn.TabIndex = 0;
            lblSignIn.Text = "Sign In";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(57, 53, 76);
            txtEmail.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = SystemColors.Control;
            txtEmail.Location = new Point(389, 144);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = " Email";
            txtEmail.Size = new Size(274, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = Color.FromArgb(57, 53, 76);
            txtPassword.Font = new Font("Microsoft Sans Serif", 12.75F);
            txtPassword.ForeColor = SystemColors.Control;
            txtPassword.HideSelection = false;
            txtPassword.Location = new Point(389, 198);
            txtPassword.Margin = new Padding(100, 10, 5, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = " Password";
            txtPassword.Size = new Size(274, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.FromArgb(117, 82, 186);
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Constantia", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogIn.ForeColor = Color.FromArgb(218, 216, 227);
            btnLogIn.Location = new Point(431, 258);
            btnLogIn.Margin = new Padding(4, 3, 4, 3);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(178, 33);
            btnLogIn.TabIndex = 5;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLoginEvet;
            // 
            // btnRegister
            // 
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Constantia", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.FromArgb(218, 216, 227);
            btnRegister.Location = new Point(553, 306);
            btnRegister.Margin = new Padding(0);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(60, 23);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegisterEvent;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 10F);
            label2.Location = new Point(128, 92);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 17);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 10F);
            label3.Location = new Point(102, 143);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.intro1;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(13, 17);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(351, 418);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 9F);
            label1.ForeColor = Color.FromArgb(218, 216, 227);
            label1.Location = new Point(431, 310);
            label1.Name = "label1";
            label1.Size = new Size(129, 14);
            label1.TabIndex = 8;
            label1.Text = "Dont have an Account?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(218, 216, 227);
            label4.Location = new Point(431, 329);
            label4.Name = "label4";
            label4.Size = new Size(192, 15);
            label4.TabIndex = 9;
            label4.Text = "——————— or ———————";
            // 
            // btnGuest
            // 
            btnGuest.FlatAppearance.BorderSize = 0;
            btnGuest.FlatStyle = FlatStyle.Flat;
            btnGuest.Font = new Font("Constantia", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnGuest.ForeColor = Color.DarkGray;
            btnGuest.Location = new Point(467, 348);
            btnGuest.Margin = new Padding(0);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(114, 23);
            btnGuest.TabIndex = 10;
            btnGuest.Text = "Continue as Guest";
            btnGuest.UseVisualStyleBackColor = true;
            btnGuest.Click += btnGuestEvent;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(420, 420);
            label6.Name = "label6";
            label6.Size = new Size(213, 15);
            label6.TabIndex = 12;
            label6.Text = "\"Fueling Moments, One Cup at a Time.\"";
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 42, 56);
            ClientSize = new Size(691, 456);
            Controls.Add(label6);
            Controls.Add(btnGuest);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnRegister);
            Controls.Add(btnLogIn);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblSignIn);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ImeMode = ImeMode.On;
            Margin = new Padding(4, 3, 4, 3);
            Name = "SignInForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = " ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        protected void btnLoginEvet(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (txtEmail.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("ERROR: Enter your Email and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CoffeeShop.userProcess.ValidateAdmin(email, password))
            {
                this.Hide();
                new AdminDashBoard().ShowDialog();
                this.Close();
            }
            else if (CoffeeShop.userProcess.ValidateUser(email, password))
            {
                this.Hide();
                new OrderingInterface(CoffeeShop.userProcess.GetUserID(email)).ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("ERROR: Wrong Email or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Clear();
                txtPassword.Clear();
            }
        }

        protected void btnRegisterEvent(object sender, EventArgs e)
        {
            this.Hide();
            new RegistrationForm().ShowDialog();
            this.Close();
        }

        protected void btnGuestEvent(object sender, EventArgs e)
        {
            this.Hide();
            new OrderingInterface(0).ShowDialog();
            this.Close();
        }


        #endregion

        private Label lblSignIn;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogIn;
        private Button btnRegister;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label1;
        private Label label4;
        private Button btnGuest;
        private Label label6;
    }
}
