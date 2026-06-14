public class Solution {

    public string Encode(IList<string> strs) {
        string encode = "";
        foreach(string str1 in strs){
            encode += str1.Length + "#" + str1; 
        }
        Console.Write(encode);
        return encode;
    }

    public List<string> Decode(string s) {
        List<string> res = new List<string>();
        int i = 0;
        while(i < s.Length){
            int j= i;
            while(s[j] != '#')
                j++;
            int length = int.Parse(s.Substring(i, j - i));
            res.Add(s.Substring(j + 1, length));
            i = j + length + 1;
        }
        return res;
   }
}
