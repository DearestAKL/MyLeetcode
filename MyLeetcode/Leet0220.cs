using System;
using System.Collections.Generic;

// 220. 存在重复元素 III

/*
给你一个整数数组 nums 和两个整数 k 和 t 。请你判断是否存在两个下标 i 和 j，使得 abs(nums[i] - nums[j]) <= t ，同时又满足 abs(i - j) <= k 。
如果存在则返回 true，不存在返回 false。

示例 1：
输入：nums = [1,2,3,1], k = 3, t = 0
输出：true

示例 2：
输入：nums = [1,0,1,1], k = 1, t = 2
输出：true

示例 3：
输入：nums = [1,5,9,1,5,9], k = 2, t = 3
输出：false
 
提示：
0 <= nums.length <= 2 * 104
-231 <= nums[i] <= 231 - 1
0 <= k <= 104
0 <= t <= 231 - 1
 */
public class Leet0220
{
    //public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
    //{
    //    int length = nums.Length;
    //    long num1;
    //    long num2;
    //    for (int i = 0; i < length - 1; i++)
    //    {
    //        num1 = nums[i];
    //        int count = Math.Min(i + k, length - 1);
    //        for (int j = i+1; j <= count; j++)
    //        {
    //            num2 = nums[j];
    //            if(Math.Abs(num1-num2) <= t)
    //            {
    //                return true;
    //            }
    //        }
    //    }

    //    return false;
    //}

    public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
    {
        int n = nums.Length;
        // 使用map维护桶
        Dictionary<long, long> map = new Dictionary<long, long>();
        // 设定桶的大小
        long w = (long)t + 1;
        for (int i = 0; i < n; i++)
        {
            // 获取桶的编号
            long id = GetID(nums[i], w);

            // 加入到的是相同的桶
            if (map.ContainsKey(id))
            {
                return true;
            }

            // 向前一个桶比较
            if (map.ContainsKey(id - 1)&&Math.Abs(nums[i] - map[id - 1]) < w)
            {
                return true;
            }

            // 向后一个桶比较
            if (map.ContainsKey(id + 1) && Math.Abs(nums[i] - map[id + 1]) < w)
            {
                return true;
            }

            // 往桶中加入元素
            map[id] = (long)nums[i];

            // 移除k个元素之前插入的数
            if (i >= k)
            {
                map.Remove(GetID(nums[i - k], w));
            }
        }

        return false;
    }

    public long GetID(long x,long w)
    {
        if (x >= 0)
        {
            return x / w;
        }

        return (x + 1) / w - 1;
    }

}