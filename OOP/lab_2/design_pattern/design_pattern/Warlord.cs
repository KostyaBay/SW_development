using System;

public class Warlord //class warload - the human who give a whatever command
{
    public void Warlord_easy(IRank soldier) //warlord give as easy command(task for one subordinate)
    {
        Console.WriteLine($"RESULT: {soldier.Command()}\n");
    }

    public void Warlord_hard(IRank rank1, IRank rank2) //too warload give so and hard command(task for many subordinates) or medium command(task for few subordinates)
    {
        if (rank1.IsRank())
        {
            rank1.Add(rank2);
        }

        Console.WriteLine($"RESULT: {rank1.Command()}");
    }
}