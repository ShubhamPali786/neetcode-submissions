public class Solution {
    public int MaxArea(int[] heights) {
        int left =0;
        int right = heights.Length - 1;
        int maxArea = 0;
        while(left< right){
            if(heights[left] < heights[right]){
                int currentHeight = heights[left];
                int currentArea = currentHeight * (right-left);
                Console.WriteLine(currentArea);
                maxArea = Math.Max(currentArea,maxArea);
                left++;
            }else{
                int currentHeight = heights[right];

                int currentArea = currentHeight * (right-left);
                Console.WriteLine(currentArea);
                maxArea = Math.Max(currentArea,maxArea);
                right--;
            }
        }
        return maxArea;
    }
}
