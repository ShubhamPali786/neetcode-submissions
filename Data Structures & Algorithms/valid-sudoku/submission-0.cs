public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[
            ,
        ] boxes = new HashSet<char>[3, 3];
        for (int i = 0; i < 9; i++) {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
        }
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                boxes[i, j] = new HashSet<char>();
            }
        }
        bool isValid = true;
        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                char num = board[i][j];
                if (num != '.') {
                    if (rows[i].Contains(num) || cols[j].Contains(num) ||
                        boxes[i / 3, j / 3].Contains(num)) {
                        isValid = false;
                        break;
                    }
                    rows[i].Add(num);
                    cols[j].Add(num);
                    boxes[i / 3, j / 3].Add(num);
                }
            }
            if (!isValid) {
                break;
            }
        }
        return isValid;
    }
}
