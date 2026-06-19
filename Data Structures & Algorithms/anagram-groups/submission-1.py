class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        dict = {}
        result = []

        for str in strs:
            sorted_String = "".join(sorted(str))
            if sorted_String in dict:
                dict[sorted_String].append(str)
            else:
                dict[sorted_String] = []
                dict[sorted_String].append(str)
        
        for key, value in dict.items():
            result.append(value)

        return result
