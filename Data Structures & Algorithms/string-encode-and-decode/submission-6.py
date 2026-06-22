class Solution:

    def encode(self, strs: List[str]) -> str:
        s = ""
        for str in strs:
            s += f"{len(str)}" + "#" + str
        return s

    def decode(self, s: str) -> List[str]:
        result = []
        i = 0
        print(s)
        while i < len(s):
            j = i
            while s[j] != '#':
                j += 1
            
            string_length = int(s[i:j])
            print(f"i:j: {i}:{j} - {string_length} - {string_length+j+1}")

            result.append(s[(j+1):(string_length+j+1)])
            i = j + 1 + string_length

        return result