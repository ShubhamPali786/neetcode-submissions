public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int left =0;
        Dictionary<char,int> counts1 =new Dictionary<char,int>();
        foreach(char c in s1){
            if(!counts1.ContainsKey(c)){
                counts1[c]=0;
            }
            counts1[c]++;
        }
        Dictionary<char,int> counts2 =new Dictionary<char,int>();
        bool valid = false;
        for(int right=0; right<s2.Length;right++){
            if(!counts2.ContainsKey(s2[right])){
                counts2[s2[right]]=0;
            }
            counts2[s2[right]]++;
            //check if length is greater
            if(right-left + 1 > s1.Length){
                counts2[s2[left]]--;
                left++;
            }

            bool isAnargram = true;
            foreach(var kvp in counts1){
                if(!counts2.ContainsKey(kvp.Key) || counts2[kvp.Key] != kvp.Value){
                    isAnargram = false;
                    break;
                }
            }
            if(isAnargram){
                valid = true;
                break;
            }
        }
        return valid;
    }
}
