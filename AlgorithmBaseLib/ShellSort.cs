namespace AlgorithmBaseLib;

public class ShellSort : AlgorithmBase
{
    public ShellSort() => Name = "Shell Sort";
    public override event SortHandler? SelectEvent;
    public override event SortPointHandler? StartEvent;
    public override event SortPointHandler? EndEvent;

    public override void Sort()
    {
        StartEvent?.Invoke(this);
        var distance = Items.Count() / 2;

        while(distance >= 1)
        {
            for (int i = distance; i < Items.Count; i++)
            {
                var j = i;
                while ((j >= distance))
                {
                    SelectEvent?.Invoke(this, 
                            new SortEventHandlerArguments(){Index1 = j, Index2 = j - distance});
                    if(Items[j-distance] > Items[j])
                    {
                        Swop(j, j - distance);
                        j -= distance;
                    }
                    else break;                  
                }
            }
            distance /= 2;
        }
        EndEvent?.Invoke(this);
    }
}