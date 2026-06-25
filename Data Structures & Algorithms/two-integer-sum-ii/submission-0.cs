public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length - 1;

        while (left < right) {
            var sum = numbers[left] + numbers[right];
            if (sum < target) {
                left++;
            } else if (sum > target) {
                right--;
            } else {                
                left++; right++;
                return [left, right];
            }            
        }
        left++; right++;
        return [left, right];
    }
}
