﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Test5
{
    public abstract class Phone
    {
        public abstract void InsertPhone(string name, string phone);
        public abstract void RemovePhone(string name);
        public abstract void UpdatePhone(string name, string newphone);
        public abstract void SearchPhone(string name);
        public abstract void Sort();


    }
}
