using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä03
{
    class Employee // työntekijäluokka
    {
        public string name { get;set;}
        public string profession { get; set; }
        public int salary { get; set; }

        public void employee_tulostus() // tulostusmetodi
        {
            Console.WriteLine("Employee:");
            Console.WriteLine("- Name: " + name + " " + "Profession: " + profession + " " + "Salary: " + salary  + " ");
        }


    }
}
