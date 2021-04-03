using System;

class Leet1143
{
    static void Main()
    {
        string text1 = "addaadd";
        string text2 = "aaddbbb";

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

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                Console.Write(dp[i,j]+"  ");
            }
            Console.WriteLine("");
        }

        Console.ReadLine();
    }

}