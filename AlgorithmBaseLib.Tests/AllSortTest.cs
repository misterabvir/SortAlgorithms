using AlgorithmBaseLib;
namespace AlgorithmBaseLib.Tests;

[TestClass]
public class AllSortTest
{
    List<int> _list = new List<int>();
    List<int> _sorted = new List<int>();


    [TestInitialize]
    public void Init()
    {
        Random rand = new Random();
        _list.Clear();
        _sorted.Clear();
        for (int i = 0; i < 1000; i++)
        {
            _list.Add(rand.Next(0, 100000));
        }
        _sorted.AddRange(_list);
        _sorted.Sort();
    }
    
    
    [TestMethod]
    public void BubbleSortTest()
    {
        BubbleSort sorter = new BubbleSort();
        sorter.Items.AddRange(_list);

        sorter.Sort();

        for (int i = 0; i < _list.Count; i++)
        {
            Assert.AreEqual(_sorted[i], sorter.Items[i]);
        }
    }

    [TestMethod]
    public void CocktailTest()
    {
        CocktailSort sorter = new CocktailSort();
        sorter.Items.AddRange(_list);

        _list.Sort();
        sorter.Sort();

        for (int i = 0; i < _list.Count; i++)
        {
            Assert.AreEqual(_sorted[i], sorter.Items[i]);
        }
    }

    [TestMethod]
    public void InsertSortTest()
    {
        InsertSort sorter = new InsertSort();
        sorter.Items.AddRange(_list);
        _list.Sort();
        sorter.Sort();

        for (int i = 0; i < _list.Count; i++)
        {
            Assert.AreEqual(_sorted[i], sorter.Items[i]);
        }
    }

    [TestMethod]
    public void ShellSortTest()
    {
        ShellSort sorter = new ShellSort();
        sorter.Items.AddRange(_list);

        _list.Sort();
        sorter.Sort();

        for (int i = 0; i < _list.Count; i++)
        {
            Assert.AreEqual(_sorted[i], sorter.Items[i]);
        }
    }

    
    [TestMethod]
    public void StoogeSortTest()
    {
        StoogeSort sorter = new StoogeSort();
        sorter.Items.AddRange(_list);

        _list.Sort();
        sorter.Sort();

        for (int i = 0; i < _list.Count; i++)
        {
            Assert.AreEqual(_sorted[i], sorter.Items[i]);
        }
    }

    [TestMethod]
    public void QuickSortTest()
    {
        QuickSort sorter = new QuickSort();
        sorter.Items.AddRange(_list);

        _list.Sort();
        sorter.Sort();

        for (int i = 0; i < _list.Count; i++)
        {
            Assert.AreEqual(_sorted[i], sorter.Items[i]);
        }
    }

    [TestMethod]
    public void GnomeSortTest()
    {
        GnomeSort sorter = new GnomeSort();
        sorter.Items.AddRange(_list);

        _list.Sort();
        sorter.Sort();

        for (int i = 0; i < _list.Count; i++)
        {
            Assert.AreEqual(_sorted[i], sorter.Items[i]);
        }
    }
}