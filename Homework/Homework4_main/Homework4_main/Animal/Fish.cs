using Homework4_main.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_main.Animal
{
    internal abstract class Fish : Animal
    {
        public List<WaterType> WaterTypes { get; init; }

        protected Fish(string name, int age, double weight) : base(name, age, weight) => SleepHours = 1;
        public enum WaterType
        {
            Tapwater,
            Freshwater,
            Saltwater
        }
        public void Sweam()
        {
            Happiness++;
            Weight--;
        }
        public void Stroked(Person person)
        {
            Happiness--;
        }
    }
}
