public class Solution {
    public bool IsValid(string s) {
        if (s.Length % 2 != 0) return false;

        Dictionary<char, char> dict = new Dictionary<char, char> {
            {'{', '}'},
            { '(', ')'},
            { '[', ']'}
        };

        Stack<char> stack = new Stack<char>();

        foreach (char c in s) {
            if (dict.ContainsKey(c)) {
                stack.Push(c);
            } else {
                if (stack.Count == 0 || dict[stack.Pop()] != c ) {
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}
