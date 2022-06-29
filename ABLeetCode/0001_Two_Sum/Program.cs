using System.Linq;

var result = new Solution().TwoSum(new int[] { 3, 2, 4 }, 6);

foreach (var item in result)
{
    Console.Write($"{item},");
}


public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int firstIndex = -1;

        while (firstIndex++ < nums.Length)
        {
            for (int i = firstIndex + 1; i < nums.Length; i++)
            {
                if (nums[firstIndex] + nums[i] == target)
                {
                    return new int[] { firstIndex, i };
                }
            }
        }

        return Array.Empty<int>();
    }
}