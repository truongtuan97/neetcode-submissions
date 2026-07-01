public class MinStack {
    private Stack<int[]> stack;

    public MinStack() {
        stack = new Stack<int[]>();
    }
    
    public void Push(int val) {
        if (stack.Count == 0) {
            // Nếu stack rỗng, giá trị nhỏ nhất chính là val
            stack.Push(new int[] { val, val });
        } else {
            // Nếu không rỗng, lấy giá trị nhỏ nhất của thằng đứng trước nó ra so sánh
            int currentMin = stack.Peek()[1];
            int newMin = Math.Min(val, currentMin);
            stack.Push(new int[] { val, newMin });
        }
    }
    
    public void Pop() {
        stack.Pop();
    }
    
    public int Top() {
        return stack.Peek()[0]; // Trả về giá trị thực sự
    }
    
    public int GetMin() {
        return stack.Peek()[1]; // Trả về giá trị nhỏ nhất được "ghi nhớ" tại đỉnh stack
    }
}
