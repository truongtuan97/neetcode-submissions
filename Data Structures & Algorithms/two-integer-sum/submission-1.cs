public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seen = new Dictionary<int, int>();

        for (int i=0; i<nums.Length; i++) {
            int compliment = target - nums[i];

            if (seen.ContainsKey(compliment)) {
                return [seen[compliment], i];
            } else {
                seen.Add(nums[i], i);
            }
        }
        return new int[0];
    }
}
