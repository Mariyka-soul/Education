using Homework4_main.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_main.People
{
    internal abstract class Employee : Person, IEmployee
    {
        protected Dictionary<string, Action<IAnimal>> operations;
        public double Salary { get; set; }

        protected Employee(string name, string surname, int age, double salary) : base(name, surname, age)
        {
            Salary = salary;
        }

        public abstract void Work(string operation);
    }
}
