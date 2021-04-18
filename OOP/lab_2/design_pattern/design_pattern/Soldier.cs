public class Soldier : IRank //class consist only soldiers
{
    public string Command()
    {
        return "Soldier: I obey, sir!";
    }

    public bool IsRank()
    {
        return false;
    }
}
