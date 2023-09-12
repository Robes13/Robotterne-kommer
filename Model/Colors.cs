using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    internal class Colors
    {
        #region Fields

        private string _color;

        #endregion Fields

        #region Constructors

        public Colors(string color)
        {
            _color = color;
        }

        #endregion Constructors

        #region Properties

        public string Color 
        { 
            get { return _color; } 
            set { _color = value; } 
        }

        #endregion Properties
    }
}
