using System;

namespace Hiển_thị_các_loại_hình
{
    class Program
    {
        static void Main(string[] args)
        {

            //In hình chữ nhật
            //int N = 3;
            //int M = 10;

            //char drawChar = '*';
            //for(int i =0; i < N; i++)
            //{
            //    for(int j=0;j<M;j++)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.Write(drawChar);
            //    }
            //    Console.WriteLine();
            //}


            //=========================
            //In tam giác vuông
            int N = 10;


            char drawChar = '*';
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(drawChar);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //In tam giác vuông
            int M = 10;


            char drawChar1 = '*';
            for (int i = M; i >0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(drawChar1);
                }
                Console.WriteLine();
            }

        }
    }
}
