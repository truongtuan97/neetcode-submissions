public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int i = 0;
        int j = 0;

        while (i < rows) {
            if (target > matrix[i][cols-1]) {
                i += 1;
            } else {
                while (j < cols) {
                    if (target == matrix[i][j]) {
                        return true;
                    }
                    j += 1;
                }
                i += 1;
            }
        }
        
        return false;
    }
}
