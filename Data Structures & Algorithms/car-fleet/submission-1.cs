public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;
        int[] indices = new int[n];
        for(int i=0; i<n; i++)
        {
            indices[i] = i;
        }
        Array.Sort(indices,(a,b)=> position[b] - position[a]);
        Stack<double> stack = new Stack<double>();
        for(int i=0; i<n; i++)
        {
            var inx = indices[i];
            double time = (double) (target - position[inx]) / speed[inx];
            if(stack.Count ==0 || time > stack.Peek()){
                stack.Push(time);
            }
        }
        return stack.Count;
    }
}
