public class Solution {
    public int LengthOfLongestSubstring(string s) {
        List<char> subString = new List<char>();
        int longestString = 0;
        for (int i=0; i<s.Length; i++) {
            while (subString.Contains(s[i])) {
                subString.RemoveAt(0);
            }
            subString.Add(s[i]);

            longestString = Math.Max(longestString, subString.Count);
        }
        return longestString;
    }
}
