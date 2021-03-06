﻿using System;
using System.Collections.Generic;

using PortalsRPG.Models;

/*
 * Andy Cox
 * SD725-Final Project
 * "Portals of Technoprolis" Action-Rpg text version.
 * 
 * This simple program allows a player to assign a name to their Character.
 * Once named, the character is equipped with an initial weapon, and faces an npc-battle.
 * 
 * If they pass the battle, they earn the chance to assign a skill to their Character.
 * 
 * The project demonstrates Inhertiance of class objects,
 * using simple loops, constraining the user input, and allowing the user to do something
 * when they complete a task. The task completion allows for a skill assignment
 * using the "Strategy" design gang-of-four module imported and modified from HW-7.
 * 
 * In the fully-fleshed out action-rpg version, there will be many npcs.
 * This is simply to demo what is required for the final-project and scope of the course.
 * 
 * The System.Collections.Generic API is integrated into the type <T> lists used to 
 * assign values from Player-GameEnvironment interaction. That is demonstrated
 * at ln150 where the Skill chosen by the Player dynamically is assigned to their Skill-class.
 */

namespace PortalsRPG
{
    class Program
    {
        private static void MovePlayer(Location newLocation)
        {
            //to move player around the world-map
            //+ build world_map

            //instance of location of Location class will be the New location for player's move
             Location location = newLocation;
        }

