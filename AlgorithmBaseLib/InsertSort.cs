namespace AlgorithmBaseLib;

public class InsertSort : AlgorithmBase
{
    public InsertSort() => Name = "Insert Sort";
    public override event SortHandler? SelectEvent;
    public override event SortPointHandler? StartEvent;
    public override event SortPointHandler? EndEvent;
    public override void Sort()
    {
        StartEvent?.Invoke(this);
        for (int i = 1; i < Items.Count(); i++)
        {
            for (int j = i; j > 0 && Items[j] < Items[j - 1]; j--)
            {
                SelectEvent?.Invoke(this, new SortEventHandlerArguments() { Index1 = j, Index2 = j - 1 });
                Swop(j, j - 1);
            }
        }


        EndEvent?.Invoke(this);
    }
}