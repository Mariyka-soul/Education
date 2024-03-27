using Homework4_main.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_main.People
{
    internal class Visitor : Person, IVisitor
    {
        protected Dictionary<string, Action<IAnimal>> operations;
        public VisitorType Type { get; protected set; }
        public enum VisitorType
        {
            Standart,
            Premium,
            Gold,
        }

        public Visitor(string name, string surname, int age) : base(name, surname, age)
        {
            operations = AddOperations();
            Type = VisitorType.Standart;
        }
        public void InteractWithAnimals(string operation, IAnimal animal)
        {
            operations[operation].Invoke(animal);
        }
        protected void WatchAnimal(IAnimal animal)
        {
            Happiness++;
        }
        protected virtual Dictionary<string, Action<IAnimal>> AddOperations()
        {
            var operationsDict = new Dictionary<string, Action<IAnimal>>();
            operationsDict.Add("watch animal", WatchAnimal);

            return operationsDict;
        }

    }
}
