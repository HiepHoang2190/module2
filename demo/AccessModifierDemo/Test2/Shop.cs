﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    class Shop
    {
        #region fields
        public Product[] ProductList = new Product[0];
        #endregion

        #region constructor
        #endregion

        #region public method

        public void AddProduct(Product pt)
        {
            Array.Resize(ref ProductList, ProductList.Length+1);
            ProductList[ProductList.Length - 1] = pt;
        }
        
        public void RemoveProduct(string pn)
        {
           int pos = Check(pn);
            if (pos != -1)
            {
                for(int i=pos;i< ProductList.Length-1;i++)
                {
                    ProductList[i] = ProductList[i + 1];
                }
                Array.Resize(ref ProductList, ProductList.Length-1);
                Console.WriteLine($"{pn} was removed");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
        public void ShowProductList()
        {
            foreach(Product item in ProductList)
            {
                Console.WriteLine(item.ViewInfo());
            }
        }
        public void Search (string pn)
        {
            foreach(Product item in ProductList)
            {
                if (item.name.Equals(pn))
                {
                    Console.WriteLine(item.ViewInfo());
                }
                else
                {
                    Console.WriteLine("Not founud");
                }
            }
        }
        #endregion

        #region private method

        private int Check(string pn)
        {
            for(int i = 0; i < ProductList.Length; i++)
            {
                if (ProductList[i].Equals(pn))
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion
    }
}
