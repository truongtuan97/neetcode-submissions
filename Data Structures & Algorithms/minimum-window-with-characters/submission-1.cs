public class Solution {
    public string MinWindow(string s, string t) {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || t.Length > s.Length) {
            return "";            
        }

        int[] shoppingList = new int[128];
        foreach (char c in t) {
            shoppingList[c]++;
        }
        int requiredItems = t.Length;

        int left = 0;
        int minLeft = 0;
        int minLen = int.MaxValue;

        for (int right=0; right < s.Length; right++) {
            char current = s[right];

            if (shoppingList[current] > 0) {
                requiredItems--;
            }

            shoppingList[current]--;

            while (requiredItems == 0) {
                int windowSize = right - left + 1;
                if (windowSize < minLen) {
                    minLen = windowSize;
                    minLeft = left;
                }

                char leftItem = s[left];
                shoppingList[leftItem]++;

                if (shoppingList[leftItem] > 0) {
                    requiredItems++;
                }
                left++;
            }
        }
        return minLen == int.MaxValue ? "" : s.Substring(minLeft, minLen);
    }
}
