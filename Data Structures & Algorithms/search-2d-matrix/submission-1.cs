public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int[] flatterned = matrix.SelectMany(x => x).ToArray();

        int left = 0;
        int right = flatterned.Length - 1;

        while (left <= right) {
            int mid = left + (right - left) / 2;

            if (flatterned[mid] == target) {
                return true;
            }

            if (flatterned[mid] > target) {
                right = mid - 1;                
            } else {
                left = mid + 1;
            }
        }
        return false;
    }
}
