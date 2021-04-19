using System;

// 1143. �����������

/*
 ���������ַ��� text1 �� text2�������������ַ������ ���������� �ĳ��ȡ���������� ���������� ������ 0 ��

һ���ַ����� ������ ��ָ����һ���µ��ַ�����������ԭ�ַ����ڲ��ı��ַ������˳��������ɾ��ĳЩ�ַ���Ҳ���Բ�ɾ���κ��ַ�������ɵ����ַ�����

���磬"ace" �� "abcde" �������У��� "aec" ���� "abcde" �������С�
�����ַ����� ���������� ���������ַ�������ͬӵ�е������С�

 
ʾ�� 1��
���룺text1 = "abcde", text2 = "ace" 
�����3  
���ͣ�������������� "ace" �����ĳ���Ϊ 3 ��

ʾ�� 2��
���룺text1 = "abc", text2 = "abc"
�����3
���ͣ�������������� "abc" �����ĳ���Ϊ 3 ��

ʾ�� 3��
���룺text1 = "abc", text2 = "def"
�����0
���ͣ������ַ���û�й��������У����� 0 ��
 
��ʾ��
1 <= text1.length, text2.length <= 1000
text1 �� text2 ����СдӢ���ַ����
 */


public class Leet1143
{
    private int LongestCommonSubsequence(string text1,string text2)
    {
        int row = text1.Length + 1;
        int column = text2.Length + 1;

        int[,] dp = new int[row, column];

        char[] charArray1 = text1.ToCharArray();
        char[] charArray2 = text2.ToCharArray();

        for (int i = 1; i < row; i++)
        {
            char char1 = charArray1[i - 1];
            for (int j = 1; j < column; j++)
            {
                char char2 = charArray2[j - 1];
                if (char1 == char2)
                {
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }

        return dp[row - 1, column - 1];
    }

}