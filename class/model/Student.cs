using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance.Model
{
    class Student
    {
        public string name;
        public string surname;
        public int age;
        public void FullName()
        {
            Console.WriteLine($"{name} {age} {surname}");

        }
    }
}
