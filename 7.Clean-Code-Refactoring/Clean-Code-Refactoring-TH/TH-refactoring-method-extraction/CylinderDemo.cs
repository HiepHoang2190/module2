using System;
using System.Collections.Generic;
using System.Text;

namespace TH_refactoring_method_extraction
{
    class CylinderDemo
    {
        public static double GetVolume(int radius, int height)
        {
            double baseArea = GetArea(radius);
            double perimeter = GetPerimeter(radius);
            double volume = perimeter * height + 2 * baseArea;
            return volume;
        }
        private static double GetArea(int radius)
        {
            return Math.PI * radius * radius;
        }
        private static double GetPerimeter(int radius)
        {
            return 2 * Math.PI * radius;
        }
    }
}
