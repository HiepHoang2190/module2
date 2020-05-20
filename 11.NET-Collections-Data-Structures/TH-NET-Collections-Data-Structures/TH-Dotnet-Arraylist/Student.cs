using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace TH_Dotnet_Arraylist
{
   public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"Name:{Name}, Age:{Age}";
        }
    }
}
