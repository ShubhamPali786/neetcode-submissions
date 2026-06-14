public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;
        double[] time = new double[n];
        for (int i = 0; i < n; i++) {
            time[i] = (double)(target - position[i]) / speed[i];
        }
        Array.Sort(position, time);
        Stack<double> stack = new Stack<double>();
        for (int i = n - 1; i >= 0; i--) {
            if (stack.Count == 0 || time[i] > stack.Peek()) {
                stack.Push(time[i]);
            }
        }
        return stack.Count;
    }
}
