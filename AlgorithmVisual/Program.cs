using AlgorithmBaseLib;
using AlgorithmSortTester;
using System;

namespace AlgorithmsVisual;

public class Program
{
    static public List<AlgorithmBase> algorithms = new List<AlgorithmBase>();

    static void Main(string[] args)
    {
        Init();

        if (args == null || args.Length == 0)
        {
            Console.WriteLine("Possible options:");
            Console.WriteLine("\'test\': run test");
            Console.WriteLine("\'demo\': run demo");
        }
        else if ((args?[0] ?? "") == "demo")
        {
            StartDemo(algorithms[GetInput()]);
        }
        else if ((args?[0] ?? "") == "test")
        {
            StartTest(algorithms[GetInput()]);
        }
    }

    static public int GetInput()
    {
        Menu();
        int input = -1;
        do { 
            Console.Write("Take your choice: ");
        } while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > algorithms.Count());
        return input - 1;
    }

    static public void Menu()
    {
        for (int i = 0; i < algorithms.Count(); i++)
        {
            Console.WriteLine($"{i + 1}. {algorithms[i].Name}");
        }
    }

    static public void Init()
    {
        algorithms.Add(new BubbleSort());
        algorithms.Add(new CocktailSort());
        algorithms.Add(new InsertSort());
    }


    static public void StartDemo(AlgorithmBase algorithm)
    {
        SortDemo sortDemo = new SortDemo(algorithm);
        sortDemo.MaxLimitValue = 100;
        sortDemo.QuantityOfElements = 10;
        sortDemo.TimeSpan = 500;
        sortDemo.Start();
    }

    static public void StartTest(AlgorithmBase algorithm)
    {
        SortTimeTester sortTester = new SortTimeTester(new BubbleSort());
        sortTester.MaxLimitQuantityElements = 1001;
        sortTester.QuantityOfTest = 100;
        sortTester.Step = 10;
        sortTester.Start();
    }
}
