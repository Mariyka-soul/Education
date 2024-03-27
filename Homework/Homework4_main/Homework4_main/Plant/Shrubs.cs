using Homework4_main.Plant.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_main.Plant
{
    internal class Shrubs : BasicPlant
    {
        public Shrubs(string name) : base(name)
        {
            Height = 5;
        }

        public override void Cut()
        {
            throw new NotImplementedException();
        }
    }
}
