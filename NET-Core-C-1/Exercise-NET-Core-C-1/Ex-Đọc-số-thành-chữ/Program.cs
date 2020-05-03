using System;

namespace Ex_Đọc_số_thành_chữ
{
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            Console.Write("Enter a number: ");
            number = Console.ReadLine();
            string[] s = new string[number.Length];
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }
    }
}
