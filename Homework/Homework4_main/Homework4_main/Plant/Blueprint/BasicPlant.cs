using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_main.Plant.NewFolder
{
    internal abstract class BasicPlant : Plants
    {
        public double Height { get; protected set; }

        protected BasicPlant(string name) : base(name)
        {
            Height = 1;
        }

        public override void Grow()
        {
            Height++;
        }
    }
}
