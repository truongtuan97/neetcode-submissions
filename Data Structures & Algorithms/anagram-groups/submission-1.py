class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        map = {}

        for item in strs:
            sorted_item = "".join(sorted(item))
            map.setdefault(sorted_item, []).append(item)

        return list(map.values())