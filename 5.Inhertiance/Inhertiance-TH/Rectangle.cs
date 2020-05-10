using System;
using System.Collections.Generic;
using System.Text;

namespace Inhertiance_TH
{
    class Rectangle:Shape
    {
        #region fields
        private double width = 1.0;
        private double length = 1.0;
        #endregion

        #region constructor
        public Rectangle()
        {

        }
        public Rectangle(double width,double length)
        {
            this.width = width;
            this.length = length;
        }
        public Rectangle(double width, double length, String color, bool filled) : base(color, filled)
        {
            this.width = width;
            this.length = length;
        }
        #endregion

        #region public method
        public double GetWidth()
        {
            return width;
        }
        public virtual void SetWidth(double width)
        {
            this.width = width;
        }
        public double GetLength()

        {

            return length;

        }



        public virtual void SetLength(double length)

        {

            this.length = length;

        }
        public double GetArea()

        {

            return width * this.length;

        }



        public double GetPerimeter()

        {

            return 2 * (width + this.length);

        }
        public override String ToString()
        {
            return $"A Rectangle with width= {GetWidth()}, and length= {GetLength()}, which is a subclass of {base.ToString()}";
        }

        #endregion

        #region private method
        #endregion
    }
}
