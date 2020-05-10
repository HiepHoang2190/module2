﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inhertiance_TH
{
    class Square:Rectangle
    {
        #region fields
       
        #endregion

        #region constructor
        public Square()
        {

        }
        public Square(double side) : base(side, side)
        {

        }
        public Square(double side,String color,bool filled) : base(side, side, color, filled)
        {

        }
        public double GetSide()

        {

            return GetWidth();
            

        }
        public void SetSide(double side)

        {

            SetWidth(side);

            SetLength(side);

        }
        public override void SetWidth(double width)
        {
            SetSide(width);
        }

        public override void SetLength(double length)
        {
            SetSide(length);
        }
        public override String ToString()
        {
            return $"A Square with side= {GetSide()}, which is a subclass of { base.ToString()}";
        }
        #endregion

        #region public method
        #endregion

        #region private method
        #endregion
    }
}
