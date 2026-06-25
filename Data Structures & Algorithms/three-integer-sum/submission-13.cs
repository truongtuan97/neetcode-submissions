public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var result = new List<List<int>>();
        
        if (nums.Length == 0) return result;

        Array.Sort(nums);
        int size = nums.Length;
        for (int i=0; i<size; i++) {
            if (i > 0 && nums[i-1] == nums[i]) {
                continue;
            }
            int left = i+1;
            int right = size - 1;
            
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
                    right++;
                }
                if (sum < 0) {
                    left += 1;
                } else {
                    right -= 1;
                }                  
            }
        }
        return result;
    }
}
