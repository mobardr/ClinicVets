using ClinicVets.Data;
using ClinicVets.Forms;
using System.Drawing;
using System.Linq;

namespace ClinicVets
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            // Form Design
            this.Text = "ClinicVets - Login";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.WhiteSmoke;
            this.Size = new Size(800, 500);

            // Password hidden
            txtPassword.PasswordChar = '*';

            // Button Design
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Width = 200;
            btnLogin.Height = 45;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var employee = AppData.Employees.FirstOrDefault
            (
                e => e.Username == username &&
                     e.Password == password
            );

            if (employee != null)
            {
                CustomerForm customerForm = new CustomerForm();
                customerForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}