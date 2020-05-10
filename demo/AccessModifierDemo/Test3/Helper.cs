﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Test3
{
    class Helper
    {
        public static string NotFound= "Not found, please try with other words";
        public static string FormatName(string name)
        {
            return name.ToUpper();
        }
        public static class Error
        {
            public static string E404 = "Error 404";
            public static string E500 = "Internal server";
        }
    }
}
