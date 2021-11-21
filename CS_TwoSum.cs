public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var numsDictionary = new Dictionary<int, int>();

    var complement = 0;
    for (var i = 0; i < nums.Length; i++)
    {
        complement = target - nums[i];
        var index = 0;
        if ( numsDictionary.TryGetValue(complement, out index))
        {
            return new int[] { index, i };
        }

        if (numsDictionary.ContainsKey(nums[i]) == false)
        {
            numsDictionary.Add(nums[i], i);
        }
    }

    return null;
        
    }
}
