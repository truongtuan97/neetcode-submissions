public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;

        HashSet<int> set = new HashSet<int>(nums);

        int longest = 0;

        foreach (var num in set) {
            if (!set.Contains(num-1)) {
                var length = 1;

                while (set.Contains((num+length))) {
                    length++;
                }
                longest = Math.Max(longest, length);
            }
        }

        return longest;
    }
}
