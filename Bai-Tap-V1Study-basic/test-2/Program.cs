using System;
using System.Text;
namespace test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int over_time1 = 25;
            int over_time2 = 30;
            int over_time = 20;
            double salary;
            int id;
            double total_salary = 0;
            int total_staff = 0;

            int choice;
            do
            {
               
                Console.WriteLine("Menu.");
                Console.WriteLine("1.Input ID and Time Employee");
                Console.WriteLine("2.Total salary");
                Console.WriteLine("3.Exit");
                Console.WriteLine("Enter your choice: ");
                //choice = Int32.Parse(Console.ReadLine());
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        {
                           
                            Console.Write("\n Enter ID Employee: ");
                            id = Int32.Parse(Console.ReadLine());
                            Console.Write("\n Enter time Employee: ");
                            double time = double.Parse(Console.ReadLine());
                            if (time > 40 && id != 0)
                            {
                                salary = (time - 40) * over_time2 + (5 * over_time1) + (35 * over_time);
                            }
                            else if (time > 35 && id != 0)
                            {
                                salary = (time - 35) * over_time1 + (35 * over_time);
                            }
                            else
                            {
                                salary = time * over_time;
                            }
                            total_staff += 1;
                            total_salary = total_salary + salary;
                            Console.WriteLine($"ID Employee: {id}, Number of hours worked: {time}, Salary:{salary}");
                            
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($" The total number of employees paid: {total_staff}    ");
                            Console.WriteLine($"Total salary paid: {total_salary} usd");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("No Employee were enter");
                            Environment.Exit(3);
                            break;
                        }


                }
            } while (choice != 3);
        }
    }
}
