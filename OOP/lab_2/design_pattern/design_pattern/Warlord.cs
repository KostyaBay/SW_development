using System;

public class Warlord : Soldier //class warload - the human who give a whatever command
{
    Soldier soldier = new Soldier();
    public string Warlord_easy() //warlord give as easy command(task for one subordinate)
    {
        Console.WriteLine("Warlord: I give a easy command:");
        return "RESULT: " + soldier.Command();
    }

    public string Warlord_medium() //warlord give as medium command(task for few subordinates)
    {
        Console.WriteLine("Warlord: Now I've give a medium command:");

        return "RESULT: Transfer(Transfer(" + soldier.Command() + " + " + soldier.Command() + ")";
    }

    public string Warlord_hard() //too warload give so and hard command(task for many subordinates) 
    {
        Console.WriteLine("Warlord: I don't need to check the my subordinates even when giving the hard command:\n");

        return "RESULT: Transfer(Transfer(" + soldier.Command() + " + " + soldier.Command() + ") + Transfer(" + soldier.Command() + "))"; //hard command, that is command transfer from one subordinate to another and come out tree of transfers
    }
}