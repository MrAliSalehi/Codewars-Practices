namespace Kata.Solutions;

//https://www.codewars.com/kata/56747fd5cb988479af000028/train/csharp
//https://www.codewars.com/users/MrAliSalehi/
public class GetMiddleChar : IKata
{
    /// <inheritdoc />
    public void Solution()
    {
        var answer = GetMiddle("middle");
        var answer2 = GetMiddle("testing");
    }
    public static string GetMiddle(string s)
    {
        if (IsEven(s.Length))
        {
            var firstMiddleChar = s[StringLengthStartingFromOne(s.Length) / 2].ToString();
            var secondMiddleChar = s[StringLengthStartingFromOne(s.Length) / 2 + 1].ToString();
            return firstMiddleChar + secondMiddleChar;
        }
        else
        {
            return s[s.Length / 2].ToString();
        }
    }

    private static int StringLengthStartingFromOne(int len) => len - 1;
    private static bool IsEven(int number) => number % 2 == 0;
}
