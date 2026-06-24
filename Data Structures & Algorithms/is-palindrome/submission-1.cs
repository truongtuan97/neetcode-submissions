public class Solution {
    public bool IsPalindrome(string s) {
        string cleanString = Regex.Replace(s, @"[^a-zA-Z0-9]", "");
        
        var arr_s = cleanString.ToCharArray();        
        Array.Reverse(arr_s);

        return ((new string(arr_s)).ToLower() == cleanString.ToLower());
    }
}
