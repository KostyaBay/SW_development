using System;

namespace design_pattern_composite
{
    public class Program //class which called functions and gives out a type command and the command itself on monitor
    {
        public string Command_easy() 
        {
            //warload give an easy command

            Warlord warlord = new Warlord();
            Soldier soldier = new Soldier();
            Console.WriteLine("Warlord: I give a easy command:");
            warlord.Warlord_easy(soldier);
            return "RESULT: Soldier: I obey, sir!";
        }

        public string Command_medium()
        {
            //warload give an medium or an hard command

            Warlord warlord = new Warlord();
            Composite_Rank tree = new Composite_Rank();
            Composite_Rank transfer1 = new Composite_Rank();
            transfer1.Add(new Soldier());
            transfer1.Add(new Soldier());
            Composite_Rank transfer2 = new Composite_Rank();
            transfer2.Add(new Soldier());
            tree.Add(transfer1);
            tree.Add(transfer2);
            Console.WriteLine("Warlord: Now I've give a medium command:");
            warlord.Warlord_easy(tree);
            return "RESULT: Transfer(Transfer(Soldier: I obey, sir! + Soldier: I obey, sir!)";
        }

        public string Command_hard()
        {
            Warlord warlord = new Warlord();
            Composite_Rank tree = new Composite_Rank();
            Soldier soldier = new Soldier();
            Console.WriteLine("Warlord: I don't need to check the my subordinates even when giving the hard command:\n");
            warlord.Warlord_hard(tree, soldier);  //tree = hard command, that is command transfer from one subordinate to another and come out tree of transfers
            return "RESULT: Transfer(Transfer(Soldier: I obey, sir! + Soldier: I obey, sir!) + Transfer(Soldier: I obey, sir!";
        }

        public static void Main(string[] args)
        {
            
        }
    }
}
