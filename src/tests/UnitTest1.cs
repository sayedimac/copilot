namespace tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    [Test]
    public void TestAddition()
    {
        int a = 5;
        int b = 10;
        int result = a + b;
        Assert.AreEqual(15, result);
    }

    [Test]
    public void TestStringConcatenation()
    {
        string str1 = "Hello";
        string str2 = "World";
        string result = str1 + " " + str2;
        Assert.AreEqual("Hello World", result);
    }

    [Test]
    public void TestListContains()
    {
        var list = new List<int> { 1, 2, 3, 4, 5 };
        Assert.Contains(3, list);
    }
}
