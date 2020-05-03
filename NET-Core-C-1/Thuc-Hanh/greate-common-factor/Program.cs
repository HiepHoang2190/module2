using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace greate_common_factor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            a = Math.Abs(a);
            b = Math.Abs(b);

            if (a == 0 || b == 0)
            {
                Console.WriteLine("Không có ước chung lớn nhất");
            }
            else
            {
                while (a != b)
                {
                    if (a > b)
                    {
                        a = a - b;
                    }
                    else
                    {
                        b = b - a;
                    }
                }

                Console.WriteLine("Ước chung lớn nhất là: " + a);
            }
        }
    }
}
        
    

