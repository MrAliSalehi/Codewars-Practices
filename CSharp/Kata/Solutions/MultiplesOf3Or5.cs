namespace Kata.Solutions;
//https://www.codewars.com/kata/514b92a657cdc65150000006/train/csharp
//https://www.codewars.com/users/MrAliSalehi/
public class MultiplesOf3Or5 : IKata
{
    /// <inheritdoc />
    public void Solution()
    {
        var answer = Solution(32);
    }

    public static int Solution(int value)
    {
        var allMultiples = new List<int>();

        for (var i = 0; i < value; i++)
        {
            if (IsMultipleOf3(i) || IsMultipleOf5(i))
                allMultiples.Add(i);
        }

        return allMultiples.Sum();
    }

    private static bool IsMultipleOf5(int value) => value % 5 == 0;
    private static bool IsMultipleOf3(int value) => value % 3 == 0;
}
