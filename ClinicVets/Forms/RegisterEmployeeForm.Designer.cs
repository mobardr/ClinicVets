namespace ClinicVets.Forms
{
    partial class RegisterEmployeeForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtEmployeeId = new TextBox();
            txtEmail = new TextBox();
            txtIdNumber = new TextBox();
            cmbRole = new ComboBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 195);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(332, 277);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(332, 365);
            label3.Name = "label3";
            label3.Size = new Size(149, 32);
            label3.TabIndex = 2;
            label3.Text = "Employee ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(332, 451);
            label4.Name = "label4";
            label4.Size = new Size(71, 32);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(332, 537);
            label5.Name = "label5";
            label5.Size = new Size(132, 32);
            label5.TabIndex = 4;
            label5.Text = "ID Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(332, 622);
            label6.Name = "label6";
            label6.Size = new Size(60, 32);
            label6.TabIndex = 5;
            label6.Text = "Role";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(577, 195);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(191, 39);
            txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(577, 277);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(145, 39);
            txtPassword.TabIndex = 7;
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Location = new Point(577, 362);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(204, 39);
            txtEmployeeId.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(577, 444);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(176, 39);
            txtEmail.TabIndex = 9;
            // 
            // txtIdNumber
            // 
            txtIdNumber.Location = new Point(577, 537);
            txtIdNumber.Name = "txtIdNumber";
            txtIdNumber.Size = new Size(219, 39);
            txtIdNumber.TabIndex = 10;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(551, 626);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(148, 40);
            cmbRole.TabIndex = 11;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(332, 716);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(156, 62);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // RegisterEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1827, 970);
            Controls.Add(btnRegister);
            Controls.Add(cmbRole);
            Controls.Add(txtIdNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtEmployeeId);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterEmployeeForm";
            Text = "RegisterEmployeeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtEmployeeId;
        private TextBox txtEmail;
        private TextBox txtIdNumber;
        private ComboBox cmbRole;
        private Button btnRegister;
    }
}