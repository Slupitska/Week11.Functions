using System;

namespace FunctionsReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] villains = { "Voldemort", "Darth Vader", "Sauron", "Joker", "Harly Quinn" };
            string[] heroes = { "Harry Potter", "Luke Skywalker", "Superman", "Lara Croft", "Aquaman" };
            string[] weapon = { "plastic fork", "banana", "magic wand", "flip-flop", "sharp mind" };

            string hero = GetCharacter(heroes);
            string villain = GetCharacter(villains);
            string heroWeapon = GetRandomValueFromArray(weapon);
            string villainWeapon = GetRandomValueFromArray(weapon);

            int heroHP = GenerateHP(hero);
            int villainHP = GenerateHP(villain);

            Console.WriteLine($"{hero}: {heroHP} HP will fight  {villain}: {villainHP}.");
            Console.WriteLine($"{hero} will fight with  {heroWeapon}.");
            Console.WriteLine($"{villain} will fight with  {villainWeapon}.");

            while (heroHP > 0 && villainHP > 0)
            {
                heroHP = heroHP - Hit(villain, villainWeapon);
                villainHP = villainHP - Hit(hero, heroWeapon);
            }
            if (heroHP <= 0)
            {
                Console.WriteLine("Dark Side wins!");

            }
            else
            {
                Console.WriteLine($"{hero}  saves the day!");
            }
        }
        public static string GetRandomValueFromArray(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return someArray[randomIndex];
        }
        public static string GetCharacter(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return someArray[randomIndex];
        }

        public static int GenerateHP(string characterName)
        {
            Random rnd = new Random();
            int randomHP = rnd.Next(0, characterName.Length + 1);
            return randomHP;
        }

        public static int Hit(string characterName, string weapon)
        {
            Random rnd = new Random();
            int strike = rnd.Next(0, weapon.Length + 1);

            if (strike == 0)
            {
                Console.WriteLine($"Oops.{characterName} missed the target.");

            }
            else if (strike == weapon.Length + 1)
            {
                Console.WriteLine($"Awesome.{characterName} make a CRITICAL HIT!.");
            }
            else
            {
                Console.WriteLine($"{characterName} hit {strike}");
            }

            return strike;
        }
    }
}