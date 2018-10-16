﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap4
{
    class Person
    {
        private string name;
        private int age;
        private string nationality;
        
        public Person() { }

        public Person(string name, int age, string nation)
        {
            this.name = name;
            this.age = age;
            this.nationality = nation;
        }
        
        public void Display()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Age: " + this.age);
            Console.WriteLine("Nationality: " + this.nationality);
        }

    }
}
