using System;
using System.Collections.Generic;
using System.Text;

namespace Inhertiance_TH
{
    class Circle : Shape
    {
        #region fields
        private double radius = 1.0;
        #endregion

        #region constructor
        public Circle()
        {

        }

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius, String color, bool filled) : base(color, filled)
        {

        }

        #endregion

        #region public method
        public double GetRadius()
        {
            return radius;
        }
        public void SetRadius(double radius)
        {
            this.radius = radius;
        }
        public double GetArea()
        {
            return radius * radius * Math.PI;
        }
        public double GetPerimeter()
        {
            return 2 * radius * Math.PI;
        }
        public override String ToString()
        {
            return $"A Circle with radius= {GetRadius()}, which is a subclass of {base.ToString()}";
        }
        #endregion

        #region private method
        #endregion
    }
}
