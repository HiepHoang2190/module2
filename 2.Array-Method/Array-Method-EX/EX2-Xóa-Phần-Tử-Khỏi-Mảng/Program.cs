using System;

namespace EX2_Xóa_Phần_Tử_Khỏi_Mảng
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            int[] array;
            int x;
            int index_del;
            int j;

            Console.Write("\n Enter a size: ");
            size = int.Parse(Console.ReadLine());


            array = new int[size];
            int i = 0;
            Console.WriteLine("Array is: ");
            Random rand = new Random();
            for (i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(100);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Property list: ");
            for (j = 0; j < array.Length; j++)
            {
                Console.Write(array[j] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Enter Value X: ");
            x = int.Parse(Console.ReadLine());

            index_del = Array.IndexOf(array, x);
            if (index_del > -1)
            {
                Console.WriteLine($"{x}: appear in the array, position at {index_del+1}");
               
            }
            else
            {
                Console.WriteLine($"{x}: not appear in the array");
            }
            Console.WriteLine("Reprint the array after deleting the element:");
            for (j = 0; j < array.Length-1; j++)
            {
                array[index_del] = array[index_del + 1];
                array[j] = array[j + 1];
                Console.Write(array[j]+" ");
            }


        Console.ReadKey();
        }
    }
}
