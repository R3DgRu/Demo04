using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä01
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi();

            int number = 1;

            while (number != 0) // silmukka kysyy käyttäjältä kerrosta kunnes hän syöttää nollan
            {
                Console.Write("Give a floor number (1-5, 0 to exit) > ");
                string line = Console.ReadLine();
                bool result = int.TryParse(line, out number);

                hissi.Kerros = number;
                hissi.Tulostus();
            }

        }
    }
}
