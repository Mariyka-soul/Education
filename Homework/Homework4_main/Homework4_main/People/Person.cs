using Homework4_main.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_main.People
{
    internal abstract class Person : IPerson
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public string Surname { get; init; }
        public int Age { get; private set; }
        public int Happiness { get; protected set; } = 0;

        public Person(string name, string surname, int age)
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Age = age;
        }
        public void Drink(int kg)
        {
            Happiness++;
        }
        public void Eat()
        {
            Happiness++;
        }
        public void Grow()
        {
            Age++;

            if (Age > 20)
            {
                Happiness -= 10;
            }
            else
            {
                Happiness += 10;
            }
        }
        public void Damaged()
        {
            Happiness -= 10;
        }
        public void Walk()
        {
            Happiness--;
        }
    }
}
