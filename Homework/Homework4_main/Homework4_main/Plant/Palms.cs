using Homework4_main.Plant.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_main.Plant
{
    internal class Palms : BasicPlant
    {
        public bool HasCoconuts { get; set; }

        public Palms(string name) : base(name)
        {
            Height = 50;
        }
        public override void Grow()
        {
            Height += 0.2;
        }
        public override void Cut()
        {
            Height -= 30;
        }
    }
}
