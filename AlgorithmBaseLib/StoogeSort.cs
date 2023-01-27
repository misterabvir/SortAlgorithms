namespace AlgorithmBaseLib;

public class StoogeSort : AlgorithmBase
{
    public StoogeSort() => Name = "Stooge Sort";
    public override event SortHandler? SelectEvent;
    public override event SortPointHandler? StartEvent;
    public override event SortPointHandler? EndEvent;

    public override void Sort()
    {
        StartEvent?.Invoke(this);
        
        Stooge(0, Items.Count - 1);

        EndEvent?.Invoke(this);
    }

    private void Stooge(int startIndex, int endIndex)
    {
        
        SelectEvent?.Invoke(this, new SortEventHandlerArguments(){Index1 = startIndex, Index2 = endIndex});
        if(Items[startIndex] > Items[endIndex])
        {
            Swop(startIndex, endIndex);
        }

        if(endIndex - startIndex > 1)
        {
            var length = (endIndex - startIndex + 1) / 3;
            Stooge(startIndex, endIndex - length);
            Stooge(startIndex + length, endIndex);
            Stooge(startIndex, endIndex - length);
        }
    }
}