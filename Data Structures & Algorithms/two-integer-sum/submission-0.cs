public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        int[] result = new int[2];
        for(int i=0;i<nums.Length;i++){
            int difference = target - nums[i];
            if(dict.ContainsKey(nums[i])){
                int value = dict[nums[i]];
                result[0] = value;
                result[1] = i;
                break;
            }else{
                dict.Add(difference,i);
            }
        }
        return result;
    }
}