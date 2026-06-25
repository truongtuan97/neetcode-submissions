public class Solution {
    public int MaxArea(int[] heights) {
        int size = heights.Length;
        if (size == 0) return 0;

        int left = 0;
        int right = size -1;
        int maxArea = 0;
        while (left < right) {
            int width = right - left;
            int height = Math.Min(heights[left], heights[right]);
            maxArea = Math.Max(maxArea, (width * height));

            if (heights[left] < heights[right]) {
                left++;
            } else {
                right--;
            }
        }
        return maxArea;
    }
}
