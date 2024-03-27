using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_main.Interface
{
    internal interface IAnimal : IAlive
    {
        double Weight { get; }
        int SleepHours { get; init; }

        void Drink(int kg);
        void Stroked(People.Person person);
        void Sleep(int hours);
        void Cleaned();
    }
}
