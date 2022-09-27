﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges;

internal class AlgorithmI
{
    public static int BinarySearch(int[] nums, int target)
    {
        //[-1,0,3,5,9,12], target = 9
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            if (nums[mid] < target)
                left = mid + 1;
            if (nums[mid] > target)
                mid = right - 1;
        }
        return -1;

        /*     var result = -1;
        // [-1,0,3,5,9,12], target = 9

        var low = 0;
        var high = nums.Length - 1;
        var mid = 0;

        while (high - low > 1)
        {
            mid = (high + low) / 2;
            if (nums[mid] < target)
            {
                low = mid + 1;
            }
            else
                high = mid;
        }

        if (nums[low] == target)
        {
            result = low;
        }
        else if (nums[high] == target)
        {
            result = high;
        }

        return result;
        */

    }

    public int FirstBadVersion(int n)
    {
        int low = 0;
        int high = n;

        while (low < high)
        {
            int mid = low + (high - low) / 2;
            if (Level1.IsBadVersion(mid))
            {
                high = mid;
            }
            else
            {
                low = mid + 1;
            }
        }

        return low;
    }

    //35. Search Insert Position
    public int SearchInsert(int[] nums, int target)
    {
        if (nums == null || nums.Length == 0)
            return -1;

        int i = 0,
            j = nums.Length - 1;

        while (i <= j)
        {
            int m = j + (i - j) / 2;

            if (nums[m] == target)
                return m;
            else if (nums[m] < target)
                i = m + 1;
            else
                j = m - 1;
        }

        return i;
    }

    //509. Fibonacci Number
    public int Fib(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        return Fib(n - 1) + Fib(n - 2);
    }

}