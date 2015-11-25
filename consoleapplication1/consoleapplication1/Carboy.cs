using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Carboy : Fermentation_Vessel(Wort)
    float gallons;
    bool sterlized;
    {
        public void Carboy()
        {
            sterilized = false;
        }

        public bool sterlize()
        {
            sterlized = true;
        }
        public bool isSterlized()
        {
            return sterlized;
        }
        
    }
}
