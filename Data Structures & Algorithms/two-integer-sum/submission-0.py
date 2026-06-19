class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        seen = {}
        for i, e in enumerate(nums):
            compliment = target - e
            if compliment in seen:
                return [seen[compliment], i]
            
            seen[e] = i
        