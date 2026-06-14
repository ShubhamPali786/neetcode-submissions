public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] res= new int[2];
        int left =0,right=numbers.Length-1;
        while(left < right) {
            int currentSum = numbers[left] + numbers[right];
            if(currentSum == target){
                res[0] = left+1;
                res[1] = right+1;
                break;
            }else if(currentSum > target){
                right--;
            }else{
                left++;
            }
        }
        return res;
    }
}
