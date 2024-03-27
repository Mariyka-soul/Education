using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_main.Plant.NewFolder
{
    internal abstract class Flowers : BasicPlant
    {
        public abstract string BloomType { get; }

        public Flowers(string name) : base(name)
        {
            Height = 3;
        }

        public override void Cut()
        {
            Height = 1;
        }
    }
}
