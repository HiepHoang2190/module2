using System;

namespace TH_List_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> listIneger = new MyList<int>();
            listIneger.Add(10);
            listIneger.Add(15);
            listIneger.Add(20);
            listIneger.Add(30);
            listIneger.Add(50);
            Console.WriteLine($"Item 1: {listIneger.GetData(1)}");
            Console.WriteLine($"Item 1: {listIneger.GetData(4)}");
            Console.WriteLine($"Item 1: {listIneger.GetData(2)}");
            listIneger.GetData(6);
            Console.WriteLine($"Item -1: {listIneger.GetData(-1)} ");
        }
    }
}
