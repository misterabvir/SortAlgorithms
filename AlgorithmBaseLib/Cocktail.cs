namespace AlgorithmBaseLib;

public class CocktailSort : AlgorithmBase
{
    public CocktailSort() => Name = "Cocktail Sort";
    public override event SortHandler? SelectEvent;
    public override event SortPointHandler? StartEvent;
    public override event SortPointHandler? EndEvent;

    public override void Sort()
    {
        int left = 0;
        int right = Items.Count() - 1;
        StartEvent?.Invoke(this);
        while (left < right)
        {
            for (int i = left; i < right; i++)
            {
                SelectEvent?.Invoke(this, new SortEventHandlerArguments() { Index1 = i, Index2 = i + 1 });
                if (Items[i] > Items[i + 1])
                {
                    Swap(i, i + 1);
                }
            }
            right--;
            for (int i = right; i > left; i--)
            {
                SelectEvent?.Invoke(this, new SortEventHandlerArguments() { Index1 = i, Index2 = i - 1 });
                if (Items[i] < Items[i - 1])
                {
                    Swap(i, i - 1);
                }
            }
            left++;
        }
        EndEvent?.Invoke(this);
    }
}