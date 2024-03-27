using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_main.Interface
{
    internal interface IPerson : IAlive, IBasic
    {
        string Surname { get; init; }
        void Damaged();
        void Walk();
    }
}
