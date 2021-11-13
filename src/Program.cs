using System;

using System.Collections.Generic;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Budget
    {
        public string YearMonth { get; set; }
        public int Amount { get; set; }
    }

    public class BudgetService
    {
        private IBudgetRepo _repo;
        public BudgetService(IBudgetRepo repo)
        {
            _repo = repo;
        }

        public decimal Query(DateTime start, DateTime end)
        {
            return 0;
        }
    }

    public interface IBudgetRepo
    {
        List<Budget> GetAll();
    }
}
