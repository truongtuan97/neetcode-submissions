public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        List<List<string>> result = new List<List<string>>();

        foreach (string s in strs) {
            if (dict.ContainsKey(sort(s))) {
                dict[sort(s)].Add(s);
            } else {
                dict[sort(s)] = new List<string>();
                dict[sort(s)].Add(s);
            }
        }

        foreach (KeyValuePair<string, List<string>> kv in dict) {
            result.Add(kv.Value);
        }
        return result;
    }

    private string sort(string s) {
        char[] aS = s.ToCharArray();
        Array.Sort(aS);
        return new string(aS);
    }
}
