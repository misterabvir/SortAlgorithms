namespace AlgorithmBaseLib;

public class Bubble: AlgorithmBase
{
    override public void Sort()
    {
        var count = Items.Count;

        for (int j = 0; j < count; j++)
        {
            for (int i = 0; i < count - j - 1; i++)
            {
                var val1 = Items[i];
                var val2 = Items[i + 1];
                if(val1 > val2)
                {
                    Swop(i, i + 1);
                }
            }

            //count--;
        }
    }
}