namespace ClinicVets.Forms
{
    partial class CustomerForm
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
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtIdNumber = new TextBox();
            btnRegisterCustomer = new Button();
            btnSearchCustomer = new Button();
            txtSearch = new TextBox();
            dgvCustomers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 60);
            label1.Name = "label1";
            label1.Size = new Size(123, 32);
            label1.TabIndex = 0;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 136);
            label2.Name = "label2";
            label2.Size = new Size(132, 32);
            label2.TabIndex = 1;
            label2.Text = "ID Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 198);
            label3.Name = "label3";
            label3.Size = new Size(82, 32);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 276);
            label4.Name = "label4";
            label4.Size = new Size(71, 32);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(400, 60);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(152, 39);
            txtFullName.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(400, 269);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(284, 39);
            txtEmail.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(400, 198);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(152, 39);
            txtPhone.TabIndex = 6;
            // 
            // txtIdNumber
            // 
            txtIdNumber.Location = new Point(400, 133);
            txtIdNumber.Name = "txtIdNumber";
            txtIdNumber.Size = new Size(152, 39);
            txtIdNumber.TabIndex = 7;
            // 
            // btnRegisterCustomer
            // 
            btnRegisterCustomer.Location = new Point(277, 378);
            btnRegisterCustomer.Name = "btnRegisterCustomer";
            btnRegisterCustomer.Size = new Size(197, 51);
            btnRegisterCustomer.TabIndex = 8;
            btnRegisterCustomer.Text = "Register";
            btnRegisterCustomer.UseVisualStyleBackColor = true;
            btnRegisterCustomer.Click += btnRegisterCustomer_Click;
            // 
            // btnSearchCustomer
            // 
            btnSearchCustomer.Location = new Point(1380, 60);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.Size = new Size(178, 64);
            btnSearchCustomer.TabIndex = 9;
            btnSearchCustomer.Text = "Search";
            btnSearchCustomer.UseVisualStyleBackColor = true;
            btnSearchCustomer.Click += btnSearchCustomer_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1011, 66);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(316, 58);
            txtSearch.TabIndex = 10;
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(1011, 276);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 82;
            dgvCustomers.Size = new Size(480, 300);
            dgvCustomers.TabIndex = 11;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1871, 932);
            Controls.Add(dgvCustomers);
            Controls.Add(txtSearch);
            Controls.Add(btnSearchCustomer);
            Controls.Add(btnRegisterCustomer);
            Controls.Add(txtIdNumber);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CustomerForm";
            Text = "CustomerForm";
            Load += CustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtIdNumber;
        private Button btnRegisterCustomer;
        private Button btnSearchCustomer;
        private TextBox txtSearch;
        private DataGridView dgvCustomers;
    }
}