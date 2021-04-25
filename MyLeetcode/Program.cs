using System;

namespace MyLeetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //var leet = new Leet0087();
            //var _boo = leet.IsScramble("abc","cba");

            //var leet = new Leet0220();
            //var _boo = leet.ContainsNearbyAlmostDuplicate(new int[] { -2147483648, 2147483647}, 1, 1);

            //var leet = new Leet0368();
            //var list = leet.LargestDivisibleSubset(new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            
            var leet = new Leet0377();
            var list = leet.CombinationSum4(new int[] { 1,2,3 },4);
        }
    }
}
