using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä03
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); // luodaan työntekijä
            // täytetään työntekijän tiedot
            employee.name = "Pertti Perusjamppa";
            employee.profession = "siivooja";
            employee.salary = 1500;

            employee.employee_tulostus(); // tulostetaan työntekijän tiedot

            Boss boss = new Boss(); // luodaan pomo
            // täytetään pomon tiedot
            boss.nimi = "Kroisos Porhola";
            boss.ammatti = "CEO";
            boss.palkka = 20000;
            boss.auto = "Pagani Huayra";
            boss.bonus = 15000;

            boss.boss_tulostus(); // tulostaa pomon tiedot
        }
    }
}
