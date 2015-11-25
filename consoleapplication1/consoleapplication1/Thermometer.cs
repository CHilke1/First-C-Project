using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    float temperature;
    class Thermometer : Instrument
    {
        public void Thermometer(object)
        {
            return object.temperature;
        }

        public void Fahrenheit(temp)
        {
            temperature = temp * (9 / 5) + 32;
            return temperature;
        }

        public void Celsius(temp)
        {
            temperature = temp * 1.8 + 32;
            return temperature;
        }
    }
}
