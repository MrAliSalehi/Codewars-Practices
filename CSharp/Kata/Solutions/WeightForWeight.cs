//https://www.codewars.com/kata/55c6126177c9441a570000cc/train/csharp
//https://www.codewars.com/users/MrAliSalehi/


using System.Globalization;

namespace Kata.Solutions
{
    internal class WeightForWeight : IKata
    {
        /// <inheritdoc />
        public void Solution()
        {
            var answer = OrderWeight("2000 10003 1234000 44444444 9999 11 11 22 123");
        }

        private static string OrderWeight(string str)
        {
            return str.Split(' ')
                .OrderBy(numInStr => numInStr.Sum(ch => CharUnicodeInfo.GetDecimalDigitValue(ch)))
                .ThenBy(p => p)
                .Aggregate("", (current, s) => current + (s + " "));
        }

    }
}
