public class Solution {
    public bool IsPalindrome(string s) {
        string cleanString = Regex.Replace(s, @"[^a-zA-Z0-9]", "").ToLower();
        int left = 0;
        int right = cleanString.Length - 1;

        while (left < right) {
            if (cleanString[left] != cleanString[right]) {
                Console.WriteLine($"{cleanString[left]} - {cleanString[right]}");
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
