namespace Kata.Solutions;

//https://www.codewars.com/kata/563cf89eb4747c5fb100001b/train/csharp
//https://www.codewars.com/users/MrAliSalehi/
public class RemoveMinimum : IKata
{
    /// <inheritdoc />
    public void Solution()
    {
        var answer = RemoveSmallest(new List<int> { 1, 2, 3, 4, 5, 1, 1, 2 });
    }
    public List<int> RemoveSmallest(List<int> numbers)
    {
        if (numbers.Count is 0)
            return numbers;

        var result = new int[numbers.Count];

        numbers.CopyTo(result);

        var clonedList = result.ToList();

        var smallestNumber = clonedList.Min();
        clonedList.Remove(smallestNumber);

        return clonedList;
    }
}
