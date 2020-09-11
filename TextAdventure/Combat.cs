using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Transactions;

namespace TextAdventure
{
    public class Combat
    {
        public static int AttackDie()
        {
            Random rnd = new Random();
            return rnd.Next(1, 6);
        }

        public static int DefendDie()
        {
            Random rnd = new Random();
            return rnd.Next(1, 6);
        }

        public static int Attack(int dieRoll)
        {
            Console.WriteLine($"Your roll {dieRoll}");
            var didItConnect = (dieRoll >= 4) ? true : false;

            if (didItConnect == true)
            {
                Console.WriteLine("You Hit");
                return AttackDie();
            }
            else 
            {
                Console.WriteLine("Oh no you miss");
                return 0;
            }

            
        }

 
        public static void LetsFight()
        {
            int villanDamage;
            int heroDamage;
            
            //Create a Hero
            var hero = new Hero("He-Man", "Barbarian", 8, 2, 10);
            
            //Create a Villan
            var villan = new Villan("Bob", "Barbarian", 8, 2, 10);
            
            
            while (hero.HitPoints != 0 || villan.HitPoints != 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{hero.Name} Attacks roll the die");
                villanDamage = Attack(AttackDie());
                Console.WriteLine($"Attack Power: {villanDamage}");
                villan.HitPoints -= villanDamage;
                Console.WriteLine($"Current  Villan HP: {villan.HitPoints}");
                Console.ResetColor();

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{villan.Name} Attacks roll the die");
                heroDamage = Attack(AttackDie()); 
                Console.WriteLine($"Attack Power: {villanDamage}");
                hero.HitPoints -= heroDamage;
                Console.WriteLine($"Current  Hero HP: {hero.HitPoints}");
                Console.ResetColor();

                Console.ReadLine();

                if (villan.HitPoints <= 0 || hero.HitPoints <= 0)
                {
                    Console.WriteLine("The Battle has Ended");
                    Environment.Exit(0);
                }
            }

        }


    }
}
