using System;

namespace Find_Min_by_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            int[] array;
            do
            {
                Console.WriteLine("Enter a size");
                size = int.Parse(Console.ReadLine());
                if (size > 20)
                {
                    Console.WriteLine("Size should not exceed 20");
                }
            } while (size > 20);

            array = new int[size];
            int i = 0;
            for( i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Enter element:{i+1} ");
                array[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Property list: ");
            for(int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j] + "\n");
            }

            int index = MinValue(array);
            Console.WriteLine($"The smallest element in the array is: {array[index]}");
        }


        public static int MinValue(int[] array)
        {
            int min = array[0];
            int index = 0;
            for(int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }
            return index;
        }
    }
}
