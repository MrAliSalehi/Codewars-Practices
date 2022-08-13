//https://www.codewars.com/kata/5208f99aee097e6552000148/train/csharp
//https://www.codewars.com/users/MrAliSalehi/


using System.Text;
namespace Kata.Solutions;

internal class BreakCamelCase : IKata
{
    private const string AllUpperLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public void Solution()
    {
        Console.WriteLine(BreakCamelCase1("camelCasing"));
        Console.WriteLine(BreakCamelCase1("identifier"));
        Console.WriteLine(BreakCamelCase1("breakTheCamelCaseBro"));
    }
    private static string BreakCamelCase1(string str)
    {
        if (str is "" or " ")
            return str;

        var newString = new StringBuilder();
        foreach (var chr in str)
        {
            if (AllUpperLetters.Any(p => p == chr))
            {
                newString.Append(' ');
                newString.Append(chr);
            }
            else
            {
                newString.Append(chr);
            }
        }
        return newString.ToString();
    }
}
