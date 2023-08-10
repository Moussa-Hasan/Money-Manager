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
    public partial class DeleteIn : Form
    {
        public DeleteIn()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // Display the user name
            User loggedInUser = SessionManager.LoggedInUser;
            lblUsername.Text += loggedInUser.username;


            dgvExpenses.DataSource = DL_Expense.GetAllExpenses(loggedInUser.user_id);
            dgvExpenses.Columns["user_id"].Visible = false; 
            dgvExpenses.Columns["expense_id"].Visible = false;
            dgvExpenses.Columns["User"].Visible = false;

            dgvIncomes.DataSource = DL_Income.GetAllIncomes(loggedInUser.user_id);
            dgvIncomes.Columns["user_id"].Visible = false;
            dgvIncomes.Columns["income_id"].Visible = false;
            dgvIncomes.Columns["User"].Visible = false;

            // Calculate the total income and total expenses for the current user
            decimal totalIncome = DL_Income.GetTotalIncome(loggedInUser.user_id);
            decimal totalExpenses = DL_Expense.GetTotalExpense(loggedInUser.user_id);
            decimal totalAmount = totalIncome - totalExpenses;

            // Display the values in text boxes
            txtIncome.Text = totalIncome.ToString() + " $";
            txtExpense.Text = totalExpenses.ToString() + " $";
            txtAmount.Text = totalAmount.ToString() + " $";

        }

        private void dgvExpenses_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewColumn column = dgvExpenses.Columns[e.ColumnIndex];
            if (column.Name == "date" || column.Name == "category")
            {
                e.Cancel = true; // Cancel editing for the specified columns
            }
        }

        private void dgvIncomes_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewColumn column = dgvIncomes.Columns[e.ColumnIndex];
            if (column.Name == "date" || column.Name == "source")
            {
                e.Cancel = true; // Cancel editing for the specified columns
            }
        }

        private void deleteEx_Click(object sender, EventArgs e)
        {

            User loggedInUser = SessionManager.LoggedInUser;

            if (dgvExpenses.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvExpenses.SelectedRows[0];
                int expenseId = Convert.ToInt32(selectedRow.Cells["expense_id"].Value);

                // Confirm the deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this expense?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DL_Expense.DeleteExpense(expenseId);
                    refresh_form(loggedInUser);
                }
            }
        }

        private void deleteInc_Click(object sender, EventArgs e)
        {
            User loggedInUser = SessionManager.LoggedInUser;

            if (dgvIncomes.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvIncomes.SelectedRows[0];
                int incomeId = Convert.ToInt32(selectedRow.Cells["income_id"].Value);

                // Confirm the deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this income?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DL_Income.DeleteIncome(incomeId);
                    refresh_form(loggedInUser);
                }
            }

        }

        private void refresh_form(User loggedInUser)
        {
            // Calculate the total income and total expenses for the current user
            decimal totalIncome = DL_Income.GetTotalIncome(loggedInUser.user_id);
            decimal totalExpenses = DL_Expense.GetTotalExpense(loggedInUser.user_id);
            decimal totalAmount = totalIncome - totalExpenses;

            // Display the values in text boxes
            txtIncome.Text = totalIncome.ToString();
            txtExpense.Text = totalExpenses.ToString();
            txtAmount.Text = totalAmount.ToString();

            dgvExpenses.DataSource = DL_Expense.GetAllExpenses(loggedInUser.user_id);
            dgvIncomes.DataSource = DL_Income.GetAllIncomes(loggedInUser.user_id);
        }


        //unused
        private void btnSave_Click(object sender, EventArgs e)
        {
            User loggedInUser = SessionManager.LoggedInUser;

            if (dgvExpenses.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvExpenses.SelectedRows[0];
                int expenseId = Convert.ToInt32(selectedRow.Cells["expense_id"].Value);

                // Retrieve the updated values from the corresponding DataGridView cells
                string description = selectedRow.Cells["description"].Value.ToString();
                decimal amount = Convert.ToDecimal(selectedRow.Cells["amount"].Value);

                DL_Expense.UpdateExpense(expenseId, description, amount);

                dgvExpenses.DataSource = DL_Expense.GetAllExpenses(loggedInUser.user_id);

            }
        }

    }

    }





