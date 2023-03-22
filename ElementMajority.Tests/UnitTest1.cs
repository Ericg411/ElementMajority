namespace ElementMajority.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;
    public UnitTest1() 
    {
        _test = new Class1();
    }

    [TestMethod]
    public void TestMethod1()
    {
        int[] nums = {3,2,3};
        var result = _test.MajorityElement(nums);
        Assert.AreEqual(3, result);
    }
    
    [TestMethod]
    public void TestMethod2()
    {
        int[] nums = { 2, 2, 1, 1, 1, 2, 2 };
        var result = _test.MajorityElement(nums);
        Assert.AreEqual(2, result);
    }
   
}