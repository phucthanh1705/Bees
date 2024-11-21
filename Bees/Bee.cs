using System;

namespace Bees
{
    public class Bee
    {
        public int Health { get; protected set; }
        public bool IsDead { get; protected set; }

        public Bee(int initialHealth)
        {
            Health = initialHealth;
        }

        public virtual void Attack(int damage)
        {
            if (IsDead == true) return;

            Health -= damage;
            if (Health <= 0)
            {
                Health = 0;
                IsDead = true;
            }
        }

        public virtual void Output()
        {
            Console.WriteLine($"{this.GetType().Name} - Health: {Health}, IsDead: {IsDead}");
        }
    }
}
