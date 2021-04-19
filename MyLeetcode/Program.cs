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

            var leet = new Leet0220();
            var _boo = leet.ContainsNearbyAlmostDuplicate(new int[] { -2147483648, 2147483647}, 1, 1);
        }
    }
}
