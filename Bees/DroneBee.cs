using Bees;

namespace Bees
{
    public class DroneBee : Bee
    {
        public DroneBee() : base(80) { }

        public override void Attack(int damage)
        {
            base.Attack(damage);
        }
    }
}
