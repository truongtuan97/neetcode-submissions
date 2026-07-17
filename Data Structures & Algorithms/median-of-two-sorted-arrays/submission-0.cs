public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        // dam bao nums1 luon nho hon num2 de dam bao toi uu hoa tim kiem nhi phan O(log(min(m, n)))
        if (nums1.Length > nums2.Length) {
            return FindMedianSortedArrays(nums2, nums1);
        }

        int m = nums1.Length;
        int n = nums2.Length;
        int left = 0, right = m;

        while (left <= right) {
            int partition1 = left + (right - left) / 2;
            int partition2 = (m + n + 1) / 2 - partition1;

            // neu partition1 = 0 nghia la khong co phan tu nums1 nao o ben trai
            double L1 = (partition1 == 0) ? double.MinValue : nums1[partition1 - 1];
            // neu partition1 = m nghia la khong co phan tu nums1 nao o ben phai
            double R1 = (partition1 == m) ? double.MaxValue : nums1[partition1];

            // tuong tu voi nums2
            double L2 = (partition2 == 0) ? double.MinValue : nums2[partition2 - 1];
            double R2 = (partition2 == n) ? double.MaxValue : nums2[partition2];

            // kiem tra xe mvi tri cat da dung chua
            if (L1 <= R2 && L2 <= R1) {
                // neu tong so phan tu la le
                if ((m+n) % 2 != 0) {
                    return Math.Max(L1, L2);
                }
                // neu tong so phan tu la chan
                return (Math.Max(L1, L2) + Math.Min(R1, R2)) / 2;
            } else if (L1 > R2) {
                // duong cat cua nums1 qua lech sang phai can dich sang trai
                right = partition1 - 1;
            } else {
                // duong cat cua nums1 qua lech sang trai can dich sang phai
                left = partition1 + 1;
            }
        }
        return 0.0;
    }
}
