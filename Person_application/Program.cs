using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_application
{
    class Program
    {
        static void Main(string[] args)
        {
            // create one teacher from Teacher class
            Teacher teacher = new Teacher();
            teacher.Firstname = "Kirsi";
            teacher.Lastname = "Kernel";
            teacher.Age = 30;
            teacher.Address = "Piippukatu 2";
            teacher.Phonenumber = "010-1352349";
            teacher.Room = "D444";
            Console.WriteLine(teacher.ToString());

            // create one student from Student class
            Student student = new Student("Matti", "Mallikas", "H43049");
            student.Address = "Kirkkokatu";
            student.Age = 20;
            student.Phonenumber = "040-5673806";
            Console.WriteLine(student.ToString());

            teacher.TeacherMethod();
            student.StudentMethod();
        }
    }
}
