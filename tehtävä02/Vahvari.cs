using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä02
{
    class Vahvari
    {
        private int volume = 1;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                // testataan onko voluumi sallittujen arvojen välissä
                if (value >= 0 && value <= 100) volume = value;
                else if (value < 0 ) Console.WriteLine("Too low volume - >");
                else if (value > 100) Console.WriteLine("Too much volume - >");
            }
        }

        // tulostusmetodi
        public void Tulostus()
        {
            Console.WriteLine("Amplifier volume is set to: " + volume);
        }
    }
}
