using System;

namespace EX2_ClassPoint2D_ClassPoint3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D point2d = new Point2D(3,4);
            
            point2d.GetXY();
            Console.WriteLine(point2d.ToString());

            Point3D point3d = new Point3D(50,60,70);
            
            point3d.GetXYZ();
            Console.WriteLine(point3d.ToString());
            point3d.SetXYZ(20, 30, 40);
            point3d.GetXYZ();
            Console.WriteLine(point3d.ToString());




        }
    }
    class Point2D
    {
        private float x = 0.0f;
        private float y = 0.0f;

        public Point2D()
        {

        }
        public Point2D(float x, float y)
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
            foreach(float item in arr)
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

    class Point3D: Point2D
    {
        private float z = 0.0f;

        public Point3D()
        {

        }
        public Point3D(float x, float y, float z): base(x,y)
        {
            this.z = z;
        }
        public float GetZ()
        {
            return z;
        }
        public void SetZ(float z)
        {
            this.z = z;
        }

        public void SetXYZ(float x,float y,float z)
        {

            //base.SetXY(x, y);
            SetX(x);
            SetY(y);
            this.z = z;
        }
        public void GetXYZ()
        {
            float[] arr = {GetX(),GetY(),z};
            foreach (float item in arr)
            {
                Console.WriteLine(item);
            }
        }
        public override String ToString()
        {
            return $"{GetX()},{GetY()},{z}";

        }
    }
    
}
