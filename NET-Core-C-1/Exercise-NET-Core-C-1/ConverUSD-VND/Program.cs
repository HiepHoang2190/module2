using System;
using System.Text;

namespace ConverUSD_VND
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int rate= 23000;
            int Usd;
            int Vnd;

            Console.Write("\n Nhập vào giá trị Usd: ");
            Usd = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Giá trị Vnd là: ");
            Vnd = Usd*rate;
            Console.WriteLine(Vnd+" đồng");
            
        }
    }
}
