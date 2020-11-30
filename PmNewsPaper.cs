using System;
using System.Collections.Generic;
using System.Text;

namespace TaskOne
{
    public class PmNewsPaper : NewsPaper
    {
        private List<PmNewsPaper> pmNewsPapers = new List<PmNewsPaper>();

        public int Id { get; set ; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int Week { get; set; }
        public decimal Total { get; set; }

       

        public List<PmNewsPaper> getPmNewsPapers()
        {
            return pmNewsPapers = new List<PmNewsPaper>() {

            new PmNewsPaper
                {
                  Id = 1,
                  Price = 150,
                  Quantity = 23,
                  Week = 1
                },
                new PmNewsPaper
                {
                  Id = 2,
                  Price = 160,
                  Quantity = 20,
                  Week = 2
                },
                new PmNewsPaper
                {
                    Id = 3,
                    Price = 155,
                    Quantity = 18,
                    Week = 3
                },
                new PmNewsPaper
                {
                    Id = 4,
                    Price = 175,
                    Quantity = 14,
                    Week = 4
                }
            };
        }


        public List<PmNewsPaper> getSumTotalForEachWeek()
        {
            List<PmNewsPaper> pmNewsPaperWithTotalForEachWeek = new List<PmNewsPaper>();
            foreach (var pmNews  in getPmNewsPapers())
            {
                pmNews.Total = pmNews.Quantity * pmNews.Price;
                pmNewsPaperWithTotalForEachWeek.Add(pmNews);
            }
            return pmNewsPaperWithTotalForEachWeek;
        }

        public decimal getSumTotalForAllWeeksPmNews()
        {
            decimal sumTotalForAllWeeksPmNews = 0;
            foreach (var pmNews in getSumTotalForEachWeek())
            {
               sumTotalForAllWeeksPmNews = sumTotalForAllWeeksPmNews + pmNews.Total;
            }

            return sumTotalForAllWeeksPmNews;
        }

        public int getPmNewsPaperCount()
        {
            return getPmNewsPapers().Count;
        }

        public decimal getAverageForPmNews()
        {
            var averageValue = getSumTotalForAllWeeksPmNews() / getPmNewsPaperCount();
            return averageValue;
        }
        
    }



}
