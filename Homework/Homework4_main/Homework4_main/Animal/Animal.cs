using Homework4_main.Interface;
using Homework4_main.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_main.Animal
{
    internal abstract class Animal : IAnimal
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public double Weight { get; protected set; }
        public int Age { get; protected set; }
        public int Happiness { get; protected set; } = 0;
        public int SleepHours { get; init; }

        protected Animal(string name, int age, double weight)
        {
            Id = Guid.NewGuid();
            Name = name;
            Age = age;
            Weight = weight;
        }
        public void Cleaned()
        {
            Happiness++;
        }
        public void Drink(int kg)
        {
            Happiness++;
            Weight += kg;
        }
        public virtual void Eat()
        {
            Happiness++;
            Weight++;
        }
        public virtual void Stroked(Person person)
        {
            Happiness++;
        }
        public virtual void Grow()
        {
            Age += 1;
            Weight += 10;
        }
        public void Sleep(int hours)
        {
            if (hours == SleepHours)
            {
                Happiness++;
            }
            else
            {
                Happiness--;
            }
        }
    }
}
