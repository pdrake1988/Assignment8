using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Majority
    {
        public void Frequency(int[] ints)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach (int num in ints)
            {
                if (!counts.ContainsKey(num))
                {
                    counts.Add(num, 1);
                }
                else
                {
                    counts[num]++;
                    Console.WriteLine(counts[num]);
                }
            }
        }
    }
}
