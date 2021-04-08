using System;

// 88. 合并两个有序数组 

/*
给你两个有序整数数组 nums1 和 nums2，请你将 nums2 合并到 nums1 中，使 nums1 成为一个有序数组。
初始化 nums1 和 nums2 的元素数量分别为 m 和 n 。你可以假设 nums1 的空间大小等于 m + n，这样它就有足够的空间保存来自 nums2 的元素。


示例 1：
输入：nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
输出：[1,2,2,3,5,6]

示例 2：
输入：nums1 = [1], m = 1, nums2 = [], n = 0
输出：[1]
 
提示：
nums1.length == m + n
nums2.length == n
0 <= m, n <= 200
1 <= m + n <= 200
-109 <= nums1[i], nums2[i] <= 109
 */
class Leet0088
{
    //static void Main()
    //{
    //    int[] nums1 = { 1, 2, 3, 0, 0, 0 };
    //    int[] nums2 = { 2, 5, 6 };
    //    MyMerge(nums1, 3, nums2, 3);
    //}

    public static void MyMerge(int[] nums1, int m, int[] nums2, int n)
    {
        int tail = m + n - 1;
        int p1 = m - 1;
        int p2 = n - 1;
        int cur;

        for (int i = p2; i >= 0; i--)
        {
            cur = nums2[i];

            for (int j = p1; j >= 0; j--)
            {
                if(nums1[j] >= cur)
                {
                    p1--;
                    nums1[tail--] = nums1[j];
                }
                else
                {
                    break;
                }
            }

            nums1[tail--] = cur;
        }

        //for (int i = 0; i < m+n; i++)
        //{
        //    Console.WriteLine(nums1[i]);
        //}

        //Console.ReadLine();
    }

    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int p1 = m - 1, p2 = n - 1;
        int tail = m + n - 1;
        int cur;
        while(p1 >= 0 || p2 >= 0)
        {
            if(p1 == -1)
            {
                cur = nums2[p2--];
            }
            else if(p2 == -1)
            {
                cur = nums1[p1--];
            }
            else if (nums1[p1] > nums2[p2])
            {
                cur = nums1[p1--];
            }
            else
            {
                cur = nums2[p2--];
            }
            nums1[tail--] = cur;
        }
    }
}