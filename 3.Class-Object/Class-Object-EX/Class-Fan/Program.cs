using System;

namespace Class_Fan
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassFan fan1 = new ClassFan(3, 10, "yellow", true);
            Console.WriteLine($"Fan{ClassFan.numberOfFan}: ");
            fan1.ToString();
            Console.WriteLine("=====================");
            ClassFan fan2 = new ClassFan(2, 5, "blue", false);
            Console.WriteLine($"Fan{ClassFan.numberOfFan}: ");
            fan2.ToString();
            ClassFan fan3 = new ClassFan();
           
          
            
            
            
           

            Console.WriteLine("=====================");
            Console.WriteLine($"Fan{ClassFan.numberOfFan}: ");
            fan3.ToString();


        }


    }
    public class ClassFan
    {
        #region fields
        public const int SLOW = 1;
        public const int MEDIUM = 2;
        public const int FAST = 3;

        private int speed { get; set; }
        private bool on { get; set; }
        private double radius { get; set; }
        private string color { get; set; }
        public static int numberOfFan;

        #endregion

        #region constructor
      
        public ClassFan(int sp = 1, double rad=5, string col="blue", bool onoff=false)
        {
            speed = sp;
            radius = rad;
            on = onoff;
            color = col;
            numberOfFan++;
        }
        #endregion


        #region public method

        public int Speed
        {
            get => speed;
            set => speed = 1;
        }
        public bool OnOff
        {
            get => on;
            set => on = false;
        }
        public double Radius
        {
            get => radius;
            set => radius = 5;
        }
        public string Color
        {
            get => color;
            set => color = "blue";
        }

        public void ToString()
        {   
            
            if (OnOff == true) {
                Console.WriteLine("Fan is on ");
                Console.WriteLine($"Speed:{Speed} ");
                
                Console.WriteLine($"Radius:{Radius} ");
                Console.WriteLine($"Color:{Color} ");
            }
            else
            {
                Console.WriteLine("Fan is off ");
                Console.WriteLine($"Speed:{Speed} ");
                
                Console.WriteLine($"Radius:{Radius} ");
                Console.WriteLine($"Color:{Color} ");

            }
            
        }
        #endregion

        #region private method
        #endregion
    }
}
