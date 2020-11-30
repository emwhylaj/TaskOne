using System;
using System.Collections.Generic;
using System.Text;

namespace TaskOne
{
    public class TheSunNewsPaper : NewsPaper
    {
        private List<TheSunNewsPaper> sunNewsPapers = new List<TheSunNewsPaper>();
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int Week { get; set; }
        public decimal Total { get; set; }

        public List<TheSunNewsPaper> getSunNewsPapers()
        {
            return sunNewsPapers = new List<TheSunNewsPaper>()
            {
                 new TheSunNewsPaper
            {
                  Id = 1,
                  Price = 420,
                  Quantity = 7,
                  Week = 1
                },
                new TheSunNewsPaper
                {
                  Id = 2,
                  Price = 400,
                  Quantity = 10,
                  Week = 2
                },
                new TheSunNewsPaper
                {
                    Id = 3,
                    Price = 450.24m,
                    Quantity = 13,
                    Week = 3
                },
                new TheSunNewsPaper
                {
                    Id = 4,
                    Price = 400,
                    Quantity = 8,
                    Week = 4
                }

            };
        }



        public List<TheSunNewsPaper> getSumTotalForEachWeekSun()
        {
            List<TheSunNewsPaper> sunPaperWithTotalForEachWeek = new List<TheSunNewsPaper>();
            foreach (var sunNews in getSunNewsPapers())
            {
                sunNews.Total = sunNews.Quantity * sunNews.Price;
                sunPaperWithTotalForEachWeek.Add(sunNews);
            }
            return sunPaperWithTotalForEachWeek;
        }
        public decimal getSumTotalForAllWeeksSun()
        {
            decimal sumTotalForAllWeeksSun = 0;
            foreach (var sunNews in getSumTotalForEachWeekSun())
            {
                sumTotalForAllWeeksSun = sumTotalForAllWeeksSun + sunNews.Total;
            }

            return sumTotalForAllWeeksSun;
        }

        public int getSunPaperCount()
        {
            return getSunNewsPapers().Count;
        }

        public decimal getAverageForSunNews()
        {
            var averageValue = getSumTotalForAllWeeksSun() / getSunPaperCount();
            return averageValue;
        }
    }

}
