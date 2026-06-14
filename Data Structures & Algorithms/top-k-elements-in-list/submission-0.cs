public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        foreach(int num in nums){
            if(dict.ContainsKey(num)){
                dict[num] +=1;
            }else{
                dict.Add(num,1);
            }
        }
        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
        foreach(var kvp in dict){
            minHeap.Enqueue(kvp.Key,kvp.Value);
            if(minHeap.Count > k){
                minHeap.Dequeue();
            }
        }
        List<int> result = new List<int>();
        while(minHeap.Count >0){
            result.Add(minHeap.Dequeue());
        }
        return result.ToArray();
    }
}
