using AlgorithmBaseLib;
namespace AlgorithmBaseLib.Tests;

[TestClass]
public class AllSortTest
{
    [TestMethod]
    public void BubbleSortTest()
    {
        BubbleSort bubble = new BubbleSort();
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

    [TestMethod]
    public void CocktailTest()
    {
        CocktailSort shaker = new CocktailSort();
        List<int> list = new List<int>();
        Random rand = new Random();
        for (int i = 0; i < 1000; i++)
        {
            list.Add(rand.Next(0, 1000));
        }
        shaker.Items.AddRange(list);

        list.Sort();
        shaker.Sort();

        for (int i = 0; i < list.Count; i++)
        {
            Assert.AreEqual(list[i], shaker.Items[i]);
        }
    }

    [TestMethod]
    public void SortTest()
    {
        InsertSort sorter = new InsertSort();
        List<int> list = new List<int>();
        Random rand = new Random();
        for (int i = 0; i < 1000; i++)
        {
            list.Add(rand.Next(0, 1000));
        }
        sorter.Items.AddRange(list);

        list.Sort();
        sorter.Sort();

        for (int i = 0; i < list.Count; i++)
        {
            Assert.AreEqual(list[i], sorter.Items[i]);
        }
    }
}