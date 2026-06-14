public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        int[] result = new int[n]; // default 0
        var stack = new Stack<int>(); // stores indices

        for(int i=0; i< n; i++){
            while(stack.Count >0 && temperatures[i] > temperatures[stack.Peek()]){
                int j = stack.Pop();
               // Console.WriteLine(j);
                result[j] = i - j;
            }
            stack.Push(i);
        }
        return result;
    }
}
