using System.Text;
namespace AlgorithmSortTester;

public class StatisticInfo
{
    
    public string Name { get; set; } = "";
    public List<StatisticItem> Statistic { get; set; } = new List<StatisticItem>();

    public override string ToString()
    {
        string format = "{0,-8}|{1,-6}|{2,-10:#0.000}|{3,-10:#0.000}|{4,-10:#0.000}|{5,-15}|{6,-15}|{7,-15}\n";
        
        StringBuilder sb = new StringBuilder();
        
        sb.AppendFormat($"Result of \"{Name}\"\n");

        sb.AppendFormat(format, 
                "Count",
                "Tests",
                "AvgTime", 
                "MinTime", 
                "MaxTime", 
                "AvgSwap", 
                "MinSwap", 
                "MaxSwap");
        
        sb.Append(new string('-', 90));
        sb.Append("\n");
        
        foreach (var item in Statistic)
        {
            sb.AppendFormat(format, 
                item.AmountItems,
                item.AmountTest,
                item.AverageTime, 
                item.BestTime, 
                item.WorstTime, 
                item.AverageSwaps, 
                item.LowestSwaps, 
                item.BiggestSwaps);
        }
        
        return sb.ToString();
    }
}