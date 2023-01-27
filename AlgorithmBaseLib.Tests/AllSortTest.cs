using AlgorithmBaseLib;
namespace AlgorithmBaseLib.Tests;

[TestClass]
public class AllSortTest
{
    [TestMethod]
    public void BubbleSortTest()
    {
        BubbleSort sorter = new BubbleSort();
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

    [TestMethod]
    public void CocktailTest()
    {
        CocktailSort sorter = new CocktailSort();
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

    [TestMethod]
    public void InsertSortTest()
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

    [TestMethod]
    public void ShellSortTest()
    {
        ShellSort sorter = new ShellSort();
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

    
    [TestMethod]
    public void StoogeSortTest()
    {
        StoogeSort sorter = new StoogeSort();
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