using System;

public interface IRank //all abstract/interface class consist a few default functions
{
    public string Command();

    public void Add(IRank rank)
    {
        throw new NotImplementedException();
    }

    public void Remove(IRank rank)
    {
        throw new NotImplementedException();
    }

    public bool IsRank()
    {
        return true;
    }
}
