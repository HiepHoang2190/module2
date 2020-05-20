using System;
using System.Collections.Generic;
using System.Text;

namespace Test4
{
    class Product
    {
        #region fields

        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public int[] Rate = new int[3];
        private double averageRate { get; set; }
        #endregion

        #region constructor
        
        #endregion
        #region public method
        public double AverageRate
        {
            get => averageRate;
        }
        public string viewInfo()
        {
            return $"Name: {name}\t" +
                $"Description: {description}\t" +
                $"Price:{price}\t" +
                $"AverageRate:{averageRate}\t";
        }
        public void CalculateRate()
        {
            double total = 0;
            foreach(double item in Rate)
            {
                total += item;
            }
            averageRate = total / Rate.Length;

        }
        #endregion
    }
}
