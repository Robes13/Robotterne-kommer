using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    /// <summary>
    /// This class is responsible for setting the rules when we want to create a new robot. 
    /// There is a default robot that will be "constructed" if no parameters is given. 
    /// </summary>
    internal class Robots
    {
        #region Fields

        private bool _chipSweep;
        private bool _chipQT8339;
        private bool _chipRX54667;
        private bool _wifiChip;
        private bool _white;
        private Colors _colored;
        private Batteries _battery;
        #endregion Fields

        #region Constructers

        public Robots() // Default is white, can sweep and has a battery.
        {
            bool battery = true;
            Batteries batteries = new Batteries(battery);
            battery = batteries.Battery;
            _chipSweep = true;
            _white = true;
            _battery = batteries;
        }

        public Robots(string color) : this() // The one after defualt can still sweep, but has no battery - as it is colored.
        {
            Colors colors = new Colors(color);
            colors.Color = color;
            _chipSweep = true;
            _colored = colors;
        }

        public Robots(string color, bool wifiChip) : this()// The one after is still colored, but is this time installed with a wifi chip, and can sweep. (still no battery)
        {
            Colors colors = new Colors(color);
            _chipSweep = true;
            colors.Color = color;
            _wifiChip = wifiChip;
            _colored = colors;
        }

        public Robots(bool wifiChip, bool battery) : this() // This one is white, has a battery, has wifi and can sweep.
        {
            Batteries batteries = new Batteries(battery);
            battery = batteries.Battery;
            _white = true;
            _chipSweep = true;
            _wifiChip = wifiChip;
            _battery = batteries;
        }

        public Robots(bool wifichip, bool white, bool ChipQT8339) : this() // This one can clean windows, is white, and has wifi.
        {
            if (white)
            {
                _wifiChip = wifichip;
                _chipSweep = true;
                _white = white;
                ChipQT8339 = true;

            }
            else
            {
                white = true;
                _wifiChip = wifichip;
                _chipSweep = true;
                _white = white;
                ChipQT8339 = true;
            }
        }

        public Robots(bool wifiChip, bool white, bool ChipQT8339, bool chipRX54667) : this() // This one can change tires, is white, and has wifi.
        {

            if (!ChipQT8339)
            {
                _chipSweep = true;
                _white = white;
                _wifiChip = wifiChip;
                chipRX54667 = true;
            }
            else
            {
                ChipQT8339 = false;
                _chipSweep = true;
                _white = white;
                _wifiChip = wifiChip;
                chipRX54667 = true;
            }
        }

        public Robots(bool wifiChip, string color, bool ChipQT8339) : this() // This one can clean windows, is colored and has wifi.
        {
            Colors colors = new Colors(color);
            _chipSweep = true;
            colors.Color = color;
            _wifiChip = wifiChip;
            _chipQT8339 = ChipQT8339;
            _colored = colors;
        }

        public Robots(bool wifiChip, string color, bool ChipQT8339, bool chipRX54667) : this() // This one can change tires, is colored and has wifi.
        {
            if(!ChipQT8339)
            {
                Colors colors = new Colors(color);
                _chipSweep = true;
                colors.Color = color;
                _wifiChip = wifiChip;
                _chipQT8339 = ChipQT8339;
                _colored = colors;
            }
            else
            {
                ChipQT8339 = false;
                Colors colors = new Colors(color);
                _chipSweep = true;
                colors.Color = color;
                _wifiChip = wifiChip;
                _chipQT8339 = ChipQT8339;
                _colored = colors;
            }
        }

        #endregion Constructers

        #region Properties

        public bool SweepModule
        {
            get { return _chipSweep; }
            set { _chipSweep = value; }
        }

        public bool ChipQT8339
        {
            get { return _chipQT8339; }
            set { _chipQT8339 = value; }
        }

        public bool ChipRX54667
        {
            get { return _chipRX54667; }
            set { _chipRX54667 = value; }
        }

        public bool WifiChip
        {
            get { return _wifiChip; }
            set { _wifiChip = value; }
        }

        public bool White
        {
            get { return _white; }
            set { _white = value; }
        }

        public Colors Color
        {
            get { return _colored; }
            set { _colored = value; }
        }

        public Batteries Batteries
        {
            get { return _battery; }
            set { _battery = value; }
        }

        #endregion Properties
    }
}
