public class Solution {
    public bool IsValid(string s) {
        if (s.Length == 0) {
            return true;
        } else if (s.Length == 1) {
            return false;
        }
        Stack<char> stack = new Stack<char>();
        char p = '+';
        foreach (var c in s) {
            if ((p == '(' && c == ')') || (p == '[' && c == ']') || (p == '{' && c == '}')) {
                stack.Pop();
                if (stack.Count > 0) {
                    p = stack.Peek();
                }
                continue;
            }
            stack.Push(c);
            p = c;
        }
        if (stack.Count > 0) {
            return false;
        }
        return true;
    }
}
