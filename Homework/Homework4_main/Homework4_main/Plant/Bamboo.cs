using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_main.Plant
{
    internal class Bamboo : Grass
    {
        public Bamboo(string name) : base(name)
        {
            Height = 10;
        }

        public override void Grow()
        {
            Height += 10;
        }
    }
}
