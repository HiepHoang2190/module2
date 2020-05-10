using System;
using System.Text;
namespace EX4_Gộp_Mảng
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
            Console.WriteLine("1.   KHAI BÁO 2 MẢNG VÀ GỘP MẢNG");
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
                    int size1;
                    int size2;

                    int[] arr1;
                    int[] arr2;
                    int k;
                    int x;
                    int index;
                    //In mảng 1
                    Console.Write("\n Enter a size array1: ");
                    size1 = int.Parse(Console.ReadLine());


                    arr1 = new int[size1];
                    int i = 0;

                    Console.WriteLine("Array is: ");
                    Random rand = new Random();
                    for (i = 0; i < arr1.Length; i++)
                    {
                        arr1[i] = rand.Next(100);
                        Console.Write(arr1[i] + " ");
                    }



                    //In mảng 2
                    Console.Write("\n Enter a size array2: ");
                    size2 = int.Parse(Console.ReadLine());


                    arr2 = new int[size2];
                    int j;
                    Console.WriteLine("Array2 is: ");
                    Random rand2 = new Random();
                    for (j = 0; j < arr2.Length; j++)
                    {
                        arr2[j] = rand2.Next(100);
                        Console.Write(arr2[j] + " ");
                    }

                    int size3 = size1 + size2;
                    int[] arr3 = new int[size3];
                    for (i = 0; i < size1; i++)
                    {
                        arr3[i] = arr1[i];
                    }
                    for (k = 0; k < size2; k++)
                    {
                        arr3[i] = arr2[k];
                        i++;
                    }

                    /* sap xep theo thu tu tang dan*/
                    //for (i = 0; i < size3; i++)
                    //{
                    //    for (k = 0; k < size3 - 1; k++)
                    //    {

                    //        if (arr3[k] >= arr3[k + 1])
                    //        {
                    //            j = arr3[k + 1];
                    //            arr3[k + 1] = arr3[k];
                    //            arr3[k] = j;
                    //        }
                    //    }
                    //}


                    Console.WriteLine();
                    Console.WriteLine("Print Array3: ");
                    for (i = 0; i < size3; i++)
                    {
                        Console.Write(arr3[i] + " ");
                    }

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
