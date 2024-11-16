using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Basic_13_L040
{
    internal class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public Person() { }
        public Person(int id, string? name, int age) 
        { 
            Id = id;
            Name = name;
            Age = age;
        }
    }
}