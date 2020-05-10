using System;
using System.Text;

namespace Demo_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int chon;
            do
            {

                Console.WriteLine("***************MAIN MENU**********");
                Console.WriteLine("*******TINH CHU VI VA DIEN TICH HINH********");
                Console.WriteLine("1.   HINH TRON");
                Console.WriteLine("2.   HINH CHU NHAT");
                Console.WriteLine("3.   HINH VUONG");
                Console.WriteLine("4.   THOAT");
                Console.Write("    NHAP LUA  CHON CUA BAN VAO:");

                //chon = int.Parse(Console.ReadLine());
                int.TryParse(Console.ReadLine(), out chon);
                switch (chon)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("NHAP VAO BAN KINH");
                        float bankinh = float.Parse(Console.ReadLine());
                        Console.WriteLine("CHU VI HINH TRON {0}", bankinh * 2 * 3.14);
                        Console.WriteLine("DIEN TICH HINH TRON {0}", bankinh * bankinh * 3.14);
                        Console.WriteLine("Nhấn phím bất kỳ để về menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("NHAP VAO CHIEU DAI:");
                        float dai = float.Parse(Console.ReadLine());
                        Console.Write("NHAP VAO CHIEU RONG:");
                        float rong = float.Parse(Console.ReadLine());
                        Console.WriteLine("CHU VI HINH CHU NHAT {0}", (dai + rong) * 2);
                        Console.WriteLine("DIEN TICH HINH CHU NHAT {0}", dai * rong);
                        Console.WriteLine("Nhấn phím bất kỳ để về menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        Console.Write("NHAP VAO CHIEU DAI 1 CANH:");
                        float chieudai1canh = float.Parse(Console.ReadLine());
                        Console.WriteLine("CHU VI HINH VUONG {0}", chieudai1canh * 4);
                        Console.WriteLine("DIEN TICH HINH VUONG {0}", chieudai1canh * chieudai1canh);
                        Console.WriteLine("Nhấn phím bất kỳ để về menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Bạn đã nhập sai, vui lòng bấm phím bất kỳ để nhập lại");
                        Console.ReadKey();
                        Console.Clear();
                        break;



                }

            } while (chon != 4);





            //Show();
            //Chon();

            Console.ReadLine();
        }

        //public static void Show()
        //{
        //    Console.WriteLine("***************MAIN MENU**********");
        //    Console.WriteLine("*******TINH CHU VI VA DIEN TICH HINH********");
        //    Console.WriteLine("1.   HINH TRON");
        //    Console.WriteLine("2.   HINH CHU NHAT");
        //    Console.WriteLine("3.   HINH VUONG");
        //    Console.WriteLine("4.   THOAT");
        //    Console.Write("    NHAP LUA  CHON CUA BAN VAO:");
        //    Chon();


        //}
        //public static void Chon()
        //{

        //    int chon;
        //    //chon = int.Parse(Console.ReadLine());
        //    int.TryParse(Console.ReadLine(), out chon);
        //    switch (chon)

        //    {
        //        case 1:
        //            Console.Clear();
        //            Console.WriteLine("NHAP VAO BAN KINH");
        //            float bankinh = float.Parse(Console.ReadLine());
        //            Console.WriteLine("CHU VI HINH TRON {0}", bankinh * 2 * 3.14);
        //            Console.WriteLine("DIEN TICH HINH TRON {0}", bankinh * bankinh * 3.14);
        //            Console.WriteLine("Nhấn phím bất kỳ để về menu");
        //            Console.ReadKey();
        //            Console.Clear();
        //            break;

        //        case 2:
        //            Console.Clear();
        //            Console.Write("NHAP VAO CHIEU DAI:");
        //            float dai = float.Parse(Console.ReadLine());
        //            Console.Write("NHAP VAO CHIEU RONG:");
        //            float rong = float.Parse(Console.ReadLine());
        //            Console.WriteLine("CHU VI HINH CHU NHAT {0}", (dai + rong) * 2);
        //            Console.WriteLine("DIEN TICH HINH CHU NHAT {0}", dai * rong);
        //            Console.WriteLine("Nhấn phím bất kỳ để về menu");
        //            Console.ReadKey();
        //            Console.Clear();
        //            break;

        //        case 3:
        //            Console.Clear();
        //            Console.Write("NHAP VAO CHIEU DAI 1 CANH:");
        //            float chieudai1canh = float.Parse(Console.ReadLine());
        //            Console.WriteLine("CHU VI HINH VUONG {0}", chieudai1canh * 4);
        //            Console.WriteLine("DIEN TICH HINH VUONG {0}", chieudai1canh * chieudai1canh);
        //            Console.WriteLine("Nhấn phím bất kỳ để về menu");
        //            Console.ReadKey();
        //            Console.Clear();
        //            break;

        //        case 4:
        //            Environment.Exit(0);
        //            break;
        //        default:
        //            Console.WriteLine("Bạn đã nhập sai, vui lòng bấm phím bất kỳ để nhập lại");
        //            Console.ReadKey();
        //            Console.Clear();
        //            break;



        //    }

        //    Show();

        //}
    }
}

