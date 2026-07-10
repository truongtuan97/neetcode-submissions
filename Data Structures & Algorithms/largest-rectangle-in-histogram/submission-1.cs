public class Solution {
    public int LargestRectangleArea(int[] heights) {
        Stack<int> stack = new Stack<int>();
        int maxArea = 0;
        int n = heights.Length;

        for (int i=0; i<=n; i++) {
            int currentHeight = (i == n) ? 0 : heights[i];

            while (stack.Count > 0 && currentHeight < heights[stack.Peek()]) {
                int h = heights[stack.Pop()];
                int w = (stack.Count == 0) ? i : i - stack.Peek() - 1;
                maxArea = Math.Max(maxArea, w*h);
            }
            stack.Push(i);
        }
        return maxArea;
    }
}
 