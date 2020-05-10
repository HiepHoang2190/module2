using System;
using System.Text;
namespace Test3
{
   
    class Program
    {
        public static Shop shop = new Shop();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            CreateMenu();
            Process();
        }

        public static void CreateMenu()
        {
            int option = 0;

            Console.WriteLine("PRODUCT MANAGEMENT SYSTEM");
            Console.WriteLine("Please select an option from 1 to 5:");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Remove Product");
            Console.WriteLine("3. Show Product");
            Console.WriteLine("4. Search Product");
            Console.WriteLine("5. Exit");
            Console.Write("option: ");




            Process();
        }
        public static void Process()
        {
            int option;
            int.TryParse(Console.ReadLine(), out option);


            switch (option)
            {
                case 1:
                    {
                        Console.Clear();

                        AddProduct();
                        Console.WriteLine("Nhấn phím bất kỳ để về menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 2:
                    {
                        Console.Clear();

                        RemoveProduct();
                        Console.WriteLine("Nhấn phím bất kỳ để về menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 3:
                    {
                        Console.Clear();

                        ShowProduct();
                        Console.WriteLine("Nhấn phím bất kỳ để về menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 4:
                    {
                        Console.Clear();

                        SearchProduct();
                        Console.WriteLine("Nhấn phím bất kỳ để về menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 5:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;

                    }
                default:
                    Console.WriteLine("Bạn đã nhập sai, vui lòng bấm phím bất kỳ để nhập lại");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
            CreateMenu();
        }

        public static void AddProduct()
        {
            Product product = new Product();
            Console.Write("Name: ");
            product.name = Helper.FormatName(Console.ReadLine());
            Console.Write("Description: ");
            product.description = Console.ReadLine();
            Console.Write("Price: ");
            product.price = double.Parse(Console.ReadLine());
            Console.WriteLine("Vote Rate: ");
            for(int i = 0; i < product.Rate.Length; i++)
            {
                product.Rate[i] = int.Parse(Console.ReadLine());
            }
            product.CalculateRate();
            shop.Add(product);
        }
        public static void ShowProduct()
        {
            shop.ShowProductList();
        }
        public static void RemoveProduct()
        {
            shop.ShowProductList();
            Console.WriteLine("Enter Product name you want to delete: ");
            var pn = Console.ReadLine();
            shop.Remove(pn);
        }
        public static void SearchProduct()
        {
            Console.WriteLine("Enter Product name you want to search: ");
            var pn = Console.ReadLine();
            shop.Search(pn);
        }
    }
}
