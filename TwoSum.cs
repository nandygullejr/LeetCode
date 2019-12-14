public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> wantedNumbers = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++) {
            if (wantedNumbers.ContainsKey(nums[i])) {
                return new int[] {wantedNumbers[nums[i]], i};
            } else {
                wantedNumbers[target - nums[i]] = i;
            }
        }
        return new int[] {0, 0};
    }
}
