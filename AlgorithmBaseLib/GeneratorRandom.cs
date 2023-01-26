namespace AlgorithmBaseLib;

public class Generator
{
    static public IEnumerable<int> GetRandomInteger(int count = 1, int limit = 10)
    {
        List<int> list = new List<int>();
        Random rand = new Random();
        for (int i = 0; i < count; i++)
        {
            list.Add(rand.Next(0, limit));
        }
        return list;
    }
}