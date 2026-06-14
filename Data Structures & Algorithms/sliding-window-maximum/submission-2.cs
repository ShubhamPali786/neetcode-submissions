public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        PriorityQueue<(int value, int index), int> maxHeap =
            new PriorityQueue<(int value, int index), int>(
                Comparer<int>.Create((a, b) => b.CompareTo(a)));
        List<int> result = new List<int>();
        for (int right = 0; right < nums.Length; right++) {
            maxHeap.Enqueue((nums[right], right), nums[right]);
            if (right >= k - 1) {
                while (maxHeap.Peek().index <= right - k) {
                    maxHeap.Dequeue();
                }
                result.Add(maxHeap.Peek().value);
            }
        }
        return result.ToArray();
    }
}
