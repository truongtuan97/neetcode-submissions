public class Solution {
    public int Search(int[] nums, int target) {
        if (nums.Length == 1) {
         if (nums[0] == target) 
            return 0;
        else
            return -1;
        }

        int mid = nums.Length / 2 - 1;
        
        if (nums[mid] == target)
            return mid;

        if (nums[mid] > target) {
            while (mid >= 0) {
                Console.WriteLine(nums[mid]);
                if (nums[mid] == target) return mid;
                mid -= 1;
            }
        } else {
            while (mid <= nums.Length - 1) {
                Console.WriteLine(nums[mid]);
                if (nums[mid] == target) return mid;
                mid += 1;
            }
        }
        return -1;
    }
}
