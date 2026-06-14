public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        foreach(string str in strs){
            char[] charArray = str.ToCharArray();
            Array.Sort(charArray);
            string sortedStr = new string(charArray);
            if(!dict.ContainsKey(sortedStr)){
                dict[sortedStr] = new List<string>();
            }
            dict[sortedStr].Add(str);
        }
        return dict.Values.ToList();
    }
}
