public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char, int> countT = new Dictionary<char, int>();
        foreach (char c in t) {
            if (!countT.ContainsKey(c)) {
                countT[c] = 0;
            }
            countT[c]++;
        }
        Dictionary<char, int> countS = new Dictionary<char, int>();
        int left = 0;
        int minLength = int.MaxValue;
        string minWindow = "";
        for (int right = 0; right < s.Length; right++) {
            if (!countS.ContainsKey(s[right])) {
                countS[s[right]] = 0;
            }
            countS[s[right]]++;
            while (true) {
                bool containsAll = true;
                foreach (var kvp in countT) {
                    if (!countS.ContainsKey(kvp.Key) || countS[kvp.Key] < kvp.Value) {
                        containsAll = false;
                        break;
                    }
                }
                if (!containsAll) {
                    break;
                }
                if (right - left + 1 < minLength) {
                    minLength = right - left + 1;
                    minWindow = s.Substring(left, minLength);
                }
                countS[s[left]]--;
                left++;
            }
        }
        return minWindow;
    }
}
