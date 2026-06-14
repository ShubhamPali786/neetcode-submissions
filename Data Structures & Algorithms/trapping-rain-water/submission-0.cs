public class Solution {
    public int Trap(int[] height) {
        int left = 0, leftMax = 0, trappedWater = 0, rightMax = 0;
        int right = height.Length - 1;
        while (left < right) {
            if (height[left] <= height[right]) {
                if (leftMax <= height[left]) {
                    leftMax = height[left];
                } else {
                    trappedWater += leftMax - height[left];
                }
                left++;
            } else {
                if (rightMax <= height[right]) {
                    rightMax = height[right];
                } else {
                    trappedWater += rightMax - height[right];
                }
                right--;
            }
        }
        return trappedWater;
    }
}
