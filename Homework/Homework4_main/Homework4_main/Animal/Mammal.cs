using Homework4_main.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_main.Animal
{
    internal abstract class Mammal : Animal, IBasic
    {
        protected Mammal(string name, int age, double weight) : base(name, age, weight)
        {

        }
        public virtual void Walk()
        {
            Weight--; ;
            Happiness++;
        }
    }
}
