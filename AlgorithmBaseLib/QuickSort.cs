namespace AlgorithmBaseLib;

public class QuickSort :AlgorithmBase
{
    public QuickSort() => Name = "Quick Sort";
    public override event SortHandler? SelectEvent;
    public override event SortPointHandler? StartEvent;
    public override event SortPointHandler? EndEvent;

    public override void Sort()
    {
        StartEvent?.Invoke(this);
        MakeSort(0, Items.Count - 1);
        EndEvent?.Invoke(this);
    }


    private void MakeSort(int left, int right)
    {
        if(left >= right) return;

        int pivot = Sorting(left, right);

        MakeSort(left, pivot - 1);
        MakeSort(pivot + 1, right);
    }

    private int Sorting(int left, int right)
    {
        int pointer = left;
        for (int i = left; i <= right; i++)
        {
            SelectEvent?.Invoke(this, new SortEventHandlerArguments(){Index1 = i, Index2 = right});
            if(Items[i] < Items[right])
            {
                Swop(pointer, i);
                pointer++;
            }
        }
        Swop(pointer, right);
        return pointer;
    }
}
