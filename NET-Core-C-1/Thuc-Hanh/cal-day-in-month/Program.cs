using System;
using System.Text;
namespace cal_day_in_month
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("\n Nhập tháng cần tính ngày vào: ");
            int month = Int32.Parse(Console.ReadLine());

            //dùng switch

            //switch (month)
            //{
            //    case 2:
            //        Console.WriteLine("Tháng 2 có 28 hoặc 29 ngày");
            //        break;
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine($"Tháng {month} có 31 ngày");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine($"Tháng {month} có 30 ngày");
            //        break;
            //    default:
            //        Console.WriteLine("Dữ liệu nhập vào sai");
            //        break;
            //}


            //Cách 2: dùng mảng
            string[] CalDay = {"31 ngày", "28 hoặc 29 ngày", "31 ngày","30 ngày", "31 ngày","30 ngày", "31 ngày", "31 ngày","30 ngày", "31 ngày","30 ngày", "31 ngày" };

            Console.WriteLine($"Tháng {month} có: {CalDay[month - 1]}");
        }
    }
}
