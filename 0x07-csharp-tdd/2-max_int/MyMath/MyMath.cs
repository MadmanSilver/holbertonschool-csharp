using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary> Contains useful math methods. </summary>
    public class Operations
    {
        /// <summary> Finds the highest value in a list of ints. </summary>
        public static int Max(List<int> nums) {
            int max = int.MinValue;

            if (nums.Count == 0) {
                return 0;
            }

            foreach (int num in nums) {
                if (num > max) {
                    max = num;
                }
            }

            return max;
        }
    }
}
