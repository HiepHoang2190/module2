using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_array_stack
{
    class MyStack
    {
        public int[] arr;
        public int size { get; set; }
        public int index = 0;

        public  MyStack(int size)
        {
            this.size = size;
            arr = new int[size];
        }

       public Boolean isEmpty()
        {
            if (index == 0)
            {
                return true;
            }
            return false;
        }
        public Boolean isFull()
        {
            if (index == size)
            {
                return true;
            }
            return false;
        }
        public int Size()
        {
            return index;
        }
        public void Push(int element)
        {
            if (isFull())
            {
                throw new Exception("Stack is full");
            }
            arr[index] = element;
            index++;
        }
        public int Pop()
        {
            if (isEmpty())
            {
                throw new Exception("Stack is null");

            }
            return arr[--index];
        }
    }
}
