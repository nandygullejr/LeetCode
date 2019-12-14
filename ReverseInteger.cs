public class Solution {
    public int Reverse(int x) {
        long i = x;
        if (i == 0) {
            return 0;
        }
        
        long o = 0;
        do {
            o = o * 10;
            o = o + (i % 10); 
            i = i / 10;
        } while (i != 0); 
        
        if ((o > Int32.MaxValue) || (o < Int32.MinValue)) {
            return 0;
        }
        
        return (int)o;
    }
}
