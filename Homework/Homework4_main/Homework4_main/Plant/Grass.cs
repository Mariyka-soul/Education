using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework4_main.Plant.NewFolder;

namespace Homework4_main.Plant
{
    internal class Grass : BasicPlant
    {
        public Grass(string name) : base(name)
        {
            Height = 0;
        }
        public override void Grow()
        {
            Height += 0.1;
        }
        public override void Cut()
        {
            Height = 0.1;
        }
    }
}
