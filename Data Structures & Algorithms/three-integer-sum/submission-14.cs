public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);

        int size = nums.Length;
        int left = 0;
        int right = size - 1;
        List<List<int>> result = new List<List<int>>();

        for (int i=0; i<size; i++) {
            if (i > 0 && nums[i] == nums[i-1]) {
                continue;
            }
            left = i+1;
            right = size -1;
            while (left < right) {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == 0) {
                    result.Add([nums[i], nums[left], nums[right]]);

                    while (left < right && nums[left] == nums[left+1]) {
                        left++;
                    }
                    while (left < right && nums[right] == nums[right-1]) {
                        right--;
                    }
                    left++;
                    right--;
                } else {
                    if (sum > 0) {
                        right--;
                    } else {
                        left++;
                    }
                }
            }
            
        }
        return result;
    }
}
