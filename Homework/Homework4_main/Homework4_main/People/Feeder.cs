using Homework4_main.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_main.People
{
    internal class Feeder : Employee
    {
        private Dictionary<string, Action<IAnimal>> operations;
        private List<IAnimal> Animals { get; set; }

        public Feeder(string name, string surname, int age, double salary, List<IAnimal> animals) : base(name, surname, age, salary)
        {
            Animals = animals;
            operations = AddOperations();
        }
        public override void Work(string operation)
        {
            foreach (var animal in Animals)
            {
                if (operations.ContainsKey(operation))
                {
                    operations[operation].Invoke(animal);
                }
            }
        }
        private Dictionary<string, Action<IAnimal>> AddOperations()
        {
            var operationsDict = new Dictionary<string, Action<IAnimal>>();
            operationsDict.Add("clean", Feed);

            return operationsDict;
        }
        private void Feed(IAnimal animal)
        {
            animal.Eat();
        }

    }
}
