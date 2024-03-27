using Homework4_main.Interface;
using Homework4_main.Plant.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_main.Aviarys
{
    internal abstract class Aviary : IAviarys
    {
        public Guid Id { get; init; }
        public List<Plants> Plant { get; set; }
        public IAnimal Animal { get; set; }
        public double Lenght { get; init; }
        public double Width { get; init; }
        public bool Clean { get; set; }

        public Aviary(double lenght, double width, List<Plants> plants)
        {
            Id = Guid.NewGuid();
            Lenght = lenght;
            Width = width;
            Clean = true;
            Plant = plants;
        }
        protected abstract List<Plants> AddPlant(List<Plants> plants);
    }
}
