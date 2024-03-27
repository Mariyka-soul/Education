using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework4_main.Plant.NewFolder;

namespace Homework4_main.Plant
{
    internal class Roses : Flowers
    {
        public bool HasThorns { get; set; }
        public Color Color { get; set; }

        public Roses(string name) : base(name)
        {
            Height = 4;
        }

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
