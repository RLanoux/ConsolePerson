using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsolePerson
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonGenerator parent = new PersonGenerator();

            Person Bob;
            Bob = parent.CreatePerson("Robert Baratheon" , "Male");
            
            Person Cersei;
            Cersei = parent.CreatePerson("Cersei Lannister" , "Female");

            Console.ReadLine();
        }
    }

    public class Person
    {

        public Person(String Name, String Gender)
        {
            this.Name = Name;
            this.Gender = Gender;
            Greet();
        }

        public string Name {get; set;}

        public string Gender {get; set;}

        public void Greet()
        {
            Console.WriteLine("Hello, " + Name + ". You are: " + Gender + ".");
        }
    }

    public class PersonGenerator
    {
        public Person CreatePerson(String Name, String Gender)
        {
            Person newPerson = new Person(Name , Gender);
            return newPerson;
        }
    }
}
