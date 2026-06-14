public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (int num in nums) {
            if (dict.ContainsKey(num)) {
                dict[num] += 1;
            } else {
                dict.Add(num, 1);
            }
        }
        /*  Approach 1
           PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
           foreach (var kvp in dict) {
               minHeap.Enqueue(kvp.Key, kvp.Value);
               if (minHeap.Count > k) {
                   minHeap.Dequeue();
               }
           }
           List<int> result = new List<int>();
           while (minHeap.Count > 0) {
               result.Add(minHeap.Dequeue());
           }
           return result.ToArray();
       */
        // Approach 2 using bucket sort - O(n) as n is length of array getting used.
        List<int>[] buckets = new List<int>[nums.Length + 1];
        // initialise each bucket as empty
        for (int i = 0; i < buckets.Length; i++) {
            buckets[i] = new List<int>();
        }

        foreach (var kvp in dict) {
            buckets[kvp.Value].Add(kvp.Key);
        }
        // STEP 3: Read from right, collect k elements
        List<int> result = new List<int>();

        for (int i = buckets.Length - 1; i >= 1; i--) {
            foreach (int n in buckets[i]) {
                result.Add(n);
                if (result.Count == k)
                    return result.ToArray();
            }
        }

        return result.ToArray();
    }


}
