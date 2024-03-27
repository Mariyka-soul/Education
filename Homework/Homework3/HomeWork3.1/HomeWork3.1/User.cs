using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3._1
{
    internal record User
    {
        public Guid UserId { get; set; }
        public string UserRole { get; set; }
    }
}
