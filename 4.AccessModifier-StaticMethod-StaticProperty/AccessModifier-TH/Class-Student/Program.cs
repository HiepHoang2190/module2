using System;
using System.Text;
namespace Class_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Student std1 = new Student(1, "M.Công", "Hà Nội", 30);
            Student std2 = new Student();
            std2.Id = 2;
            std2.Name = "N. Minh";
            std2.Address = "Huế";
            std2.Age = 20;
            Console.WriteLine(std1.ToString());
            Console.WriteLine(std2.ToString());
            Console.ReadKey();
        }
    }

    public class Student
    {
        #region fields

        private int id;
        private string name;
        private string address;
        private int age;
        #endregion


        #region constructor

        public Student()
        {

        }

        public Student(int _id, string _name, string _address, int _age)
        {
            id = _id;
            name = _name;
            address = _address;
            age = _age;
        }


        #endregion


        #region public method
        #endregion
        public string Address
        {
            get => address;
            set => address = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Id
        {
            get => id;
            set => id = value;
        }
        public int Age
        {
            get => age;
            set => age = value;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Address: {Address}, Age: {Age} ";
        }

        #region private method
        #endregion
    }
}
