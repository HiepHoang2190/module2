using System;
using System.Collections;
namespace TH_Dotnet_Sortedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add(2, "two");
            sl.Add(1, "one");
            sl.Add(3, "three");
            int myKey = 2;

            //Console.WriteLine("The key \"{0}\" is {1}.", myKey, sl.ContainsKey(myKey) ? "in the SortedList" : "NOT in the SortedList");
            Console.WriteLine($"The key {myKey} is {(sl.ContainsKey(myKey) ? "in the SortedList" : $"NOT in the SortedList")}");
            myKey = 4;
            Console.WriteLine("The key \"{0}\" is {1}.", myKey, sl.ContainsKey(myKey) ? "in the SortedList" : "NOT in the SortedList");
            String myValue = "one";
            Console.WriteLine("The value \"{0}\" is {1}.", myValue, sl.ContainsValue(myValue) ? "in the SortedList" : "NOT in the SortedList");
            myValue = "nine";
            Console.WriteLine("The value \"{0}\" is {1}.", myValue, sl.ContainsValue(myValue) ? "in the SortedList" : "NOT in the SortedList");

        }
    }
}
