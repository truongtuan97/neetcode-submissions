public class Solution {
    public int CharacterReplacement(string s, int k) {
        int left = 0;
        int maxFreq = 0;
        int maxLength = 0;
        int[] list = new int[26];

        for (int right=0; right<s.Length; right++) {
            char current = s[right];

            list[current - 'A']++;
            maxFreq = Math.Max(maxFreq, list[current - 'A']);

            while (right - left + 1 - maxFreq > k) {
                char leftChar = s[left];
                list[leftChar - 'A']--;
                left++;
            }

            maxLength = Math.Max(maxLength, (right - left + 1));
        }
        return maxLength;
    }
}
