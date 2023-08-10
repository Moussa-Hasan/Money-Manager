using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Login : Form
    {

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        public Login()
        {
            InitializeComponent();
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                // Validate the credentials using the DL_User class
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password)) {

                    if (DL_User.ValidateCredentials(username, password))
                    {
                        // Login successful
                        Form1 mainForm = new Form1();
                        mainForm.Show();

                        this.Hide();
                    }
                    else
                    {
                        // Login failed
                        lblRegistrationMessage.Text = "Invalid username or password. Please try again.";
                        lblRegistrationMessage.ForeColor = Color.Red;
                    }
                }

                else
                {
                    lblRegistrationMessage.Text = "Please enter a username and password.";
                    lblRegistrationMessage.ForeColor = Color.Red;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void chbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPass.Checked)
            {
                // Show the password
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                // Hide the password
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnRegiter_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Check if the username and password are valid 
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                // Check if the username already exists
                if (DL_User.IsUsernameTaken(username))
                {
                    // Username already exists
                    lblRegistrationMessage.Text = "Username already exists. Please choose a different username.";
                    lblRegistrationMessage.ForeColor = Color.Red;
                }
                else
                {
                    // Create a new user in the database using the DL_User class
                    DL_User.Add(username, password);
                    lblRegistrationMessage.Text = "Registration successful. Just press the login button.";
                    lblRegistrationMessage.ForeColor = Color.Green;
                }
            }
            else
            {
                lblRegistrationMessage.Text = "Please enter a username and password.";
                lblRegistrationMessage.ForeColor = Color.Red;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
