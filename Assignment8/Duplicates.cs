using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Duplicates
    {
        public void FindDups(int[] ints)
        {
            Dictionary<int, int> intMap = new Dictionary<int, int>();
            foreach (int i in ints)
            {
                if (!intMap.ContainsKey(i))
                {
                    intMap.Add(i, 1);
                }
                else if (intMap[i] == 1)
                {
                    Console.WriteLine(intMap[i]);
                }
            }
        }
    }
}
