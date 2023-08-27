using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Count
    {
        public void PrintCount(int[] ints)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (int i in ints)
            {
                if (dic.ContainsKey(i))
                {
                    dic[i]++;
                    Console.WriteLine(dic[i]);
                }
                else
                {
                    dic.Add(i, 1);
                    Console.WriteLine(dic[i]);
                }
            }
        }
    }
}
