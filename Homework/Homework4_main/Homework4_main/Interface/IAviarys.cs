using Homework4_main.Plant.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_main.Interface
{
    internal class IAviarys
    {
        Guid Id { get; init; }
        List<Plants> Plant { get; set; }
        IAnimal Animal { get; set; }
        double Lenght { get; init; }
        double Width { get; init; }
        bool Clean { get; set; }
    }
}
