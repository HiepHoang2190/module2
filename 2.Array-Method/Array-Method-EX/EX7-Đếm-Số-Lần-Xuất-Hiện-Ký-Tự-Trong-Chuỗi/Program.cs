using System;
using System.Text;
namespace EX7_Đếm_Số_Lần_Xuất_Hiện_Ký_Tự_Trong_Chuỗi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;


            Show();
            Chon();
            Console.ReadLine();
        }



        public static void Show()
        {
            Console.WriteLine("***************MAIN MENU**********");
            Console.WriteLine("*******GỘP MẢNG********");
            Console.WriteLine("1.   ĐẾM SỐ LẦN XUẤT HIỆN KÝ TỰ TRONG CHUỖI");
            Console.WriteLine("2.   THOÁT");

            Console.Write("    NHẬP LỰA CHỌN CỦA BẠN VÀO:");

            Chon();
        }
        public static void Chon()
        {



            int chon;
            //chon = int.Parse(Console.ReadLine());
            int.TryParse(Console.ReadLine(), out chon);
            switch (chon)

            {
                case 1:
                    Console.Clear();

                    Console.InputEncoding = Encoding.UTF8;
                    Console.OutputEncoding = Encoding.UTF8;

                    string str = "Hoàng Bách Hiệp";
                    Console.WriteLine($"Chuỗi là : {str}");
                    Console.WriteLine("Nhập vào ký tự cần đếm: ");
                    char A = char.Parse(Console.ReadLine());

                    int count = 0;
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i] == A)
                        {
                            count++;
                        }
                    }
                   
                    Console.WriteLine($"Số ký tự trong chuỗi là: {count}");






                    Console.WriteLine();
                    Console.WriteLine("Nhấn phím bất kỳ để về menu");
                    Console.ReadKey();
                    Console.Clear();
                    break;



                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Bạn đã nhập sai, vui lòng bấm phím bất kỳ để nhập lại");
                    Console.ReadKey();
                    Console.Clear();
                    break;



            }
            Show();
        }
    }
}
