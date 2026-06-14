public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];
        int left = 1;
        for(int i=0; i<nums.Length; i++){
            result[i] =left;
            left = left * nums[i];
        }
        int right = 1;
        for(int i=nums.Length-1; i>=0; i--){
            result[i] *=right;
            right = right * nums[i];
        }
        return result;
    }
}
