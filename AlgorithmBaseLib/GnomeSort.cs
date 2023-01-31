namespace AlgorithmBaseLib;

public class GnomeSort : AlgorithmBase
{
    
    public GnomeSort() => Name = "Gnome Sort";
    public override event SortHandler? SelectEvent;
    public override event SortPointHandler? StartEvent;
    public override event SortPointHandler? EndEvent;
    public override void Sort()
    {
        int index = 1;
        int pointer = index + 1;

        StartEvent?.Invoke(this);
        while (index < Items.Count)
        {
            
            SelectEvent?.Invoke(this, new SortEventHandlerArguments(){Index1 = index, Index2 = index + 1});

            if(Items[index - 1] < Items[index])
            {
                index = pointer;
                pointer++;
            }
            else
            {
                Swop(index, index - 1);
                index --;
                if(index == 0)
                {
                    index = pointer;
                    pointer++;
                }
            }
        }
        EndEvent?.Invoke(this);
    }
}
