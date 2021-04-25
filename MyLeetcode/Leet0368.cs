using System;
using System.Collections.Generic;

// 368. 最大整除子集

/*
给你一个由 无重复 正整数组成的集合 nums ，请你找出并返回其中最大的整除子集 answer ，子集中每一元素对 (answer[i], answer[j]) 都应当满足：
answer[i] % answer[j] == 0 ，或
answer[j] % answer[i] == 0
如果存在多个有效解子集，返回其中任何一个均可。

 
示例 1：
输入：nums = [1,2,3]
输出：[1,2]
解释：[1,3] 也会被视为正确答案。

示例 2：
输入：nums = [1,2,4,8]
输出：[1,2,4,8]

提示：
1 <= nums.length <= 1000
1 <= nums[i] <= 2 * 109
nums 中的所有整数 互不相同
 */
public class Leet0368
{
    public IList<int> LargestDivisibleSubset(int[] nums)
    {
        List<int> list = new List<int>();

        //排序
        int length = nums.Length;
        int num;
        for (int i = 0; i < length; i++)
        {
            for (int j = i; j < length; j++)
            {
                if (nums[i] > nums[j])
                {
                    num = nums[i];
                    nums[i] = nums[j];
                    nums[j] = num;
                }
            }
        }

        // 第 1 步：动态规划找出最大子集的个数、最大子集中的最大整数
        int[] dp = new int[length];
        int maxSize = 1;
        int maxVal = dp[0] = 1;
        for (int i = 1; i < length; i++)
        {
            dp[i] = 1;
            for (int j = 0; j < i; j++)
            {
                // 题目中说「没有重复元素」很重要
                if (nums[i]%nums[j] == 0)
                {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }

            if(dp[i] > maxSize)
            {
                maxSize = dp[i];
                maxVal = nums[i];
            }
        }

        // 第 2 步：倒推获得最大子集
        if(maxSize == 1)
        {
            list.Add(nums[0]);
            return list;
        }


        for (int i = length - 1; i >= 0; i--)
        {
            if(dp[i] == maxSize && maxVal %nums[i] == 0)
            {
                list.Add(nums[i]);
                maxVal = nums[i];
                maxSize--;
            }
        }

        return list;
    }
}