using System;
using System.Collections.Generic;
using PortalsRPG.Models;

namespace PortalsRPG
{
    public class Character
    {
        //both Npc's and the Player are a type of Character
        //they will both have health attributes:
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }

        //struct:
        public Character(int currentHealth, int maxHealth)
        {
            CurrentHealth = currentHealth;
            MaxHealth = maxHealth;

        }
    }

    public class Player : Character
    {
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }
        public int Loot { get; set; }
        public int Xp { get; set;}
        public int Level { get; set; }
        public bool IsDead { get; set; }
        //false by default^ for bool

        //struct:
        public Player(int pID, string pName, int loot, int xp, int level,
            int currentHealth, int maxHealth) : base(currentHealth, maxHealth)
        {
            PlayerID = pID;
            PlayerName = pName;
            Loot = loot;
            Xp = xp;
            Level = level;
        }

        public string DisplayStats()
        {
            return PlayerName + " is playing as Bill Gnant, rebel-leader." + " Current Health: " + CurrentHealth + " \n" +
                    " Loot: " + Loot + " XP: " + Xp + " Current Level: " + Level;
        }

    }

    public class Npc : Character
    {
        public int NpcID { get; set; }
        public string NpcName { get; set; }
        public int MaxDamage { get; set; }
        public int AwardXP { get; set; }
        public int AwardLoot { get; set; }

        //public List<Loot> LootBank = new List<Loot>();

        public Npc(int npcid, string npcname, int maxDamage, int awardXP,
            int awardLoot, int currentHealth, int maxHealth): base(currentHealth, maxHealth)
        {
            NpcID = npcid;
            NpcName = npcname;
            MaxDamage = maxDamage;
            AwardXP = awardXP;
            AwardLoot = awardLoot;

        }

    }
}
