public class Solution {

    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();
        foreach (var str in strs) {
            sb.Append(str.Length).Append("#").Append(str);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int i = 0;
        while (i < s.Length) {
            int j = i;
            while (s[j] != '#') {
                j += 1;
            }

            int len = int.Parse(s[i..j]);
            result.Add(s[(j+1)..(len+j+1)]);
            i = j + 1 + len;
        }
        return result;
   }
}
