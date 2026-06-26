public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) return false;
        var arrS1 = s1.ToCharArray();
        Array.Sort(arrS1);
        string sortedS1 = new string(arrS1);

        for (int i=0; i<=s2.Length - s1.Length; i++) {
            string subString = s2.Substring(i, s1.Length);
            Console.WriteLine(subString);
            var arrSubString = subString.ToCharArray();
            Array.Sort(arrSubString);
            
            if ((new string(arrSubString)).ToLower() == sortedS1) {
                return true;                
            }
        }
        return false;
    }
}
