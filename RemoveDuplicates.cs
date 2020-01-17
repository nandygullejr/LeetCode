public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length < 2) {
            return nums.Length;
        }
        
        var c = 1;
        for (var i = 0; i < nums.Length - 1; i++) {
            if (nums[i] < nums[i+1]) {
                nums[c] = nums[i+1];
                c++;
            }
        }
        return c;
    }
}
