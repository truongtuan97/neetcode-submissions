public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int size = numbers.Length;

        int left = 0;
        int right = size - 1;

        while (left < right) {
            int sum = numbers[left] + numbers[right];
            if (sum == target) {
                left++;
                right++;
                return [left, right];
            } else if (sum > target) {
                right--;
            } else {
                left++;
            }
        }
        return [left, right];
    }
}
