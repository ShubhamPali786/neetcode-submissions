public class Solution {
    public int MaxProfit(int[] prices) {
        int i =0, j =1, len = prices.Length-1, maxProfit = 0;
        int smallestBuy=0;
        while(j <= len){
            if(prices[i] <= prices[j]){
                smallestBuy = prices[i];
                Console.WriteLine(prices[j]);
                maxProfit =Math.Max(maxProfit, prices[j]-smallestBuy);
                Console.WriteLine(maxProfit);
                j++;
            }else{
                i=j;
                j= i+1;
            }

        }
        return maxProfit;
    }
}
