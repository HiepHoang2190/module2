using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    class Product
    {
        #region fields
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public int[] Rate = new int[3];
        private double avegareRate;
        #endregion

        #region constructor
        #endregion

        #region public method
        public string  ViewInfo()
        {
            return $"Name: {name}\t, Description: {description}\t," +
                $"Price:{price}\t," +
                $"AvegareRate: {avegareRate}\t";
        }
        public void CalculateRate()
        {
            double total = 0;
            foreach(double item in Rate)
            {
                total += item;
            }
           avegareRate=total/Rate.Length;
        }
        #endregion


        #region private method
        #endregion
    }
}
