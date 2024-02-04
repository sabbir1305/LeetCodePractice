//Given a pattern and a string s, find if s follows the same pattern.

//Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.



//Example 1:

//Input: pattern = "abba", s = "dog cat cat dog"
//Output: true

//Example 2:

//Input: pattern = "abba", s = "dog cat cat fish"
//Output: false

//Example 3:

//Input: pattern = "aaaa", s = "dog cat cat dog"
//Output: false




//Constraints:

//1 <= pattern.length <= 300
//    pattern contains only lower-case English letters.
//    1 <= s.length <= 3000
//    s contains only lowercase English letters and spaces ' '.
//    s does not contain any leading or trailing spaces.
//    All the words in s are separated by a single space.


string s1 = "abba";
string t1 = "dog cat cat dog";
Console.WriteLine(WordPattern(s1, t1));
static bool WordPattern(string pattern, string s)
{
    var mappedWords = new Dictionary<char, string>();
    var usedWords = new HashSet<string>();
    var words = s.Split(' ');

    if(words.Count() != pattern.Length)
        return false;

    for( int i = 0; i < words.Count(); i++)
    {
        char c = pattern[i];
        string word = words[i];

        if (mappedWords.ContainsKey(c))
        {
            if(mappedWords[c] != word ) return false;
        }
        else
        {
            if (usedWords.Contains(word))
            {
                return false;
            }
            mappedWords.Add(c, word);
            usedWords.Add(word);

        }

    }
   

    
    return true;


}
