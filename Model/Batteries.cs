using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    internal class Batteries
    {
        #region Fields

        private bool _battery;

        #endregion Fields

        #region Constructors

        public Batteries(bool battery)
        {
            _battery = battery;
        }

        #endregion Constructors

        #region Properties
        public bool Battery 
        { 
            get { return _battery; } 
            set { _battery = value; } 
        }
        #endregion Properties
    }
}
