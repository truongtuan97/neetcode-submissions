class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        seen = {}
        result = []

        for e in nums:
            if e in seen:
                seen[e] += 1
            else:
                seen[e] = 1

        sorted_seen = sorted(seen.items(), key=lambda x: x[1], reverse=True)
        for key, value in dict(sorted_seen).items():
            if len(result) < k:
                result.append(key)

        return result
