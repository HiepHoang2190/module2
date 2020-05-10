using System;
using System.Text;

namespace EX6_Tính_Tổng_Các_Số_Ở_Một_Cột_Xác_Định
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
            Console.WriteLine("1.   TÍNH TỔNG CÁC SỐ Ở MỘT CỘT XÁC ĐỊNH");
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

                    int col, row;
                    int k;
                    Console.Write("Input row: ");
                    row = int.Parse(Console.ReadLine());
                    Console.Write("Input col: ");
                    col = int.Parse(Console.ReadLine());

                    int[,] m3 = new int[row, col];
                    Random rnd = new Random();
                    for (int i = 0; i < row; i++)

                    {
                        //for(int j=0; j<col; j++)
                        for (int j = 0; j < col; j++)
                        {
                            m3[i, j] = rnd.Next(10, 100);
                        }
                    }

                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            Console.Write($"{m3[i, j]} ");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine(" Nhập vào cột muốn tính tổng: ");
                    k = int.Parse(Console.ReadLine());
                    int sum = 0;

                    for (int i = 0; i < row; i++)
                    {

                        sum += m3[i, k];

                    }
                    Console.WriteLine(sum);


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
