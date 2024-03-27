using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_main.Interface
{
    internal interface IAlive
    {
        Guid Id { get; init; }
        string Name { get; init; }
        int Age { get; }
        int Happiness { get; }

        void Eat();
        void Grow();
    }
}
