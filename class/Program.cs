using System;
using ClassInheritance.Model;

namespace ClassInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //var telebe1 = new
            //{

            //    name = "Anar",
            //    surname = "Qandayev",
            //    AggregateException = 21,

            //};
            //var telebe2 = new
            //{
            //    name = "Asgar",
            //    surname = "Babayev",
            //    age = 20,

            //};
            //Console.WriteLine(telebe1);
            //FullName(telebe1.name, telebe1.surname);
            ////FullName(telebe2.name, telebe2.surname);
            //Student names = new Student();
            //names.name = "Anar";
            //names.surname = "Qandayev";
            //names.age = 21;
            //Console.WriteLine(names.age);
            //Student names = new Student { name = "Aziz", surname = "Abdullayev" };
            Student names = new Student();
            names.name = "Anar";
            names.surname = "Gandayev";
            names.age = 21;
            names.FullName();

            //names.FullName();
        }
        //static void FullName(string name, string surname)
        //{
        //    //Console.WriteLine(name + " " + surname);
           
        //}



    }
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
