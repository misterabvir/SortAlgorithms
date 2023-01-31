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
            return;
        }

        if(args[0] == "demo")
        {
            StartDemo(algorithms[GetInput()]);
        }
        else if (args[0] == "test")
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
        algorithms.Add(new StoogeSort());
        algorithms.Add(new InsertSort());
        algorithms.Add(new ShellSort());
        algorithms.Add(new QuickSort());
        algorithms.Add(new GnomeSort());
    }


    static public void StartDemo(AlgorithmBase algorithm, int timeSpan = 500, int countOfElements = 10, int limits = 100)
    {
        SortDemo sortDemo = new SortDemo(algorithm);
        sortDemo.MaxLimitValue = limits;
        sortDemo.QuantityOfElements = countOfElements;
        sortDemo.TimeSpan = timeSpan;
        sortDemo.Start();
    }

    static public void StartTest(AlgorithmBase algorithm, int maxCountOfElements = 10000, int step = 10, int countOfTest = 10)
    {
        SortTimeTester sortTester = new SortTimeTester(algorithm);
        sortTester.MaxLimitQuantityElements = maxCountOfElements;
        sortTester.QuantityOfTest = countOfTest;
        sortTester.Step = step;
        sortTester.Start();
    }
}
