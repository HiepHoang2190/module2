using System;
using System.Collections.Generic;
using System.Text;

namespace TH_List_Basic
{
    public class MyList<T>
    {
        #region fields
        private int Capacity { get; set; }
        private Object[] items;

        #endregion
        #region constructor

        public MyList()
        {
            items = new Object[10];
        }
        #endregion
        #region public method
        private void EnsureCapapcity()
        {
            int newSize = items.Length * 2;
            Array.Copy(items, items, newSize);
        }
        public void Add(T data)
        {
            if (Capacity == items.Length)
            {
                EnsureCapapcity();
            }
            items[Capacity++] = data;
        }
        public T GetData(int idx)
        {
            if(idx>=Capacity ||idx < 0)
            {
                throw new IndexOutOfRangeException("Index: " + idx + ", Capacity: " + Capacity);

            }
            return (T)items[idx];
        }
        #endregion
    }
}
