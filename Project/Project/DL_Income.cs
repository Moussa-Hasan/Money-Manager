using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class DL_Income
    {
        private static readonly DataClassesDataContext db = new DataClassesDataContext();

        public static void AddIncome(string description, decimal amount, string source)
        {
            int userId = SessionManager.LoggedInUser.user_id;
            Income income = new Income
            {
                user_id = userId,
                description = description,
                amount = amount,
                source = source,
                date = DateTime.Now
            };

            db.Incomes.InsertOnSubmit(income);
            db.SubmitChanges();
        }

        public static decimal GetTotalIncome(int userId)
        {
            decimal? totalIncome = db.Incomes.Where(i => i.user_id == userId).Sum(i => (decimal?)i.amount);
            return totalIncome ?? 0m; // Return totalIncome if it has a value, otherwise return 0
        }
 

        public static List<Income> GetAllIncomes(int userId)
        {
            return db.Incomes.Where(e => e.user_id == userId).ToList();
        }

        public static void UpdateIncome(int incomeId, string description, decimal amount)
        {
            Income income = db.Incomes.FirstOrDefault(i => i.income_id == incomeId);
            if (income != null)
            {
                income.description = description;
                income.amount = amount;
                db.SubmitChanges();
            }
        }

        public static void DeleteIncome(int incomeId)
        {
            Income income = db.Incomes.FirstOrDefault(i => i.income_id == incomeId);
            if (income != null)
            {
                db.Incomes.DeleteOnSubmit(income);
                db.SubmitChanges();
            }
        }

        public static decimal GetAverageMonthlyIncome(int userId)
        {
            decimal totalIncome = GetTotalIncome(userId);
            decimal months = DateTime.Today.Month; // Assuming current month as the reference
            return totalIncome / months;
        }

        public static decimal GetAverageDailyIncome(int userId)
        {
            decimal totalIncome = GetTotalIncome(userId);

            // Get the earliest and latest income dates for the user
            DateTime? earliestDate = db.Incomes.Where(i => i.user_id == userId).Min(i => (DateTime?)i.date);
            DateTime? latestDate = db.Incomes.Where(i => i.user_id == userId).Max(i => (DateTime?)i.date);

            if (earliestDate == null || latestDate == null)
            {
                // Return 0 if either the earliest or latest date is null
                return 0;
            }
            else
            {
                // Calculate the number of days between the earliest and latest income dates
                decimal days = (decimal)(latestDate.Value - earliestDate.Value).TotalDays + 1;

                // Calculate the average daily income
                decimal averageDailyIncome = totalIncome / days;

                return averageDailyIncome;
            }
        }

        public static List<Income> GetIncomesBySource(int userId, string source)
        {
            return db.Incomes.Where(i => i.user_id == userId && i.source == source).ToList();
        }

    }
}
