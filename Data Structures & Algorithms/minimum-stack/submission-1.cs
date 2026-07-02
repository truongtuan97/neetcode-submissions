public class MinStack {
    private Stack<int[]> stack;    

    public MinStack() {
        stack = new Stack<int[]>();
    }
    
    public void Push(int val) {
        if (stack.Count == 0) {
            stack.Push([val, val]);
        } else {
            int curMin = stack.Peek()[1];
            int min = Math.Min(val, curMin);
            stack.Push([val, min]);
        }
    }
    
    public void Pop() {
        stack.Pop();
    }
    
    public int Top() {
        return stack.Peek()[0];
    }
    
    public int GetMin() {
        return stack.Peek()[1];
    }
}
