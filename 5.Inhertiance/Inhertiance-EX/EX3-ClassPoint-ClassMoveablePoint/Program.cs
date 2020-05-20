using System;

namespace EX3_ClassPoint_ClassMoveablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(3, 4);

            point.GetXY();
            Console.WriteLine(point.ToString());

            MovablePoint move = new MovablePoint(4,5,3,4);
            move.GetSpeed();
            Console.WriteLine(move.ToString());
            move.Move(7,8);

        }
    }

    class Point
    {
        private float x = 0.0f;
        private float y = 0.0f;

        public Point()
        {

        }
        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float GetX()
        {
            return x;
        }
        public void SetX(float x)
        {
            this.x = x;
        }
        public float GetY()
        {
            return y;
        }
        public void SetY(float y)
        {
            this.y = y;
        }
        public void GetXY()
        {
            float[] arr = { x, y };
            foreach (float item in arr)
            {
                Console.WriteLine(item);
            }
        }
        public void SetXY(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public override String ToString()
        {
            return $"{x},{y}";
        }
    }


    class MovablePoint : Point
    {
        private float xSpeed = 0.0f;
        private float ySpeed = 0.0f;


        public MovablePoint()
        {

        }
        public MovablePoint(float xSpeed, float ySpeed, float x, float y):base(x,y)
        {
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }

        public float GetXSpeed()
        {
            return xSpeed;
        }
        public void SetXSpeed(float xspeed)
        {
            xSpeed = xspeed;
        }
        public float GetYSpeed()
        {
            return ySpeed;
        }
        public void SetYSpeed(float yspeed)
        {
            ySpeed = yspeed;
        }
        public void GetSpeed()
        {
            float[] arr1 = { xSpeed, ySpeed };
            foreach (float item in arr1)
            {
                Console.WriteLine(item);
            }
        }
        public override String ToString()
        {
            return $"{xSpeed},{ySpeed},{GetX()},{GetY()}";
        }
        public void Move(float x, float y)
        {
            float x1 = x;
            float y1 = y;
            Console.WriteLine($"{x1 + GetXSpeed()},{y1 + GetYSpeed()}");
        }
    }

  
}
