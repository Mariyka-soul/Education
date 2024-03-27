using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_main.Plant.NewFolder
{
    internal abstract class Plants
    {
        public string Name { get; init; }
        protected Plants(string name)
        {
            Name = name;
        }
        public abstract void Grow();
        public abstract void Cut();
    }
}
