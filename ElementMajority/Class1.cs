namespace ElementMajority;
public class Class1
{
    public int MajorityElement(int[] nums)
    {
        int majority = nums.GroupBy(x => x).OrderByDescending(y => y.Count()).First().Key;
        return majority;
    }
}
