using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä02
{
    class Program
    {
        static void Main(string[] args)
        {
            Vahvari vahvistin = new Vahvari(); // luodaan uusi vahvistin

            int number = 1; // oletusvoluumi vahvistimelle on 1

            while (number != 0) // silmukka kysyy käyttäjältä sopivaa äänenvoimakkuutta kunnes hän syöttää nollan
            {
                Console.Write("Give a new volume value (0-100, 0 to exit) > ");
                string line = Console.ReadLine();
                bool result = int.TryParse(line, out number);

                vahvistin.Volume = number;
                vahvistin.Tulostus();
            }
        }
    }
}
