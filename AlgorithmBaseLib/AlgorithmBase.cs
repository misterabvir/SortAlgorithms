namespace AlgorithmBaseLib;

public class AlgorithmBase
{
    
    public string Name {get; protected set;} = ""; 
    public List<int> Items  {get; set;} = new List<int>();
    public delegate void SortHandler(AlgorithmBase algorithm, SortEventHandlerArguments args);
    public delegate void SortPointHandler(AlgorithmBase algorithm);
   
    public virtual event SortPointHandler? StartEvent;
    public virtual event SortPointHandler? EndEvent;
    public virtual event SortHandler? BeforeSwapEvent;
    public virtual event SortHandler? AfterSwapEvent;
    public virtual event SortHandler? SelectEvent;



    virtual public void Sort()
    {
        StartEvent?.Invoke(this);
        SelectEvent?.Invoke(this, new SortEventHandlerArguments(){Index1 = -1, Index2 = -1});
        Items.Sort();
        EndEvent?.Invoke(this);
    }

    protected void Swap(int ind1, int ind2)
    {
        BeforeSwapEvent?.Invoke(this, new SortEventHandlerArguments(){Index1 = ind1, Index2 = ind2});
        if(ind1 < Items.Count && ind2 < Items.Count)
        {
            var temp = Items[ind1];
            Items[ind1]= Items[ind2];
            Items[ind2] = temp;
        }
        AfterSwapEvent?.Invoke(this, new SortEventHandlerArguments(){Index1 = ind1, Index2 = ind2});
    } 
}

public class SortEventHandlerArguments
{
    public int Index1 { get; set; }
    public int Index2 { get; set; }   
}
