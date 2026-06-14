public class Solution {
    public bool IsPalindrome(string s) {
       s = s.ToLower();
      // regex to remove all non-alphanumeric characters from the string 
      s = System.Text.RegularExpressions.Regex.Replace(s, @"[^a-z0-9]", "");
      s = s.Replace(" ", "");
      int left = 0;
      int right = s.Length -1;

      while(left<right){
        if(s[left] != s[right]){
            return false;
        }
        left++;
        right--;
      }
      return true;
    }
}
