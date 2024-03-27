using Homework4_main.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_main.People
{
    internal class Boss : Employee
    {
        public Zoo Zoo { get; set; }
        Dictionary<string, Action<string, string, int, double>> positionsDict;

        public Boss(string name, string surname, int age, double salary, Zoo zoo) : base(name, surname, age, salary)
        {
            Zoo = zoo;
        //    positionsDict = AddPositions();
        }
        public override void Work(string operation)
        {
            Happiness++;
            Salary += 10;
        }
        public void AddEmployeer(string position, string name, string surname, int age, double salary)
        {
            if (positionsDict.ContainsKey(position))
            {
                positionsDict[position].Invoke(name, surname, age, salary);
            }
        }
        public void RemoveEmployeer(IEmployee employee)
        {
            Zoo.Employees.Remove(employee);
        }
        //public void AddAnimal(IAnimal animal, IAviarys aviary)
        //{

        //    if (animal is IBasic && aviary is Cage cage)
        //    {
        //        cage.Animal = animal;
        //        Zoo.AddAnimal(animal, cage);
        //    }
        //    else if (animal is Fish && aviary is Aquarium aquarium)
        //    {
        //        aquarium.Animal = animal;
        //        Zoo.AddAnimal(animal, aquarium);
        //    }
        //}
        public void RemoveAnimal(IAnimal animal)
        {
            Zoo.Animals.Remove(animal);
        }
        //private Dictionary<string, Action<string, string, int, double>> AddPositions()
        //{
        //    var operationsDict = new Dictionary<string, Action<string, string, int, double>>();
        //    operationsDict.Add("cashire", Zoo.AddCashire);
        //    operationsDict.Add("feeder", Zoo.AddFeeder);
        //    operationsDict.Add("gardener", Zoo.AddGardener);
        //    operationsDict.Add("cleaner", Zoo.AddCashire);

        //    return operationsDict;
        //}
    }
}
