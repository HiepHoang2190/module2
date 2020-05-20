using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ShapeIComparer
{
    //public class CircleComparator : IComparer<Circle>
    //{
    //  public int Compare(Circle c1, Circle c2)
    //  {
    //    if (c1.getRadius() > c2.getRadius()) return 1;
    //    else if (c1.getRadius() < c2.getRadius()) return -1;
    //    else return 0;
    //  }
    //}
    public class ComperableCircle: Circle,IComparable
    {
        public ComperableCircle() { }
        public ComperableCircle(double radius) : base(radius) { }
        public ComperableCircle(double radius, string color, bool filled) : base(radius, color, filled) { }
        //public int CompareTo(ComperableCircle o)
        //{
        //    if (getRadius() > o.getRadius()) return 1;
        //    else if (getRadius() < o.getRadius()) return -1;
        //    else return 1;
        //}

        public int CompareTo(object obj)
        {
            if (getRadius() > ((ComperableCircle)obj).getRadius()) return 1;
            else if (getRadius() < ((ComperableCircle)obj).getRadius()) return -1;
            else return 1;
        }
    }
}
