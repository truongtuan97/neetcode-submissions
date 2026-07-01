public class Solution {
    public int EvalRPN(string[] tokens) {
        double result = 0;
        string[] operators = ["+", "-", "*", "/"];
        Stack<int> stack = new Stack<int>();

        foreach (string s in tokens) {            
            if (operators.Contains(s)) {
                int first = stack.Pop();
                if (s == "*") {                    
                    stack.Push(stack.Pop() * first);
                }
                if (s == "/") {
                    stack.Push(stack.Pop() / first);
                }
                if (s == "+") {
                    stack.Push(stack.Pop() + first);
                }
                if (s == "-") {
                    stack.Push(stack.Pop() - first);
                }
                Console.WriteLine(stack.Peek());
            } else {
                stack.Push(int.Parse(s));
            }
        }
        return stack.Pop();
    }
}
