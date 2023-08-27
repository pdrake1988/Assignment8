using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Sum
    {
        public int[] twoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.length; i++)
            {
                for (int j = i + 1; j < nums.length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        return new int[] { i, j };
                    }
                }
            }
            // In case there is no solution, we'll just return null
            return null;
        }
    }
}
