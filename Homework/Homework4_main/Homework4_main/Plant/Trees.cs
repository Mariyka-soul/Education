using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework4_main.Plant.NewFolder;

namespace Homework4_main.Plant
{
    internal class Tree : BasicPlant
    {
        public LeafType Leafs { get; protected set; }
        public enum LeafType
        {
            Needles,
            Leaf,
            LeafFlower,
        }

        public Tree(string name) : base(name)
        {

        }

        public override void Cut()
        {
            Height = 10;
        }
    }
}
