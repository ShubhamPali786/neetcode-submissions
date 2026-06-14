public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        bool isValid = false;
        for(int i =0; i<matrix.Length;i++){
            var nums = matrix[i];
            int left=0, right = nums.Length-1;
            
            while(left<=right){
                int mid = left + right-left/2;
                if(nums[mid] == target){
                    isValid = true;
                    break;
                }
                else if(nums[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            if(isValid){
                break;
            }
        }
        return isValid;
    }
}
