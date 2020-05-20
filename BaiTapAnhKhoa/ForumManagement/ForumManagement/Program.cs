using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;
namespace ForumManagement
{
    class Program
    {
        public static Forum forum = new Forum();
        public static int PostId = 0;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            CreateMenu();
            Process();
        }
        public static void CreateMenu()
        {
            int option = 0;

            Console.WriteLine("PHONEBOOK MANAGEMENT SYSTEM");
            Console.WriteLine("Please select an option from 1 to 5:");
            Console.WriteLine("1. Create Post");
            Console.WriteLine("2. Remove Post");
            Console.WriteLine("3. Update Post");
            Console.WriteLine("4. Search Post");
            Console.WriteLine("5. Rating ");
            Console.WriteLine("6. DisplayPhoneBook ");
            Console.WriteLine("7. Exit");
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
                        CreatePost();


                        Console.WriteLine("Nhấn phím bất kỳ để về menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        RemovePost();
                    
                        Console.WriteLine("Nhấn phím bất kỳ để về menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 3:
                    {
                        Console.Clear();

                        UpdatePost();

                        Console.WriteLine("Nhấn phím bất kỳ để về menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 4:
                    {
                        Console.Clear();

                        SearchPost();

                        Console.WriteLine("Nhấn phím bất kỳ để về menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 5:
                    {
                        Console.Clear();
                        Rating();

                        Console.WriteLine("Nhấn phím bất kỳ để về menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 6:
                    {
                        Console.Clear();

                        DisplayPost();
                        Console.WriteLine("Nhấn phím bất kỳ để về menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 7:
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
        public static void CreatePost()
        {
            forum.Show();
            Console.Write("Enter the number of Contacts you want to import:");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.Write("Title: ");
                var title = Console.ReadLine();
                Console.Write("Author: ");
                var author = Console.ReadLine();
                Console.Write("Content: ");
                var content = Console.ReadLine();

                Console.Write("PostId: ");
                var PostId = int.Parse(Console.ReadLine());
                var post = new Post()
                {
                    Id = PostId,
                    Author = author,
                    Content = content,
                    Title = title,
                };
                
                forum.Add(post);
            }
            Console.Clear();
            forum.Show();



        }
        public static void Rating()
        {
            Console.Write("Enter post Id: ");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Give rate value (1 to 5)");
            var rateValue = int.Parse(Console.ReadLine());
            forum.Rating(id, rateValue);
        }
        public static void UpdatePost()
        {

            forum.Show();
            Console.Write("Enter post Id: ");
            var id = int.Parse(Console.ReadLine());
            Console.Write("Content: ");
            var content = Console.ReadLine();
            forum.UpdatePost(id, content);

            forum.Show();
        }
        public static void RemovePost()
        {

            forum.Show();
            Console.Write("Enter post Id: ");
            var id = int.Parse(Console.ReadLine());
            forum.RemovePost(id);
            forum.Show();
        }
        public static void SearchPost()
        {
            Console.Write("enter keyword");
            var keyword = (Console.ReadLine());

            forum.Search(keyword);
        }
        public static void DisplayPost()
        {
            forum.Show();
        }
    }
}
