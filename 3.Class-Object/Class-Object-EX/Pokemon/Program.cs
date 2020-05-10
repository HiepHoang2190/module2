using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Pokemon pk1 = new Pokemon("pikachu","electrical",30);
            Pokemon pk2 = new Pokemon("Charizard", "fire", 50);
            //Console.WriteLine($"Name is: {pk1.name}, Type: {pk1.type}, HP: {pk1.hp}");
            pk1.Display();
            pk2.Display();
            Console.Write("Pokemon after Health:");
            Console.WriteLine();
            Console.WriteLine(pk1.Health());
            Console.WriteLine(pk2.Health());
            pk1.Hunt(20);
            pk1.Hunt(40);
           
           
            
           

        }

       
    }
    public class Pokemon
    {
        #region fileds
        public string name;
        public string type;
        public int hp;
        #endregion

        #region constructor
        public Pokemon()
        {

        }
        public Pokemon(string n, string t, int Hp)
        {
            name = n;
            type = t;
            hp = Hp;
        }
        #endregion

        #region public method

        public void Display()
        {
            Console.WriteLine($"Name is: {name}, Type is: {type}, HP: {hp}");
        }
        public int Health()
        {
            return hp = hp + 10;
        }
        public void Hunt(int d)
        {
            Console.WriteLine("Enter the amount of damage that pokemon takes:");
             d = int.Parse(Console.ReadLine());
           
            Console.WriteLine($"HP after Hunt: {hp = hp - d}");
            if (hp < 0)
            {
                Console.WriteLine("Pokemon die");
            }
        }
        
        #endregion

        #region private method
        #endregion
    }
}
