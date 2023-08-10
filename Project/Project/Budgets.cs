using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Project
{
    public partial class Budgets : Form
    {
        List<string> budgetTips = new List<string> {
            "Spend less on things you don't need",
            "Make a budget and track your spending",
            "Pay off high-interest debts",
            "Save on a regular basis",
            "Spend more with cash than credit cards",
            "Buy generic or in-season foods",
            "Cook more instead of eating out"
        };

        public Budgets()
        {
            InitializeComponent();
        }

        private void Budgets_Load(object sender, EventArgs e)
        {
            // Get the current session user
            User currentUser = SessionManager.LoggedInUser;
            txtTip.Text = budgetTips[0];

            // Get category percentages 
            Dictionary<string, decimal> percentages =
                DL_Expense.GetCategoryPercentages(currentUser.user_id);

            foreach (KeyValuePair<string, decimal> item in percentages)
            {
                string categoryName = item.Key;
                decimal percentage = item.Value;

                lstPerc.Items.Add(categoryName + ": " + percentage.ToString("0.00") + "%");             
                cboSourceEx.Items.Add(categoryName);

            }


            // Get the average monthly expense of the user
            decimal average = DL_Expense.GetAverageMonthlyExpense(currentUser.user_id);
            lblAverage.Text = average.ToString("0.00") + " $";

            // Get the average monthly income of the user
            decimal avgMonthlyIncome = DL_Income.GetAverageMonthlyIncome(currentUser.user_id);
            lblAvgMonthlyIncome.Text = avgMonthlyIncome.ToString("0.00") + " $";

            // Get the average daily expense of the user
            decimal avgDailyExpense = DL_Expense.GetAverageDailyExpense(currentUser.user_id);
            lblAvgDailyExpense.Text = avgDailyExpense.ToString("0.00") + " $";

            // Get the average daily income of the user
            decimal avgDailyIncome = DL_Income.GetAverageDailyIncome(currentUser.user_id);
            lblAvgDailyIncome.Text = avgDailyIncome.ToString("0.00") + " $";

            // Calculate the total income and total expenses for the current user
            decimal totalIncome = DL_Income.GetTotalIncome(currentUser.user_id);
            decimal totalExpenses = DL_Expense.GetTotalExpense(currentUser.user_id);
            decimal totalAmount = totalIncome - totalExpenses;

            // Display the values in text boxes
            txtIncome.Text = totalIncome.ToString() + " $";
            txtExpense.Text = totalExpenses.ToString() + " $";
            txtAmount.Text = totalAmount.ToString() + " $";
        }

        private void cboSourceEx_SelectedIndexChanged(object sender, EventArgs e)
        {
            int userId = SessionManager.LoggedInUser.user_id;

            string category = cboSourceEx.Text;

            List<Expense> expenses = DL_Expense.GetExpensesByCategory(userId, category);

            lstCategories.Items.Clear();

            // Add individual expenses    
            foreach (Expense expense in expenses)
            {
                lstCategories.Items.Add("\nAmount: " + expense.amount + " $ | \nDescription: " +
                  expense.description);
            }
        }

        private void btnTip_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomIndex = random.Next(budgetTips.Count);
            txtTip.Text = budgetTips[randomIndex];
        }

    }
    }