        static void Main(string[] args)
        {
            string input;

            int playerInteraction;

            Player player1 = new Player(001, " ", 10, 0, 1, 100, 100);
            Console.WriteLine("Welcome to Technoprolis, what do you want to name your Player?");
            input = Console.ReadLine();
            player1.PlayerName = input.ToString();

            Console.WriteLine(" Player stats: {0} \n", player1.DisplayStats());

            Location start = new Location(World.LOCATION_ID_BASE_CAMP, "Base-Camp", "Start-Game");
            Console.WriteLine(start.DisplayLocation());

            Weapon bluntAxeHandle = new Weapon(1, 3, 1, "Blunt Axe Handle");

            Console.WriteLine(bluntAxeHandle.DisplayWeapon() + "\n");
            /*
            Console.WriteLine("Complete the initial Quest to assign a new skill to your Character.\n");

            Console.WriteLine("You leave your rebel base camp, and find some robo-guard at a destroyed statue: \n");
            Console.WriteLine(" ~~ Beat the robo-guard to assign your character a new skill ~~ \n");

            Npc roboGuard1 = new Npc(World.NPC_ID_ROBO_COMMANDO, "Robo-Commando", 3, 20, 5, 10, 10);

            do
            {
                int health;

                Console.WriteLine("Use your weapon to defeat the roboguard. (type a number 1-3) \n");
                input = Console.ReadLine();

                playerInteraction = int.Parse(input);

                //need to constrain so user can't go into negative points on roboguard
                if ((playerInteraction >= 1 && playerInteraction <= 3))
                {

                    Console.WriteLine("You deal " + playerInteraction + " damage to the robo-guard.");

                    health = roboGuard1.CurrentHealth - playerInteraction;

                    Console.WriteLine("Robo guard current health: " + roboGuard1.HealthUpdate(health));

                }
                else
                {
                    //player loses 10 health for not entering correct number:
                    health = player1.CurrentHealth - 10;
                    Console.WriteLine("You lose health points " + player1.HealthUpdate(health) + "\n");
                    Console.WriteLine("Please type a number in your weapon's range! \n");
                }

                if (roboGuard1.IsDead == true)
                {
                    roboGuard1.CurrentHealth = 0;
                    break;
                }

                if (player1.CurrentHealth == 0)
                {
                    //player is dead from lost battle, reset:
                    Environment.Exit(0);
                }

                if (input == null)
                {
                    Console.WriteLine("Please type a number in your weapon's range! \n");
                }

            }

            while (roboGuard1.CurrentHealth > 0);

            player1.LootUpdate(player1.Loot + roboGuard1.AwardLoot);
            player1.PointsUpdate(player1.Xp + roboGuard1.AwardXP);
            player1.LvlUp(player1.Level + 1);

            Console.WriteLine("= = = = = = = = = = = = = = = ");
            Console.WriteLine("You've achieved a new level!");
            Console.WriteLine("= = = = = = = = = = = = = = = \n");

            Console.WriteLine(player1.DisplayStats() + "\n");
            Console.WriteLine("You defeat the robo-guard to gain a skill. \n");

            //assign skill abstract strategy implementation + implement skill interface
            BoostingMethod boostMethod = new BoostingMethod();

            List<Skill> skills = new List<Skill>();
            //add the chosen skill to the Skill Class

            while (true)
            {
                Console.WriteLine("Do you want to boost your player skill now or save? \n(type 'boost' or 'save') \n");
                input = Console.ReadLine();
                if (input == "save")
                {
                    break;
                }

                boostMethod.SetBoost(input);

                Console.WriteLine("Do you want to boost your player's 'Health','Damage', 'Knowledge', or 'Shield'?");
                string player = Console.ReadLine();

                //namespace used to collect data from user input based on template for data in the abstract/sub classes
                Type p = Type.GetType("PortalsRPG." + player);
                try
                {
                    PlayerBoost pBoost = (PlayerBoost)Activator.CreateInstance(p);
                    boostMethod.SetPlayerBoost(pBoost);
                    boostMethod.Boost();
                    Console.WriteLine("You have chosen the " + player + " boost. \n");

                    //add the chosen skill to the Skill-attribute class
                    skills.Add(new Skill(001, player));
                    Console.WriteLine("The new skill has upgraded your current " + player + " level. \n");
                    foreach (Skill aSkill in skills)
                    {
                        Console.WriteLine(aSkill + "\n");
                    }

                    break;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + " \n");

                }
                Console.WriteLine(" = = = = = = = = \n");
                break;

            } */

            //pick up here to move the player to another location
            Console.WriteLine("Now, you find yourself at an abandoned satellite.");
            Location newLocation = new Location(World.LOCATION_ID_ABANDONED_SATELLITE , "Abandoned-Satellite", "Entry for quest 2");
            Console.WriteLine(newLocation.DisplayLocation());

            Console.WriteLine("Upon entering you discover a new gadget and an abandoned terminal to access.");
            Location newLocation1 = new Location(World.LOCATION_ID_TERMINAL_ACCESS, "Terminal-access", "Quest-2");
            Console.WriteLine(newLocation1.DisplayLocation());

            /*
            //equip player with programeter
            Weapon prograMeter = new Weapon(2, 4, 2, "Programeter");
            Console.WriteLine(prograMeter.DisplayWeapon() + "\n");

            //Quest 2:
            Npc evilComms = new Npc(World.NPC_ID_ROBO_COMMS_CLIENT, " Encrypted Robo-Terminal ",15, 12, 15, 20, 20);

            do
            {
                int health;

                Console.WriteLine("Use your programeter to get terminal access. (type a number 2-4) \n");
                input = Console.ReadLine();

                playerInteraction = int.Parse(input);

                //need to constrain so user can't go into negative points on roboguard
                if ((playerInteraction >= 2 && playerInteraction <= 4))
                {

                    Console.WriteLine("You deal " + playerInteraction + " damage to the terminal-client.");

                    health = evilComms.CurrentHealth - playerInteraction;

                    Console.WriteLine("Terminal decryption status: " + evilComms.HealthUpdate(health));

                }
                else
                {
                    //player loses 10 health for not entering correct number:
                    health = player1.CurrentHealth - 15;
                    Console.WriteLine("Zapped by the terminal circuit " + player1.HealthUpdate(health) + "\n");
                    Console.WriteLine("Please type a number in your weapon's range! \n");
                }

                if (evilComms.IsDead == true)
                {
                    evilComms.CurrentHealth = 0;
                    break;
                }

                if (player1.CurrentHealth == 0)
                {
                    //player is dead from lost battle, reset:
                    Environment.Exit(0);
                }

                if (input == null)
                {
                    Console.WriteLine("Please type a number in your weapon's range! \n");
                }

            }

            while (evilComms.CurrentHealth > 0);

            player1.LootUpdate(player1.Loot + evilComms.AwardLoot);
            player1.PointsUpdate(player1.Xp + evilComms.AwardXP);
            player1.LvlUp(player1.Level + 1);

            Console.WriteLine("= = = = = = = = = = = = = = = ");
            Console.WriteLine("You've achieved a new level!");
            Console.WriteLine("= = = = = = = = = = = = = = = \n");

            Console.WriteLine(player1.DisplayStats() + "\n");
            Console.WriteLine("You defeat the robo-guard to gain a skill. \n");

            //quest 2 complete:
            //+ now import skill-class strategy component
            while (true)
            {
                Console.WriteLine("Do you want to boost your player skill now or save? \n(type 'boost' or 'save') \n");
                input = Console.ReadLine();
                if (input == "save")
                {
                    break;
                }

                boostMethod.SetBoost(input);

                Console.WriteLine("Do you want to boost your player's 'Health','Damage', 'Knowledge', or 'Shield'?");
                string player = Console.ReadLine();

                //namespace used to collect data from user input based on template for data in the abstract/sub classes
                Type p = Type.GetType("PortalsRPG." + player);
                try
                {
                    PlayerBoost pBoost = (PlayerBoost)Activator.CreateInstance(p);
                    boostMethod.SetPlayerBoost(pBoost);
                    boostMethod.Boost();
                    Console.WriteLine("You have chosen the " + player + " boost. \n");

                    //add the chosen skill to the Skill-attribute class
                    skills.Add(new Skill(002, player));
                    Console.WriteLine("The new skill has upgraded your current " + player + " level. \n");
                    foreach (Skill aSkill in skills)
                    {
                        Console.WriteLine(aSkill + "\n");
                    }

                    break;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + " \n");

                }
                Console.WriteLine(" = = = = = = = = \n");
                break;

            } */

            //pick up here for future updates:
            //+ see programming notebook to re-access the logic of how a skill gets assigned to the class

            //todo: move_player method, or make 'Move' event_Handler
            //-->>> move player from robo_terminal_access to Forest,
            // + Forest gives access to rebel_camp, observer_battle, or robo_guard_camp

            //prompt player to move back to statue then forest....
            //recall exit is Terminal_Access, Abandoned_Satellite, Destroyed_Statue, then forest to be exact

            MovePlayer(newLocation1.MoveSouth = newLocation);
            //todo this with less hard-coding
            Console.WriteLine(newLocation.DisplayLocation());

            Location location = new Location(World.LOCATION_ID_DESTROYED_STATUE, "A destroyed human statue",
                " of some nefarious world-leader before the robots took over");

            Location location1 = new Location(World.LOCATION_ID_FOREST, "A misty forest.", "You find a wooded area shrowded by a smoky haze.");

            MovePlayer(newLocation.MoveSouth = location);
            Console.WriteLine(location.DisplayLocation());

            MovePlayer(newLocation.MoveWest = location1);
            Console.WriteLine(location1.DisplayLocation());

            //now from here build movement decision logic for player to enter 1 of 3 areas
            //+ see OneNote 'Technoprolis'


            Console.WriteLine("See you next time " + player1.PlayerName + " in another battle for Technoprolis. \n");
            Environment.Exit(0);

        }

    }

