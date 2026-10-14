using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior("Eyad", 100);

            Wizard wizard = new Wizard("Wadea", 100);

            HealthPotion healthPotion = new HealthPotion();

            List<GameCharacter> characters = new List<GameCharacter> { warrior, wizard };

            foreach(var character in characters)
            {
                character.UseSpecialAbility();
                character.TakeDamage(10);
                Console.WriteLine($"{character.Name}'s Health: {character.Health}");
                character.Heal(5);
                Console.WriteLine($"{character.Name}'s Health After Healing: {character.Health}");
                healthPotion.Collect();
                Console.WriteLine("----------------------------------------------------------------");
               
            }

        }
    }
}
