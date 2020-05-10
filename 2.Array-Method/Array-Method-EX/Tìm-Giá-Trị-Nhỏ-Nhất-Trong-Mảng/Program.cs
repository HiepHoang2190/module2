using System;
using System.Text;

namespace Tìm_Giá_Trị_Nhỏ_Nhất_Trong_Mảng
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            //int[,] m1 = new int[2, 3];
            //int[,] m2 = new int[2, 3] { { 3, 3, 3 }, { 4, 4, 4 } };
            //int col, row;

            //Console.Write("Input row: ");
            //row = int.Parse(Console.ReadLine());
            //Console.Write("Input col: ");
            //col = int.Parse(Console.ReadLine());

            //int[,] m3 = new int[row, col];
            //Random rnd = new Random();
            //for (int i = 0; i < row; i++)

            //{
            //    //for(int j=0; j<col; j++)
            //    for (int j = 0; j < col; j++)
            //    {
            //        m3[i, j] = rnd.Next(10, 100);
            //    }
            //}

            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < col; j++)
            //    {
            //        Console.Write($"{m3[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
            //int Index = 0;
            //int Index2 = 0;
            //int min = m3[0, 0];
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < col; j++)
            //    {
            //        if (min > m3[i, j])
            //        {
            //            min = m3[i, j];
            //            Index = i + 1;
            //            Index2 = j + 1;
            //        }

            //    }


            //}
            //Console.WriteLine($"Min is:{min},position at [{Index},{Index2}]");
            Show();
            Chon();
            Console.ReadLine();
        }

        public static void Show()
        {
            Console.WriteLine("***************MAIN MENU**********");
            Console.WriteLine("*******TÌM GIÁ TRỊ NHỎ NHẤT CỦA MẢNG********");
            Console.WriteLine("1.   KHAI BÁO MẢNG VÀ TÌM GIÁ TRỊ NHỎ NHẤT CỦA MẢNG");
            Console.WriteLine("2.   THOÁT");

            Console.Write("    NHAP LUA  CHON CUA BAN VAO:");

            Chon();
        }
        public static void Chon()
        {
            int row;
            int col ;

           
            int chon;
            //chon = int.Parse(Console.ReadLine());
            int.TryParse(Console.ReadLine(), out chon);
            switch (chon)

            {
                case 1:
                    Console.Clear();

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
                    int Index = 0;
                    int Index2 = 0;
                    int min = m3[0, 0];
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            if (min > m3[i, j])
                            {
                                min = m3[i, j];
                                Index = i + 1;
                                Index2 = j + 1;
                            }

                        }


                    }
                    Console.WriteLine($"Min is:{min},position at [{Index},{Index2}]");
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
