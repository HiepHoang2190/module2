using System;
using System.Collections.Generic;
using System.Text;

namespace Inhertiance_TH
{
    class Shape
    {
        #region fields
        private string color = "green";
        private bool filled = true;

        #endregion

        #region constructor
        public Shape()
        {

        }
        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }
        #endregion

        #region public method
        public string GetColor()
        {
            return color;
        }
        public void SetColor(string color)
        {
            this.color=color;
        }
        public bool IsFilled()
        {
            return filled;
        }
        public void SetFilled(bool filled)
        {
            this.filled = filled;
        }
        public override String ToString()
        {
            return $"A Shape with color of {GetColor()}, " +
                $"and {IsFilled()}";
        }
        #endregion

        #region private method
        #endregion
    }
}
