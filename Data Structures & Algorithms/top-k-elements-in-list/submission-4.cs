public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        foreach (int item in nums) {
            if (dict.ContainsKey(item)) {
                dict[item] += 1;
            } else {
                dict[item] = 1;
            }
        }

        Dictionary<int, int> sorted = dict.OrderByDescending(kvp => kvp.Value).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        List<int> result = new List<int>();
        foreach (var kvp in sorted) {
            if (result.Count() < k) {
                result.Add(kvp.Key);
            }
        }
        return result.ToArray();
    }
}