    //basically importing HW-7 module "Strategy" design example here:
    //abstract class acts to pass functionality to sub-classes
    abstract class PlayerBoost
    {
        public abstract void Boost(string player);
    }

    //4 subclasses return a different outcome but use the same data type to achieve that outcome
    class Health : PlayerBoost
    {
        public override void Boost(string player)
        {
            Console.WriteLine("\n  " + player + " applied to overall health.");
        }
    }

    class Damage : PlayerBoost
    {
        public override void Boost(string player)
        {
            Console.WriteLine("\n  " + player + " applied to damage dealing to npcs.");
        }
    }

    class Knowledge : PlayerBoost
    {
        public override void Boost(string player)
        {
            Console.WriteLine("\n  " + player + " applied to programming knowledge to enter Portals.");
        }
    }

    class Shield : PlayerBoost
    {
        public override void Boost(string player)
        {
            Console.WriteLine("\n  " + player + " applied to your armor.");
        }
    }

    //this class acts as a constructor to define the behavior of the data type being passed in by the user
    class BoostingMethod
    {
        private string Player;
        private PlayerBoost _playerBoost;

        public void SetPlayerBoost(PlayerBoost elixerBoost)
        {
            this._playerBoost = elixerBoost;
        }

        public void SetBoost(string name)
        {
            Player = name;
        }

        public void Boost()
        {
            _playerBoost.Boost(Player);
            Console.WriteLine();
        }
    }
}

