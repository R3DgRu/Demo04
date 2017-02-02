using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä01
{
    class Hissi
    {
        private int kerros = 1;
        public int Kerros
        {
            get
            {
                return kerros;
            }
            set
            {
                // testataan onko kerros sallittujen arvojen välissä
                if (value >= 1 && value <= 5) kerros = value;
                else if (value < 1) Console.WriteLine("Floor is too small");
                else if (value > 5) Console.WriteLine("Floor is too large");
            }
        }

        // tulostus metodi
        public void Tulostus() 
        {
            Console.WriteLine("Elevator is now in floor: " + kerros);
        }


    }
}
