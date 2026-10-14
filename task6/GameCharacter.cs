using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    abstract class GameCharacter
    {


        private int _health;

        public string Name { get; set; }

        public int Health
        {
            get { return _health; }

            set
            {
                if (value >= 0 && value <= 100)
                {
                    _health = value;
                }
                else
                {
                    Console.WriteLine("Health must be between 0 and 100.");
                    Environment.Exit(1);
                }
            }
        }

        public GameCharacter(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public abstract void UseSpecialAbility();

        public virtual void TakeDamage(int amount)
        {
            Health -= amount;
        }

        public void Heal()
        {
            Health += 10;
        }

        public void Heal(int amount)
        {
            Health += amount;


        }
    }
}