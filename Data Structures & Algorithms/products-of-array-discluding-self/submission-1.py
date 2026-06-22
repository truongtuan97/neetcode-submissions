class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        left_to_right = [0] * len(nums)
        right_to_left = [0] * len(nums)
        tich_luy_trai = tich_luy_phai = 1
        for i in range(len(nums)):
            left_to_right[i] = tich_luy_trai
            tich_luy_trai = tich_luy_trai * nums[i]

        for i in range(len(nums) - 1, -1 , -1):
            right_to_left[i] = tich_luy_phai
            tich_luy_phai = tich_luy_phai * nums[i]
        
        for i in range(len(nums)):
            left_to_right[i] = left_to_right[i] * right_to_left[i]
        
        return left_to_right