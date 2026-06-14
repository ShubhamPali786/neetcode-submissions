public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        foreach(string str in strs){
            int[] charCount = new int[26];
            foreach(char c in str){
                charCount[c-'a']++;
            }
            string key = string.Join("#",charCount);
            if(!dict.ContainsKey(key)){
                dict[key] = new List<string>();
            }
            dict[key].Add(str);
        }
        return dict.Values.ToList();
    }
}
