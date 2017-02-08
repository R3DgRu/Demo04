using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä03
{
    class Boss // pomoluokka
    {
        public string nimi { get; set; }
        public string ammatti { get; set; }
        public int palkka { get; set; }
        public string auto { get; set; }
        public int bonus { get; set; }

        public void boss_tulostus() // tulostusmetodi
        {
            Console.WriteLine("Boss:");
            Console.WriteLine("- Name: " + nimi + " " + "Profession: " + ammatti + " " + "Salary: " + palkka + " " + "Car: " + auto + " " + "Bonus: " + bonus);
        }
    }
}
