using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ClinicVets.Models;
using ClinicVets.Data;
using System.Drawing;
namespace ClinicVets.Forms
{
    public partial class RegisterEmployeeForm : Form
    {
        public RegisterEmployeeForm()
        {
            InitializeComponent();

            cmbRole.Items.Add("Veterinarian");
            cmbRole.Items.Add("Secretary");

            txtPassword.PasswordChar = '*';
            this.Text = "ClinicVets - Register";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.WhiteSmoke;
            this.Size = new Size(800, 600);

            // Button Design
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Width = 200;
            btnRegister.Height = 45;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string employeeId = txtEmployeeId.Text;
            string email = txtEmail.Text;
            string idNumber = txtIdNumber.Text;

            // Username validation
            if (username.Length < 6 || username.Length > 8)
            {
                MessageBox.Show("Username must be 6-8 characters");
                return;
            }

            int digitCount = username.Count(char.IsDigit);

            if (digitCount > 2)
            {
                MessageBox.Show("Username can contain maximum 2 digits");
                return;
            }

            if (!username.All(c => char.IsLetter(c) || char.IsDigit(c)))
            {
                MessageBox.Show("Username must contain only letters and digits");
                return;
            }

            // Password validation
            bool validPassword =
                password.Length >= 8 &&
                password.Length <= 10 &&
                password.Any(char.IsLetter) &&
                password.Any(char.IsDigit) &&
                password.Any(ch => "!@#$".Contains(ch));

            if (!validPassword)
            {
                MessageBox.Show("Invalid password");
                return;
            }

            // Employee ID validation
            if (!Regex.IsMatch(employeeId, @"^\d{4}$"))
            {
                MessageBox.Show("Employee ID must be exactly 4 digits");
                return;
            }

            // Email validation
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format");
                return;
            }

            // ID Number validation
            if (!Regex.IsMatch(idNumber, @"^\d{9}$"))
            {
                MessageBox.Show("ID Number must be exactly 9 digits");
                return;
            }

            // Role validation
            if (cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a role");
                return;
            }
            Employee employee = new Employee();

            employee.Username = username;
            employee.Password = password;

            AppData.Employees.Add(employee);

            MessageBox.Show("Employee Registered Successfully!");

            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            this.Hide();
        }
    }
}