using System;
using System.Collections.Generic;
using System.Text;

namespace TaskOne
{
    public  class GuardianNewsPaper : NewsPaper
    {
        private List<GuardianNewsPaper> guardianNewsPaper = new List<GuardianNewsPaper>();
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int Week { get; set; }
        public decimal Total { get; set; }

        public List<GuardianNewsPaper> getGuardianNewsPaper()
        {
            return guardianNewsPaper = new List<GuardianNewsPaper>()
            {
                new GuardianNewsPaper
                {
                  Id = 1,
                  Price = 324.56m,
                  Quantity = 10,
                  Week = 1
                },
                 new GuardianNewsPaper
                {
                  Id = 2,
                  Price = 300,
                  Quantity = 32,
                  Week = 2
                },
                new GuardianNewsPaper
                 {
                  Id = 3,
                  Price = 315.28m,
                  Quantity = 27,
                  Week = 3
                 },
                new GuardianNewsPaper
                 {
                  Id = 4,
                  Price = 340,
                  Quantity = 21,
                  Week = 4
                }
            };
        }

        public List<GuardianNewsPaper> getSumTotalGuarForEachWeek()
        {
            List<GuardianNewsPaper> guardianPaperWithTotalForEachWeek = new List<GuardianNewsPaper>();
            foreach (var guardianNews in getGuardianNewsPaper())
            {
                guardianNews.Total = guardianNews.Quantity * guardianNews.Price;
                guardianPaperWithTotalForEachWeek.Add(guardianNews);
            }
            return guardianPaperWithTotalForEachWeek;
        }
        public decimal getSumTotalForAllWeeksGuardian()
        {
            decimal sumTotalForAllWeeksGuardian = 0;
            foreach (var guardianNews in getSumTotalGuarForEachWeek())
            {
                sumTotalForAllWeeksGuardian = sumTotalForAllWeeksGuardian + guardianNews.Total;
            }

            return sumTotalForAllWeeksGuardian;
        }

        public int getGuardianPaperCount()
        {
            return getGuardianNewsPaper().Count;
        }

        public decimal getAverageForGuardian()
        {
            var averageValue = getSumTotalForAllWeeksGuardian() / getGuardianPaperCount();
            return averageValue;
        }

    }
}
