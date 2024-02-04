//Given two strings s and t, determine if they are isomorphic.

//Two strings s and t are isomorphic if the characters in s can be replaced to get t.

//All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character, but a character may map to itself.



//Example 1:

//Input: s = "egg", t = "add"
//Output: true

//Example 2:

//Input: s = "foo", t = "bar"
//Output: false

//Example 3:

//Input: s = "paper", t = "title"
//Output: true




//Constraints:

//1 <= s.length <= 5 * 104
//    t.length == s.length
//    s and t consist of any valid ascii character.


string s1 = "egg";
string t1 = "add";
Console.WriteLine(IsIsomorphic(s1, t1)); // Output: true

string s2 = "foo";
string t2 = "bar";
Console.WriteLine(IsIsomorphic(s2, t2)); // Output: false

string s3 = "paper";
string t3 = "title";
Console.WriteLine(IsIsomorphic(s3, t3)); // Output: true

static bool IsIsomorphic(string s, string t)
{
    if(s.Length != t.Length)
        return false;
    var mappedChars = new Dictionary<char, char>();
    var usedChars = new HashSet<char>();

    for( int i=0; i<s.Length; i++)
    {
        char sC = s[i];
        char tC = t[i];

        if( mappedChars.ContainsKey(sC) )
        {
            if(mappedChars[sC] != tC ) return false;
        }
        else
        {
            if( usedChars.Contains(tC) )
            {
                return false;
            }
            mappedChars[sC] = tC;
            usedChars.Add(sC);
        }


    }
    return true;
}
