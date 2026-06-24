class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t):
            return False

        sorted_s = sorted(s, key=lambda x: x[0])
        sorted_t = sorted(t, key=lambda x: x[0])

        return sorted_s == sorted_t