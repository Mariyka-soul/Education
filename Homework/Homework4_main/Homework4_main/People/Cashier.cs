using Homework4_main.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_main.People
{
    internal class Cashier : Employee
    {
        private Dictionary<string, Action<IVisitor>> operations;
        public List<IVisitor> Visitors { get; set; }

        public Cashier(string name, string surname, int age, double salary, ref List<IVisitor> people) : base(name, surname, age, salary)
        {
            operations = AddOperations();
            Visitors = people;
        }
        public override void Work(string operation)
        {
            IVisitor visitor = SelectVisitor();

            if (operations.ContainsKey(operation))
            {
                operations[operation].Invoke(visitor);
                Happiness--;
                Salary++;
            }
        }
        private IVisitor SelectVisitor()
        {
            throw new NotImplementedException();
        }
        private Dictionary<string, Action<IVisitor>> AddOperations()
        {
            var operationsDict = new Dictionary<string, Action<IVisitor>>();
            operationsDict.Add("Add visitor", AddVisitor);
            operationsDict.Add("Remove visitor", RemoveVisitor);
            return operationsDict;
        }
        private void RemoveVisitor(IVisitor visitor)
        {
            if (Visitors.Contains(visitor))
            {
                Visitors.Remove(visitor);
            }
        }
        private void AddVisitor(IVisitor visitor)
        {
            if (!Visitors.Contains(visitor))
            {
                Visitors.Add(visitor);
            }
        }

    }
}
