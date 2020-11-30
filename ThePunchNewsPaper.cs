using System;
using System.Collections.Generic;
using System.Text;

namespace TaskOne
{
    public class ThePunchNewsPaper:NewsPaper
    {
        private List<ThePunchNewsPaper> punchNewsPapers = new List<ThePunchNewsPaper>();
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int Week { get; set; }
        public decimal Total { get; set; }

        public List<ThePunchNewsPaper> getPunchNewsPapers()
        {
            return punchNewsPapers = new List<ThePunchNewsPaper>() {

            new ThePunchNewsPaper              {
                  Id = 1,
                  Price = 245.35m,
                  Quantity = 12,
                  Week = 1
                },
                new ThePunchNewsPaper
                {
                  Id = 2,
                  Price = 220,
                  Quantity = 20,
                  Week = 2
                },
                new ThePunchNewsPaper
                {
                    Id = 3,
                    Price = 265.5m,
                    Quantity = 35,
                    Week = 3
                },
                new ThePunchNewsPaper
                {
                    Id = 4,
                    Price = 290.14m,
                    Quantity = 19,
                    Week = 4
                }
            };
        }


        public List<ThePunchNewsPaper> getSumTotalForEachWeekPunch()
        {
            List<ThePunchNewsPaper> punchPaperWithTotalForEachWeek = new List<ThePunchNewsPaper>();
            foreach (var punchNews in getPunchNewsPapers())
            {
                punchNews.Total = punchNews.Quantity * punchNews.Price;
                punchPaperWithTotalForEachWeek.Add(punchNews);
            }
            return punchPaperWithTotalForEachWeek;
        }
        public decimal getSumTotalForAllWeeksPunch()
        {
            decimal sumTotalForAllWeeksPunch = 0;
            foreach (var pmNews in getSumTotalForEachWeekPunch())
            {
                sumTotalForAllWeeksPunch = sumTotalForAllWeeksPunch + pmNews.Total;
            }

            return sumTotalForAllWeeksPunch;
        }

        public int getPunchPaperCount()
        {
            return getPunchNewsPapers().Count;
        }

        public decimal getAverageForPunchNews()
        {
            var averageValue = getSumTotalForAllWeeksPunch() / getPunchPaperCount();
            return averageValue;
        }

    }
}
