public class Solution {
    public int FindFinalValue(int[] nums, int original) {
        while (true)
        {
            if (nums.Contains(original)){
                original = 2 * original;
            }
            else{
                break;            
            }
        }
        return original;
    }
}