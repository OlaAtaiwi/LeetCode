using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems
{
    class SearchInsertPosition
    {
        public static int SearchInsert(int[] nums, int target)
        {
            //i will use binary search for time complixity constrain
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] == target) return mid;
                else if (nums[mid] > target) right = mid - 1;
                else left = mid + 1;
            }
            return left;
        }
    }
}
