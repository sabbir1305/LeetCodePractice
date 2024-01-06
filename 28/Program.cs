//using System.Security.Cryptography;

//Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.



//Example 1:

//Input: haystack = "sadbutsad", needle = "sad"
//Output: 0
//Explanation: "sad" occurs at index 0 and 6.
//The first occurrence is at index 0, so we return 0.

//Example 2:

//Input: haystack = "leetcode", needle = "leeto"
//Output: -1
//Explanation: "leeto" did not occur in "leetcode", so we return -1.



//Constraints:

//    1 <= haystack.length, needle.length <= 104
//    haystack and needle consist of only lowercase English characters.


Console.WriteLine(StrStr("leetcodeleeto", "leeto"));

static int StrStr(string haystack, string needle)
{
    if (needle.Length > haystack.Length)
        return -1;

    for (int start = 0; start <= haystack.Length - needle.Length; start++)
    {
        int matchLen;
        for (matchLen = 0; matchLen < needle.Length; matchLen++)
        {
            if (haystack[start + matchLen] != needle[matchLen])
                break;
        }

        if (matchLen == needle.Length)
            return start;
    }

    return -1;

}