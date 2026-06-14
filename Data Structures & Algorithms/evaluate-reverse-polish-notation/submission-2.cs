public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<string> stack = new Stack<string>();
        int result = 0;
        foreach (var token in tokens) {
            if (token is "+" or "-" or "*" or "/") {
                int top = int.Parse(stack.Pop());
                switch (token) {
                    case "+":
                        result = top + int.Parse(stack.Pop());
                        stack.Push(result.ToString());
                        break;
                    case "-":
                        result = int.Parse(stack.Pop()) - top ;
                        stack.Push(result.ToString());
                        break;
                    case "*":
                        result = top * int.Parse(stack.Pop());
                        stack.Push(result.ToString());
                        break;
                    case "/":
                        result = int.Parse(stack.Pop()) / top;
                        stack.Push(result.ToString());
                        break;
                    default:
                        break;
                }
            } else {
                stack.Push(token.ToString());
            }
        }
        return int.Parse(stack.Pop());
    }
}
