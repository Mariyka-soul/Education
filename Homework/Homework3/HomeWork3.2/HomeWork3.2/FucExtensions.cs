using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3._2
{
    internal static class FucExtensions
    {
        public static void WriteCollection(this IEnumerable<int> nums)
        {
            foreach (var item in nums)
            {
                Console.Write(item+ " ");
            }
            Console.WriteLine();
        }
    }
}
