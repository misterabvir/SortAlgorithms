using AlgorithmBaseLib;

namespace AlgorithmSortTester;

public class SortDemo : SortTesterBase
{

    public SortDemo(AlgorithmBase algorithm) : base(algorithm) { }

    public int QuantityOfElements { get; set; } = 10;
    public int MaxLimitValue { get; set; } = 100;
    public int TimeSpan { get; set; } = 100;

    public override void Start()
    {
        List<int> items = new List<int>();
        items.AddRange(Generator.GetRandomInteger(count: QuantityOfElements, limit: MaxLimitValue));
        _algorithm.Items.AddRange(items);
        _algorithm.Sort();
        _algorithm.Items.Clear();

    }

    protected override void EventStartSort(AlgorithmBase algorithm)
    {
        Console.WriteLine($"{algorithm.Name} demo:");
        Print(algorithm, new SortEventHandlerArguments() { Index1 = -1, Index2 = -1 });
        Console.WriteLine();
    }
    protected override void EventEndSort(AlgorithmBase algorithm) => Print(algorithm, new SortEventHandlerArguments() { Index1 = -1, Index2 = -1 });
    protected override void EventSelect(AlgorithmBase algorithm, SortEventHandlerArguments args) => Print(algorithm, args, ConsoleColor.DarkGreen);
    protected override void EventBeforeSwap(AlgorithmBase algorithm, SortEventHandlerArguments args) => Print(algorithm, args, ConsoleColor.DarkRed);
    protected override void EventAfterSwap(AlgorithmBase algorithm, SortEventHandlerArguments args) => Print(algorithm, args, ConsoleColor.DarkBlue);

    private void Print(AlgorithmBase algorithm, SortEventHandlerArguments args, ConsoleColor color = ConsoleColor.Black)
    {
        Console.Write("\r[");
        for (int i = 0; i < algorithm.Items.Count; i++)
        {
            if (i == args.Index1 || i == args.Index2)
            {
                Console.BackgroundColor = color;
            }
            Console.Write($" {algorithm.Items[i]} ");
            Console.ResetColor();
        }
        Console.Write($"] ");

        Thread.Sleep(TimeSpan);
    }
}