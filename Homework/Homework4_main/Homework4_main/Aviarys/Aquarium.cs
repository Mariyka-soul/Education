using Homework4_main.Animal;
using Homework4_main.Plant.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_main.Aviarys
{
    internal class Aquarium
    {
        public Fish.WaterType WaterType { get; init; }
        public List<Plants> Plant { get; }

        public Aquarium(double lenght, double width, List<Plants> plants, Fish.WaterType waterType) : base(lenght, width, plants)
        {
            WaterType = waterType;
            Plant = AddPlant(plants);
        }

        private List<Plants>? AddPlant(List<Plants> plants)
        {
            throw new NotImplementedException();
        }
    }
}
