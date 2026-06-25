public class Solution {
    public int Trap(int[] height) {
        int size = height.Length;

        if (size == 0) return 0;

        int left = 0;
        int right = size - 1;
        int maxLeft = 0;
        int maxRight = 0;
        int totalWater = 0;

        while (left < right) {
            if (height[left] <= height[right]) {
                if (maxLeft <= height[left]) {
                    maxLeft = height[left];
                } else {
                    totalWater += maxLeft - height[left];
                }
                left++;
            } else {
                if (maxRight <= height[right]) {
                    maxRight = height[right];
                } else {
                    totalWater += maxRight - height[right];
                }
                right--;
            }
        }
        return totalWater;
    }
}
