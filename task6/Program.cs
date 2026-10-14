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
            Warrior warrior = new Warrior("Conan", 100);

            Wizard wizard = new Wizard("Gandalf", 80);

            List<GameCharacter> characters = new List<GameCharacter> { warrior, wizard };

            foreach(var character in characters)
            {
              character.UseSpecialAbility();
                character.TakeDamage(10);
                Console.WriteLine(character.Health);
                character.Heal(5);

            }

        }
    }
}
