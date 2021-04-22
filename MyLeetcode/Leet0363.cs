using System;
using System.Collections.Generic;

// 363. 矩形区域不超过 K 的最大数值和

/*
给你一个 m x n 的矩阵 matrix 和一个整数 k ，找出并返回矩阵内部矩形区域的不超过 k 的最大数值和。
题目数据保证总会存在一个数值和不超过 k 的矩形区域。

示例 1：
输入：matrix = [[1,0,1],[0,-2,3]], k = 2
输出：2
解释：蓝色边框圈出来的矩形区域 [[0, 1], [-2, 3]] 的数值和是 2，且 2 是不超过 k 的最大数字（k = 2）。

示例 2：
输入：matrix = [[2,2,-1]], k = 3
输出：3
 
提示：
m == matrix.length
n == matrix[i].length
1 <= m, n <= 100
-100 <= matrix[i][j] <= 100
-105 <= k <= 105
 
进阶：如果行数远大于列数，该如何设计解决方案？

 */
public class Leet0363
{
    public int MaxSumSubmatrix(int[][] matrix, int k)
    {
        int n = matrix.Length;
        int m = matrix[0].Length;
        int[,] sum = new int[n + 1, m + 1];
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= m; j++)
            {
                sum[i, j] = sum[i - 1, j] + sum[i, j - 1] - sum[i - 1, j - 1] + matrix[i - 1][j - 1];
            }
        }
        int ans = int.MinValue;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= m; j++)
            {
                for (int p = i; p <= n; p++)
                {
                    for (int q = j; q <= m; q++)
                    {
                        int cur = sum[p, q] - sum[i - 1, q] - sum[p, j - 1] + sum[i - 1, j - 1];
                        if (cur <= k)
                        {
                            ans = Math.Max(ans, cur);
                        }
                    }
                }
            }
        }
        return ans;
    }
}