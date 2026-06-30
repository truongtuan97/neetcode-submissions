public class Solution {
    public string MinWindow(string s, string t) {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || s.Length < t.Length) {
            return "";
        }

        int[] targetCount = new int[128];
        int need = 0;
        int have = 0;
        int[] windowCount = new int[128];
        int minLength = int.MaxValue;
        int left = 0;
        int minLeft = 0;
        
        foreach (char c in t) {
            if (targetCount[c] == 0) need++;
            targetCount[c]++;
        }

        for (int right = 0; right < s.Length; right++) {
            int curChar = s[right];

            windowCount[curChar]++;

            if (targetCount[curChar] > 0 && targetCount[curChar] == windowCount[curChar]) {
                have++;
            }

            while (have == need) {
                char leftChar = s[left];

                int windowSize = right - left + 1;

                if (windowSize < minLength) {
                    minLength = windowSize;
                    minLeft = left;
                }
                
                windowCount[leftChar]--;
                if (targetCount[leftChar] > 0 && targetCount[leftChar] > windowCount[leftChar]) {
                    have--;
                }
                left++;
            }
        }
        return minLength == int.MaxValue ? "" : s.Substring(minLeft, minLength);
    }
}
