using AlgorithmBaseLib;
using System.Diagnostics;

namespace AlgorithmSortTester;

public class SortTimeTester : SortTesterBase
{
    StatisticInfo _info = new StatisticInfo();
    public SortTimeTester(AlgorithmBase algorithm) : base(algorithm) { }
    public int MaxLimitQuantityElements { get; set; } = 1001;
    public int Step { get; set; } = 10;
    public int QuantityOfTest { get; set; } = 10;
    private long _countSwap = 0;
    private List<long> _countSwapList = new List<long>();
    private List<long> _countTimeList = new List<long>();
    private Stopwatch _watch = new Stopwatch();

    protected override void EventAfterSwap(AlgorithmBase algorithm, SortEventHandlerArguments args)
    {
        _countSwap++;
    }

    public override void Start()
    {
        _info.Name = _algorithm.Name;
        _info.Statistic.Clear();
        StatisticItem stat;

        for (int i = 10; i < MaxLimitQuantityElements; i *= Step)
        {

            stat = new StatisticItem();
            stat.AmountItems = i;
            stat.AmountTest = QuantityOfTest;
            for (int j = 0; j < QuantityOfTest; j++)
            {
                _algorithm.Items.AddRange(Generator.GetRandomInteger(count: i, limit: i * 10));
                double time = TimeTesterFunc(() => _algorithm.Sort());
                Console.Write($"\rTest {j + 1,2} for {i, -7} elements " + new string('.', j + 1));
                _algorithm.Items.Clear();
                stat.Times.Add(time);
                stat.Swaps.Add(_countSwap);
                _countSwap = 0;
            }
            Console.Write("\n");
            _info.Statistic.Add(stat);
        }

        Console.WriteLine(_info);
    }

    private double TimeTesterFunc(Action func)
    {
        _watch = new Stopwatch();
        _watch.Start();
        func();
        _watch.Stop();
        return _watch.Elapsed.TotalMilliseconds;
    }
}


