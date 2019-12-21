// Runtime beats 46.17 % of csharp submissions.
public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0) {
            return false;
        }
        var temporary = x;
        var reverse = 0;
        
        while (x > 0) {
            reverse = (reverse * 10) + (x % 10);
            x = x / 10;
        }

        return (temporary == reverse);
    }
}
