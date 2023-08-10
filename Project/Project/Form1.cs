using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Project
{

    public partial class Form1 : Form
    {
        private Login loginForm;

        private Form currentForm;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        public Form1()
        {
            InitializeComponent();
            panelSlider.Height = btnHome.Height;
            panelSlider.Top = btnHome.Top;
            homePanel.Visible = true;

            // Create an instance of the login form
            loginForm = new Login();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelSlider.Height = btnHome.Height;
            panelSlider.Top = btnHome.Top;

            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }

            //Display the homeForm inside the panel
            DeleteIn homeForm = new DeleteIn();
            homeForm.TopLevel = false; 
            homePanel.Controls.Clear();
            homePanel.Controls.Add(homeForm);
            homeForm.Show();

            currentForm = homeForm;
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            panelSlider.Height = btnTransactions.Height;
            panelSlider.Top = btnTransactions.Top;

            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }

            //Display the transactionsForm inside the panel
            Transactions transactionsForm = new Transactions();
            transactionsForm.TopLevel = false;
            homePanel.Controls.Clear();
            homePanel.Controls.Add(transactionsForm);
            transactionsForm.Show();

            currentForm = transactionsForm;
        }

        private void btnBudget_Click(object sender, EventArgs e)
        {
            panelSlider.Height = btnBudget.Height;
            panelSlider.Top = btnBudget.Top;

            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }

            //Display the budgetForm inside the panel
            Budgets budgetForm = new Budgets();
            budgetForm.TopLevel = false;
            homePanel.Controls.Clear();
            homePanel.Controls.Add(budgetForm);
            budgetForm.Show();

            currentForm = budgetForm;
        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Display a confirmation message box
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                panelSlider.Height = btnLogout.Height;
                panelSlider.Top = btnLogout.Top;

                // Close the previously opened form
                if (currentForm != null)
                {
                    currentForm.Close();
                    currentForm.Dispose();
                }

                // Show the login form
                loginForm.Show();

                // Close Form1
                this.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }

            //Display the homeForm inside the panel (initially)
            DeleteIn homeForm = new DeleteIn();
            homeForm.TopLevel = false;
            homePanel.Controls.Clear();
            homePanel.Controls.Add(homeForm);
            homeForm.Show();

            currentForm = homeForm;

        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }

            Application.Exit();
        }

        private void iconRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconMax.Visible = true;
            iconRestore.Visible = false;
        }

        private void iconMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconMax.Visible = false;
            iconRestore.Visible = true;
        }

        private void iconMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}
