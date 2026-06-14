public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;
        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target) {
                 return mid; // Target found at index mid
            }
            if (nums[left] <= nums[mid])  // Left half is sorted
            {
                if (nums[left] <= target && target < nums[mid]) {
                    right = mid - 1;  // Target is in the left half
                } else {
                    left = mid + 1;  // Target is in the right half
                }
            } else  // Right half is sorted
            {
                if (nums[mid] < target && target <= nums[right]) {
                    left = mid + 1;  // Target is in the right half
                } else {
                    right = mid - 1;  // Target is in the left half
                }
            }
        }
        return -1;
    }
}
