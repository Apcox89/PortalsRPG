using System;
using PortalsRPG.Models;

namespace PortalsRPG
{
    //to test classes, properties, fields, methods, and interfaces
    //Path of Exile style game beginning (action-RPG)
    class Program 
    {
        static void Main()
        {
            string input;
            
            Player player1 = new Player(001, " ", 10, 0, 1, 100, 100);
            Console.WriteLine("Welcome to Technoprolis, what do you want to name your Player?");
            input = Console.ReadLine();
            player1.PlayerName = input.ToString();

            Console.WriteLine(" Player stats: {0} \n", player1.DisplayStats());

            Location start = new Location(1, "Base-Camp", "Start-Game");
            Console.WriteLine(start.DisplayLocation());

            Weapon bluntAxeHandle = new Weapon(1, 3, 1, "Blunt Axe Handle");

            Console.WriteLine("You begin with a simple weapon to help on your quests.\n");
            Console.WriteLine(bluntAxeHandle.DisplayWeapon() + "\n");
            Console.WriteLine("Complete the initial Quest to assign a few skills to your Character.\n");

            //initialize the NPC and allow the players HP to get taxed or not

            try
            {
                while (player1.IsDead != true)
                {
                    
                }
                Console.WriteLine("Hit 1 to exit at anytime");
                //what happens to falsify the condition? Player must lose 100 health in battle-seq
                //or if they succeed, they can assign a set of skills to their Character.
                //Console.WriteLine(player1.IsDead);
            }
            catch
            {
                Environment.Exit(1);
            }


            //classes update: 11/12 missing randomnumbergenerator, 
            //PlayerMission is now decomposed to Quest Class.
            // + Loot object class within Inventory? would be 11/13 instead of original 14

        }

      

    }


}
