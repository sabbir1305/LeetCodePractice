
public class Solution
{
    public int PivotIndex(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int leftSum = SumOfLeft(nums, i);
            int rightSum = SumOfRight(nums, i+1);
            if(leftSum == rightSum)
                return i;
        }
        return -1;
    }

    private int SumOfLeft(int[] nums, int end)
    {
        int sum = 0;
        for (int i = 0; i < end; i++)
        {
            sum += nums[i];
        }
        return sum;
    }
    private int SumOfRight(int[] nums, int start)
    {
        int sum = 0;
        for (int i = start; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        return sum;
    }
}

