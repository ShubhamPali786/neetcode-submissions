public class Solution {
    public int LongestConsecutive(int[] nums) {
       HashSet<int> numSet= new HashSet<int>(nums);
       int longestStreak=0;
       foreach(int num in nums){
            if(!numSet.Contains(num-1)){
                int currentStreak = 1;
                int currentNum = num;
                while(numSet.Contains(currentNum+1)){
                    currentStreak +=1;
                    currentNum +=1;
                }
                longestStreak = Math.Max(longestStreak,currentStreak);
            }
       }
       return longestStreak;
    }
}
