using System.Text;

lab1Delegate del = new lab1Delegate(concatenatedString);
string testString = "Test";
Console.WriteLine(del(testString, 5));

lab1Delegate del2 = new lab1Delegate(removeLetters);
Console.WriteLine(del2(testString, 3));
Console.WriteLine(testString);
Console.WriteLine(del2(testString, 5));

string concatenatedString(string wordArg, int numArg)
{
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < numArg; i++)
    {
        sb.Append(wordArg);
    }
    return sb.ToString();
}

string removeLetters(string wordArg, int numArg)
{
    if (numArg < wordArg.Length)
    {
        return wordArg.Substring(0, wordArg.Length - numArg);
    }
    return "";
}

delegate string lab1Delegate(string wordArg, int numArg);