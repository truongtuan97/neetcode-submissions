class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        hash = {}
        result = []

        for item in nums:
            if item in hash:
                hash[item] += 1
            else:
                hash[item] = 1
        
        sortedHash = sorted(hash.items(), key=lambda x: x[1], reverse=True)

        for key,v in sortedHash:
            if len(result) < k:
                result.append(key)
            else:
                return result

        return result
