public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;

        HashSet<int> set = new HashSet<int>(nums);

        int longest = 0;

        foreach (var num in set) {
            if (!set.Contains(num-1)) {
                int length = 1;
                int current = num;

                while (set.Contains(current+1)) {
                    length++;
                    current++;
                }

                longest = Math.Max(longest, length);
            }
        }
        return longest;
    }
}
