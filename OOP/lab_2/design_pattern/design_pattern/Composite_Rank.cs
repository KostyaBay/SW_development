using System.Collections.Generic;

public class Composite_Rank : IRank //class consist as officers,so and soldiers (subordination)
{
    protected List<IRank> _military = new List<IRank>();

    public void Add(IRank rank)
    {
        this._military.Add(rank);
    }

    public void Remove(IRank rank)
    {
        this._military.Remove(rank);
    }

    public string Command()
    {
        int i = 0;
        string result = "Transfer(";

        foreach (IRank rank in this._military)
        {
            result += rank.Command();
            if (i != this._military.Count - 1)
            {
                result += " + ";
            }
            i++;
        }
        return result + ")";
    }
}
