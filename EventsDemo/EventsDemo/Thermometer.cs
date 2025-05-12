using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    internal class Thermometer
    {
        public delegate void OverheatHandler(string message);
        public event OverheatHandler Overheat;

    }
}
