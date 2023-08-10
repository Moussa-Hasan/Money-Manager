using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
        }

        private void btnAddEx_Click(object sender, EventArgs e)
        {
            User currentUser = SessionManager.LoggedInUser;

            // Validate inputs
            decimal amount;
            if (string.IsNullOrWhiteSpace(txtAmountEx.Text) || !decimal.TryParse(txtAmountEx.Text, out amount))
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            string source = cboSourceEx.Text.Trim();
            if (string.IsNullOrWhiteSpace(source))
            {
                MessageBox.Show("Please select a source.");
                return;
            }

            string description = txtDescriptionEx.Text;
            if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Please enter a description.");
                return;
            }

            // Add the expense using the DL_Expense class
            decimal totalIncome = DL_Income.GetTotalIncome(currentUser.user_id);
            decimal totalExpense = DL_Expense.GetTotalExpense(currentUser.user_id);
            decimal totalAmount = totalIncome - totalExpense;

            if (totalAmount >= amount)
            {
                DL_Expense.AddExpense(description, amount, source);
                MessageBox.Show("Expenses added successfully.");

            }

            else
                MessageBox.Show("Your current cash balance is " + totalAmount + "$, you cannot add expenses.");

            txtAmountEx.Text = string.Empty;
            txtDescriptionEx.Text = string.Empty;
            cboSourceEx.SelectedIndex = 0;
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            //set a default values for combo boxes
            cboSourceIn.SelectedIndex = 0;
            cboSourceEx.SelectedIndex = 0;
        }

        private void btnAddIn_Click_1(object sender, EventArgs e)
        {
            // Validate inputs
            decimal amount;
            if (string.IsNullOrWhiteSpace(txtAmountIn.Text) || !decimal.TryParse(txtAmountIn.Text, out amount))
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }
            string source = cboSourceIn.Text.Trim();
            if (string.IsNullOrWhiteSpace(source))
            {
                MessageBox.Show("Please select a source.");
                return;
            }
            string description = txtDescriptionIn.Text.Trim();
            if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Please enter a description.");
                return;
            }

            // Add the income using the DL_Income class
            DL_Income.AddIncome(description, amount, source);

            MessageBox.Show("Income added successfully.");

            txtAmountIn.Text = string.Empty;
            txtDescriptionIn.Text = string.Empty;
            cboSourceIn.SelectedIndex = 0;
        }
    }
}
