using Homework4_main.Plant.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_main.Plant
{
    internal class Daisies : Flowers
    {
        public Daisies(string name) : base(name)
        {
            Height = 1; 
        }

        public bool HasPollenCenters { get; set; }

        public override string BloomType  
        {
            get { return "Composite Bloom"; } 
        }
        public override void Grow()
        {
            Height += 0.1;
        }

        public override void Cut()
        {
            Height = 2;
        }
    }
}
