public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];

        for (int i=0; i<9; i++) {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for (var r=0; r<9; r++) {
            for (var c=0; c<9; c++) {
                var value = board[r][c];

                if (value == '.') {
                    continue;
                }

                var box = (r / 3) * 3 + (c / 3);

                if (!rows[r].Add(value)) {
                    return false;
                }
                if (!cols[c].Add(value)) {
                    return false;
                }
                if (!boxes[box].Add(value)) {
                    return false;
                }
            }
        }
        return true;
    }
}
