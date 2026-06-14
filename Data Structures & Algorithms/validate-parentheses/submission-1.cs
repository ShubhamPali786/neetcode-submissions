public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        var pairs = new Dictionary<char,char>(){
             [')'] = '(',
             [']'] = '[',
             ['}'] = '{'
        };
        foreach(char c in s){
            if(c is '(' or '[' or '{')
                stack.Push(c);
            else if(pairs.ContainsKey(c)){
                if(!stack.TryPop(out char top) || top !=pairs[c] )
                    return false;
            }
        }
        return stack.Count == 0;
    }
}
