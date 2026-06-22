public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var left_to_right = new int[nums.Length];
        var right_to_left = new int[nums.Length];

        int tich_luy_trai = 1; 
        int tich_luy_phai = 1;

        for (int i=0; i<nums.Length; i++) {
            left_to_right[i] = tich_luy_trai;
            tich_luy_trai = tich_luy_trai * nums[i];
        }

        for (int i=nums.Length-1; i >= 0; i--) {
            right_to_left[i] = tich_luy_phai;
            tich_luy_phai = tich_luy_phai * nums[i];
        }
        
        for (int i=0; i<nums.Length; i++) {
            left_to_right[i] = left_to_right[i] * right_to_left[i];
        }

        return left_to_right;
    }
}
