namespace AlgorithmBaseLib;

public class BubbleSort : AlgorithmBase
{

    public override event SortHandler? SelectEvent;
    public override event SortPointHandler? StartEvent;
    public override event SortPointHandler? EndEvent;
    override public void Sort()
    {
        StartEvent?.Invoke(this);
        var count = Items.Count;
        for (int j = 0; j < count; j++)
        {
            for (int i = 0; i < count - j - 1; i++)
            {
                var val1 = Items[i];
                var val2 = Items[i + 1];
                SelectEvent?.Invoke(this, new SortEventHandlerArguments() { Index1 = i, Index2 = i + 1 });
                if (val1 > val2)
                {
                    Swop(i, i + 1);
                }
            }
        }
         EndEvent?.Invoke(this);
    }

    public BubbleSort()
    {
        Name = "Bubble Sort";
    }
}