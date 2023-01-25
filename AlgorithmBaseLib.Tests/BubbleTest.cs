using AlgorithmBaseLib;
namespace AlgorithmBaseLib.Tests;

[TestClass]
public class BubbleTest
{
    [TestMethod]
    public void SortTest()
    {
        Bubble bubble = new Bubble();
        List<int> list = new List<int>();
        Random rand = new Random();
        for (int i = 0; i < 1000; i++)
        {
            list.Add(rand.Next(0, 1000));
        }
        bubble.Items.AddRange(list);

        list.Sort();
        bubble.Sort();

        for (int i = 0; i < list.Count; i++)
        {
            Assert.AreEqual(list[i], bubble.Items[i]);
        }

    }
}