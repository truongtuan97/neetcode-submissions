public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        List<int> result = new List<int>();
        for (int i=0; i<nums.Length; i++){
            if (dic.ContainsKey(nums[i])) {
                dic[nums[i]] += 1;
            } else {
                dic.Add(nums[i], 1);
            }
        }
        
        var sortedDict = dic.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

        foreach (var item in sortedDict) {
            if (result.Count() < k) {
                result.Add(item.Key);
            } else {
                return result.ToArray();
            }
        }
        return result.ToArray();
    }
}
