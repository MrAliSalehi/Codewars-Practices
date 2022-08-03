namespace Kata.Solutions;

//https://www.codewars.com/kata/54b724efac3d5402db00065e/train/csharp
public class DecodeMorse : IKata
{

    private static readonly Dictionary<string, string> MorseDictionary = new()
    {
        {".-","A"},
        {"-...","B"},
        {"-.-.","C"},
        {"-..","D"},
        {".","E"},
        {"..-.","F"},
        {"--.","G"},
        {"....","H"},
        {"..","I"},
        {"-.-","K"},
        {".---","J"},
        {".-..","L"},
        {"--","M"},
        {"-.","N"},
        {"---","O"},
        {".--.","P"},
        {"--.-","Q"},
        {".-.","R"},
        {"...","S"},
        {"-","T"},
        {"..-","U"},
        {"...-","V"},
        {".--","W"},
        {"-..-","X"},
        {"-.--","Y"},
        {"--..","Z"},
        {"-----","0"},
        {".----","1"},
        {"..---","2"},
        {"...--","3"},
        {"....-","4"},
        {".....","5"},
        {"-....","6"},
        {"--...","7"},
        {"---..","8"},
        {"----.","9"},
        {".-.-.-","."},
        {"--..--",","},
        {"-.-.--","!"},
        {"...---...","SOS"}
    };


    public void Solution()
    {
        var answer = Decode("...---... -.-.--     - .... .     --.- ..- .. -.-. -.-     -... .-. --- .-- -.     ..-. --- -..-     .--- ..- -- .--. ...     --- ...- . .-.     - .... .     .-.. .- --.. -.--     -.. --- --. .-.-.-");

    }
    private static string Decode(string morseCode)
    {
        var allWords = morseCode.Split("   ");

        var result = allWords.Select(morseWord => DecodeMorseWord(morseWord)).Aggregate("", (current, s) => current + s + " ");

        return result.Trim();
    }

    private static string DecodeMorseWord(string morseWord)
    {
        var allChars = morseWord.Split(' ');
        var result = (from ch in allChars where ch is not "" select MorseDictionary[ch])
            .Aggregate("", (current, letter) => current + letter);
        return result + "";
    }
}
