public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int s1Size = s1.Length;
        var arrS1 = s1.ToCharArray();
        Array.Sort(arrS1);
        var sortedS1 = new string(arrS1);
        for (int i=0; i<=s2.Length - s1.Length; i++) {
            var subS2 = s2.Substring(i, s1Size);
            var arrS2 = subS2.ToCharArray();
            Array.Sort(arrS2);
            Console.WriteLine($"{sortedS1} - {new string(arrS2)}");
            if (sortedS1 == new string(arrS2)) {
                return true;
            }
        }
        return false;
    }
}
