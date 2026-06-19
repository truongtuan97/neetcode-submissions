public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        char[] aS = s.ToCharArray();
        char[] aT = t.ToCharArray();
        Array.Sort(aS);
        Array.Sort(aT);
    
        if (new string(aS) == new string(aT)) {
            return true;
        } else {
            return false;
        }
    }
}
