using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicVets.Models;
using ClinicVets.Data;
using System.Text.RegularExpressions;
using System.Linq;
namespace ClinicVets.Forms

{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void btnRegisterCustomer_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;
            string idNumber = txtIdNumber.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;

            // Full name validation
            if (!fullName.All(c => char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Full name must contain letters only");
                return;
            }

            // ID validation
            if (!Regex.IsMatch(idNumber, @"^\d{9}$"))
            {
                MessageBox.Show("ID Number must be 9 digits");
                return;
            }

            // Phone validation
            if (!Regex.IsMatch(phone, @"^\d{10}$"))
            {
                MessageBox.Show("Phone number must be 10 digits");
                return;
            }

            // Email validation
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email");
                return;
            }

            Customer customer = new Customer();

            customer.FullName = fullName;
            customer.IdNumber = idNumber;
            customer.Phone = phone;
            customer.Email = email;

            AppData.Customers.Add(customer);
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = AppData.Customers;

            MessageBox.Show("Customer Registered Successfully!");
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;

            var customer = AppData.Customers.FirstOrDefault
            (
                c => c.IdNumber == search ||
                     c.Phone == search
            );

            if (customer != null)
            {
                MessageBox.Show
                (
                    "Name: " + customer.FullName +
                    "\nPhone: " + customer.Phone +
                    "\nEmail: " + customer.Email
                );
            }
            else
            {
                MessageBox.Show("Customer not found");
            }
        }


       
    }
}
