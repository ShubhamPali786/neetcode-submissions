public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int left = 0, m = matrix.Length, n = matrix[0].Length;
        int right = (m * n) - 1;

        while (left <= right) {
            int mid = left + (right - left) / 2;
            int val = matrix[mid / n][mid % n];
            if (val == target)
                return true;
            else if (val < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return false;
    }
}
