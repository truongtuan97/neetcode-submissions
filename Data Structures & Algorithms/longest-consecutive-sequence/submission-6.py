class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        if len(nums) == 0:
            return 0
        
        hs = set(nums)
        longest = 0

        for num in hs:
            if num-1 not in hs:
                length = 1
                
                while num+length in hs:
                    length += 1

                longest = max(longest, length)
        return longest