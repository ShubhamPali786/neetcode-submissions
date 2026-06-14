public class Solution {
    public int CharacterReplacement(string s, int k) {
        int left = 0;
        int maxLength = 0;
        Dictionary<char, int> count = new Dictionary<char, int>();
        for (int right = 0; right < s.Length; right++) {
            if (!count.ContainsKey(s[right])) {
                count[s[right]] = 0;
            }
            count[s[right]]++;
            while (right - left + 1 - count.Values.Max() > k) {
                count[s[left]]--;
                left++;
            }
            maxLength = Math.Max(maxLength, right - left + 1);
        }
        return maxLength;
    }
}
