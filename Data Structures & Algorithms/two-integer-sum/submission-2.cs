public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> storedNums = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            if (storedNums.ContainsKey(target - nums[i])) {
                return new int[] { storedNums[target - nums[i]], i };
            }

            if (!storedNums.ContainsKey(nums[i])) {
                storedNums.Add(nums[i], i);
            }
        }
        return new int[] {};
    }
}