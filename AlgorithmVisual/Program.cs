using AlgorithmBaseLib;
using System;

namespace AlgorithmsVisual;

public class Program
{
    static private Bubble bubble = new Bubble();
    
    static void Main()
    {
        Fill(bubble, 10, 100);
        Print(bubble);
        bubble.Sort();
        Print(bubble);
        
    }

    static public void Fill(AlgorithmBase collection, int count, int max)
    {
        Random rand = new Random();
        for (int i = 0; i < count; i++)
        {
            collection.Items.Add(rand.Next(0, max));
        }
    }

    static public void Print(AlgorithmBase collection)
    {
        Console.WriteLine($"[{string.Join(", ", collection.Items)}]");
    }
}
