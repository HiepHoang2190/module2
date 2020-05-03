using System;
using System.Text;
namespace Hiển_thị_20_số_nguyên_tố_đầu_tiên
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int count = 0;
            int i = 0;
            Console.WriteLine("20 số nguyên tố đầu tiên là: ");
            while (count < 20)
            {
                if (isPrime(i))
                {
                    Console.WriteLine(i);
                    count++;
                }
                i++;
            }

           
        }

        public static bool isPrime(int num)
        {
            if(num<2)
            {
                return false;
            }
            if (num == 2)
            {
                return true;
            }
            for(int i = 2; i < num - 1; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
