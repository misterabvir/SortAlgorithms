using AlgorithmBaseLib;

namespace AlgorithmSortTester;

public abstract class SortTesterBase
{
    protected AlgorithmBase _algorithm = new AlgorithmBase();

    public SortTesterBase(AlgorithmBase algorithm)
    {
        _algorithm = algorithm;
        _algorithm.SelectEvent += EventSelect;
        _algorithm.BeforeSwopEvent += EventBeforeSwap;
        _algorithm.AfterSwopEvent += EventAfterSwap;
        _algorithm.StartEvent += EventStartSort;
        _algorithm.EndEvent += EventEndSort;
    }
    virtual protected void EventBeforeSwap(AlgorithmBase algorithm, SortEventHandlerArguments args){}
    virtual protected void EventAfterSwap(AlgorithmBase algorithm, SortEventHandlerArguments args){}
    virtual protected void EventSelect(AlgorithmBase algorithm, SortEventHandlerArguments args){}
    virtual protected void EventStartSort(AlgorithmBase algorithm){}
    virtual protected void EventEndSort(AlgorithmBase algorithm){}

    abstract public void Start();
}