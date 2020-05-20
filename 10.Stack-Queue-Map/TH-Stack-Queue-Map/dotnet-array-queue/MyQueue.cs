using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_array_queue
{
    class MyQueue
    {
        public int capacity { get; set; }
        public int[] queueArr;
        public int head { get; set; }
        public int tail { get; set; }
        public int currentSize;

        public MyQueue(int queueSize)
        {
            capacity = queueSize;
            queueArr = new int[capacity];
        }

        public Boolean isQueueFull()
        {
            bool status = false;
            if (currentSize == capacity)
            {
                status = true;
            }
            return status;
        }
        public Boolean isQueueEmpty()
        {
            bool status = false;
            if (currentSize == 0)
            {
                status = true;
            }
            return status;
        }
        public void Enqueue (int item)
        {
            if(isQueueFull()){
                Console.WriteLine("Overflow ! Unable to add element: " + item);
            }
            else
            {
                tail++;
                if (tail == capacity - 1)
                {
                    tail = 0;
                }
                queueArr[tail] = item;
                currentSize++;
                Console.WriteLine("Element " + item + " is pushed to Queue !");
            }
        }
        public void Dequeue()
        {
            if (isQueueEmpty())
            {
                Console.WriteLine("Underflow ! Unable to remove element from Queue");
            }
            else
            {
                head++;
                if (head == capacity - 1)
                {
                    Console.WriteLine("Pop operation done ! removed: " + queueArr[head - 1]);
                    head = 0;
                }
                else
                {
                    Console.WriteLine("Pop operation done ! removed: " + queueArr[head - 1]);
                }
                currentSize--;
            }
        }
    }
}
