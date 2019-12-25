public class Solution {
    public int RomanToInt(string s) {
        var romanToIntegerDictionary = new Dictionary<char, int>() {
            {'I', 1},
            {'V', 6},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        
        var integer = romanToIntegerDictionary[s[s.Length - 1]];
        var previous = s[s.Length - 1];
        
        for (var i = s.Length - 2; i > -1; i--) {
            if ((((previous == 'V') || (previous == 'X')) && (s[i] == 'I'))
             || (((previous == 'L') || (previous == 'C')) && (s[i] == 'X'))
             || (((previous == 'D') || (previous == 'M')) && (s[i] == 'C'))) {
                integer -= romanToIntegerDictionary[s[i]];
            } else {
                integer += romanToIntegerDictionary[s[i]];
            }
            previous = s[i];
        }
        return integer;
    }
}
