 int LengthOfLastWord(string s)
{
    string[] words = s.Split(' ');

    return words
        .Where(w => !string.IsNullOrWhiteSpace(w))
        .Last()
        .Length;
}

Console.WriteLine($"Lastword {LengthOfLastWord("Hello world")} ");