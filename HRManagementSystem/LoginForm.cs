using HRManagementSystem.Helpers;
using HRManagementSystem.Services;
using HRManagementSystem.Forms;

namespace HRManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show(
                    "Please enter your username.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter your password.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Focus();
                return;
            }

            try
            {
                var authenticationService = new AuthenticationService();

                var user = authenticationService.Login(
                    username,
                    password);

                if (user == null)
                {
                    MessageBox.Show(
                        "Invalid username or password.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    txtPassword.Clear();
                    txtPassword.Focus();

                    return;
                }

                Session.Login(user);

                Hide();

                var dashboard = new DashboardForm();

                //dashboard.FormClosed += (s, args) => Close();

                dashboard.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred while logging in.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
