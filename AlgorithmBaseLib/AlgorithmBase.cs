namespace AlgorithmBaseLib;

public class AlgorithmBase
{
    public List<int> Items  {get; set;} = new List<int>();

    virtual public void Sort()
    {
        Items.Sort();
    }

    protected void Swop(int ind1, int ind2)
    {
        if(ind1 < Items.Count && ind2 < Items.Count)
        {
            var temp = Items[ind1];
            Items[ind1]= Items[ind2];
            Items[ind2] = temp;
        }
    }    
}
