using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(20);
            Console.WriteLine(student.GetAge());
            student.SetAge(-1);
            Console.WriteLine(student.GetAge());
            student.SetAge(-3);
            Console.WriteLine(student.GetAge());
            student.SetAge(5);
            Console.WriteLine(student.GetAge());
        }
    }
    public class Student
    {
        private int age;
        public Student(int _age)
        {
            age = _age;
        }

        public int GetAge()
        {
            return this.age;
        }
        public void SetAge(int age)
        {

            this.age = age;
        }   
    }
}
