using System;
using System.Collections.Generic;
using System.Text;

namespace ForumManagement
{
    class Post:Ipost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public double AverageRate => CalculatorRate();
        public List<int> Rates = new List<int>();

        public string Display()
        {
            return $"Id:{Id}\t" +
                $"Title:{Title}\t" +
                $"Content:{Content}\t" +
                $"Author:{Author}\t" +
                $"Count:{Rates.Count}\t" +
                $"AverageRate: {AverageRate}";
        }

        public double CalculatorRate()
        {
           double total = 0;
           foreach(var item in Rates)
            {
                total +=(double) item;
            }
           return ( total / Rates.Count);
        }
    }
}
