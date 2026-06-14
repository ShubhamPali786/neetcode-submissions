public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left=1, right = piles.Max();
        int result = right;
        while(left <= right){
            int mid = left + (right - left) /2;
            long hours = piles.Sum(n=> (long)Math.Ceiling((double) n / mid));
            if(hours <=h){
                result = mid;
                right = mid - 1;
            }else{
                left = mid +1;
            }
        }
        return result;
    }
}
