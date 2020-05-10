using System;
using System.Text;
namespace Bai6
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
            Console.Write("\n Enter ID Employee: ");
            id = Int32.Parse(Console.ReadLine());
            Console.Write("\n Enter time Employee: ");
            double time = double.Parse(Console.ReadLine());


            do
            {

                if (time > 40)
                {
                    salary = (time - 40) * over_time2 + (5 * over_time1) + (35 * over_time);
                }
                else if (time > 35)
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
            } while (id != 0);


            if (id!=0)
            {
                Console.WriteLine($" The total number of employees paid: {total_staff}    ");
                Console.WriteLine($"Total salary paid: {total_salary} usd");
            }else
            {
                Console.WriteLine("No Employee were enter");
            }
        }
    }
}
