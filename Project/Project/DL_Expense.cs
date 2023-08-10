using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class DL_Expense
    {
        private static readonly DataClassesDataContext db = new DataClassesDataContext();

        public static void AddExpense(string description, decimal amount, string category)
        {
            int userId = SessionManager.LoggedInUser.user_id;
            Expense expense = new Expense
            {
                user_id = userId,
                description = description,
                amount = amount,
                category = category,
                date = DateTime.Now
            };

            db.Expenses.InsertOnSubmit(expense);
            db.SubmitChanges();
        }

        public static decimal GetTotalExpense(int userId)
        {
            decimal? totalExpense = db.Expenses.Where(e => e.user_id == userId).Sum(e => (decimal?)e.amount);
            return totalExpense ?? 0m; // Return totalExpense if it has a value, otherwise return 0
        }


        public static List<Expense> GetAllExpenses(int userId)
        {
            return db.Expenses.Where(e => e.user_id == userId).ToList();
        }

        public static void UpdateExpense(int expenseId, string description, decimal amount)
        {
            Expense expense = db.Expenses.FirstOrDefault(e => e.expense_id == expenseId);
            if (expense != null)
            {
                expense.description = description;
                expense.amount = amount;
                db.SubmitChanges();
            }
        }

        public static void DeleteExpense(int expenseId)
        {
            Expense expense = db.Expenses.FirstOrDefault(e => e.expense_id == expenseId);
            if (expense != null)
            {
                db.Expenses.DeleteOnSubmit(expense);
                db.SubmitChanges();
            }
        }

        public static decimal GetAverageMonthlyExpense(int userId)
        {
            decimal totalExpense = GetTotalExpense(userId);
            decimal months = DateTime.Today.Month; // Assuming current month as the reference
            return totalExpense / months;
        }

        public static decimal GetAverageDailyExpense(int userId)
        {
            decimal totalExpense = GetTotalExpense(userId);

            // Get the earliest and latest expense dates for the user
            DateTime? earliestDate = db.Expenses.Where(e => e.user_id == userId).Min(e => (DateTime?)e.date);
            DateTime? latestDate = db.Expenses.Where(e => e.user_id == userId).Max(e => (DateTime?)e.date);

            if (earliestDate == null || latestDate == null)
            {
                // Return 0 if either the earliest or latest date is null
                return 0;
            }
            else
            {
                // Calculate the number of days between the earliest and latest expense dates
                decimal days = (decimal)(latestDate.Value - earliestDate.Value).TotalDays + 1;

                // Calculate the average daily expense
                decimal averageDailyExpense = totalExpense / days;

                return averageDailyExpense;
            }
        }

        public static List<Expense> GetExpensesByCategory(int userId, string category)
        {
            return db.Expenses.Where(e => e.user_id == userId && e.category == category).ToList();
        }

        public static Dictionary<string, decimal> GetCategoryPercentages(int userId)
        {
            var expenses = GetAllExpenses(userId);

            var groupedExpenses = expenses
                .GroupBy(e => e.category)
                .Select(g => new
                {
                    Category = g.Key,
                    Total = g.Sum(e => e.amount)
                });

            decimal grandTotal = (decimal)groupedExpenses.Sum(g => g.Total);

            Dictionary<string, decimal> percentages = new Dictionary<string, decimal>();

            foreach (var category in groupedExpenses)
            {
                decimal percentage = (decimal)((category.Total / grandTotal) * 100);
                percentages.Add(category.Category, percentage);
            }

            return percentages;
        }

    }
}
