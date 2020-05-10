using System;
using System.Text;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int col, row;
            Console.Write("Nhập vào giá trị dòng: ");
            row = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào giá trị cột: ");
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

            int sum = 0;
            for(int i = 0; i < row; i++)
            {
                
            
                    sum += m3[i, i];
                    
                
            }
            Console.WriteLine($"Tổng các phần tử ở đường chéo chính:{sum}");
        }
       
    }




}
