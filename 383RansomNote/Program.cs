//Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

//Each letter in magazine can only be used once in ransomNote.



//Example 1:

//Input: ransomNote = "a", magazine = "b"
//Output: false

//Example 2:

//Input: ransomNote = "aa", magazine = "ab"
//Output: false

//Example 3:

//Input: ransomNote = "aa", magazine = "aab"
//Output: true




//Constraints:

//1 <= ransomNote.length, magazine.length <= 105
//    ransomNote and magazine consist of lowercase English letters.

Console.WriteLine(CanConstruct("aaaa","aaab"));
static bool CanConstruct(string ransomNote, string magazine)
{
    Dictionary<char, int> magazineChars = new Dictionary<char, int>();
    foreach ( char c in magazine )
    {
        if( magazineChars.ContainsKey(c))
        {
            magazineChars[c] += 1;
        }
        else
        {
            magazineChars[c] = 1;
        }

    }

    foreach ( char c in ransomNote )
    {
        if ( magazineChars.TryGetValue(c, out int count) && count > 0)
        {
            magazineChars[c] --;
        }
        else
        {
            return false;
        }
    }
    return true;
}