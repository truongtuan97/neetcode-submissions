public class Solution {
    public int LengthOfLongestSubstring(string s) {
        List<char> subString = new List<char>();
        int maxLength = 0;

        for (int i=0; i<s.Length; i++) {
            while (subString.Contains(s[i])) {
                subString.RemoveAt(0);
            }
            subString.Add(s[i]);

            maxLength = Math.Max(subString.Count, maxLength);
        }
        return maxLength;
    }
}
