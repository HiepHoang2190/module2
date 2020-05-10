using System;

namespace Tạo_Mảng_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int i = 0;

            Random rand = new Random();
            for (i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(100);
                Console.WriteLine(array[i] + "\n");
            }

        }
    }
}
