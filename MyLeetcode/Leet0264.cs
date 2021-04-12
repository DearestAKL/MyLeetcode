using System;

// 264. 丑数 II 

/*
给你一个整数 n ，请你找出并返回第 n 个 丑数 。
丑数 就是只包含质因数 2、3 和/或 5 的正整数。

示例 1：
输入：n = 10
输出：12
解释：[1, 2, 3, 4, 5, 6, 8, 9, 10, 12] 是由前 10 个丑数组成的序列。

示例 2：
输入：n = 1
输出：1
解释：1 通常被视为丑数。
 
提示：
1 <= n <= 1690
 */
class Leet0264
{
    //static void Main()
    //{
    //    //FindMin(new int[] { 4, 5, 6, 7, 0, 1, 2 });
    //    //MyFindMin(new int[] { 3, 4, 5, 1, 2 });
    //    NthUglyNumber(10);
    //}

    public static int NthUglyNumber(int n)
    {
        int[] array = new int[n];
        array[0] = 1;

        int i2 = 0, i3 = 0, i5 = 0;
        for (int index = 1; index < n; index++)
        {
            int a = array[i2] * 2, b = array[i3] * 3, c = array[i5] * 5;

            int min = Math.Min(Math.Min(a, b), c);

            if(min == a)
            {
                i2++;
            }
            if(min == b)
            {
                i3++;
            }
            if (min == c)
            {
                i5++;
            }

            array[index] = min;
        }

        return array[n - 1];
    }
}