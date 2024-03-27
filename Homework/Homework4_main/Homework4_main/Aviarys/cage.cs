using Homework4_main.Plant.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_main.Aviarys
{
    internal class Cage : Aviary
    {
        public Cage(double lenght, double width, List<Plants> plant) : base(lenght, width, plant)
        {
        }

        protected override List<Plants> AddPlant(List<Plants> plants)
        {
            throw new NotImplementedException();
        }
    }
}
