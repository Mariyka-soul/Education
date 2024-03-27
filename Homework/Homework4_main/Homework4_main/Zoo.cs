using Homework4_main.Aviarys;
using Homework4_main.Interface;
using Homework4_main.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_main
{
    internal class Zoo
    {
        public List<IEmployee> Employees { get; set; }
        public List<IAnimal> Animals { get; set; }
        public List<IVisitor> Visitors { get; set; }
        public List<Aviary> Aviaries { get; set; }

        public void AddAnimal(IAnimal animal, Aviary aviary)
        {
            Aviaries.Add(aviary);
            Animals.Add(animal);
        }
        public void AddCashire(string name, string surname, int age, double salary)
        {
            var employee = new Cashier(name, surname, age, salary, ref Visitors);
            Employees.Add(employee);
        }
      
        public void AddFeeder(string name, string surname, int age, double salary)
        {
            var employee = new Feeder(name, surname, age, salary, ref Animals);
            Employees.Add(employee);
        }
       
    }
}
