using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_main.Interface
{
    internal interface IVisitor : IPerson
    {
        void InteractWithAnimals(string operation, IAnimal animal);
    }
}
