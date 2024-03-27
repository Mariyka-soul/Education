using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_main.Interface
{
    internal interface IEmployee : IPerson
    {
        double Salary { get; set; }
        void Work(string operation);
    }
}
