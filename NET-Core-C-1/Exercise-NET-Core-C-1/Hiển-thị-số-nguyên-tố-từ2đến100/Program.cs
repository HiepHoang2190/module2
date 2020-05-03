using System;

namespace Hiển_thị_số_nguyên_tố_từ2đến100
{
    class Program
    {
        static void Main(string[] args)
        {
            int dem = 0;
            Console.WriteLine("Danh sach so nguyen to :");
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        dem++;
                    }
                }

                if (dem == 2)
                {
                    Console.WriteLine(i);
                }
                dem = 0;
            }
        }
    }
}
