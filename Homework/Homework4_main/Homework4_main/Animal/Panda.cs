using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_main.Animal
{
    internal class Panda : Mammal
    {
        protected Panda(string name, int age, double weight) : base(name, age, weight)
        {
            SleepHours = 18;
        }
        public override void Walk()
        {
            Weight -= 2;
            Happiness--;
        }
        public override void Eat()
        {
            base.Eat();
            Happiness++;
        }
    }
}
