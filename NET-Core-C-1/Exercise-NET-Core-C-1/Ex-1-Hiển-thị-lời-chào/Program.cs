using System;
using System.Text;
namespace Ex_1_Hiển_thị_lời_chào
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Enter your name");
            Console.WriteLine("Hello: " +Console.ReadLine());

        }
    }
}
