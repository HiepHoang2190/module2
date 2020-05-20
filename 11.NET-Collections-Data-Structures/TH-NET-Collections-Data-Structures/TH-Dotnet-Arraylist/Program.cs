using System;
using System.Collections;

namespace TH_Dotnet_Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList studentList = new ArrayList();

            studentList.Add(new Student { Name = "Peter", Age = 20 });
            studentList.Add(new Student { Name = "John", Age = 21 });
            studentList.Add(new Student { Name = "Mark", Age = 19 });
            foreach (Student student in studentList)
            {
                Console.WriteLine($"Name: {student.Name}, Age:{student.Age}");
            }
            //foreach (var item in studentList)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            Console.WriteLine("======================");
            studentList.RemoveAt(1);
            foreach (Student student in studentList)
            {
                Console.WriteLine($"Name: {student.Name}, Age:{student.Age}");
            }

        }
    }
}
