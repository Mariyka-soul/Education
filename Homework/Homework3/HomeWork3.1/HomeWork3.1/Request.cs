using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3._1
{
    internal record Request
    {
        public string Name { get; set; }
        public DateTime Timestamp { get; set; }
        public Data Data { get; set; }
        public User Sender { get; set; }
    }
}
