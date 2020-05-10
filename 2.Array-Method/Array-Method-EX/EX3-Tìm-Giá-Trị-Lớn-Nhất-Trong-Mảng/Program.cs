using System;

namespace EX3_Tìm_Giá_Trị_Lớn_Nhất_Trong_Mảng
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m1 = new int[2, 3];
            int[,] m2 = new int[2, 3] { { 3, 3, 3 }, { 4, 4, 4 } };
            int col, row;
           
            Console.Write("Input row: ");
            row = int.Parse(Console.ReadLine());
            Console.Write("Input col: ");
            col = int.Parse(Console.ReadLine());

            int[,] m3 = new int[row, col];
            Random rnd = new Random();
            for (int i = 0; i < row; i++)
                
                {
                    //for(int j=0; j<col; j++)
                    for (int j = 0; j <col; j++)
                    {
                        m3[i, j] = rnd.Next(10, 100);
                    }
                }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j <col; j++)
                {
                    Console.Write($"{m3[i, j]} ");
                }
                Console.WriteLine();
            }
            int Index = 0;
            int Index2 = 0;
            int max = m3[0,0];
            for (int i = 0; i <row; i++)
            {
                for (int j = 0; j <col; j++)
                {
                    if( max < m3[i, j])
                    {
                        max = m3[i,j];
                        Index = i+1;
                        Index2 = j+1;
                    }

                }


            }
            Console.WriteLine($"Max is:{max},position at [{Index},{Index2}]");

        }
    }
}
