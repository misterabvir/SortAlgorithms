namespace AlgorithmSortTester;

public class StatisticItem
{
    public int AmountItems { get; set; } = 0;
    public int AmountTest { get; set; } = 0;   
    public List<double> Times { get; set; } = new List<double>();
    public List<long> Swaps { get; set; } = new List<long>();

    public double AverageTime => Times.Average();
    public double WorstTime => Times.Max();
    public double BestTime => Times.Min();
    public double AverageSwaps => Swaps.Average();
    public double BiggestSwaps => Swaps.Max();
    public double LowestSwaps => Swaps.Min();
}