using System;
using System.Collections.Generic;
using Bees;

namespace Bees
{
    public class BeeManager
    {
        private List<Bee> beeList;

        public BeeManager()
        {
            beeList = new List<Bee>();
            GenerateRandomBees();
        }

        private void GenerateRandomBees()
        {
            Random random = new Random();
            for (int i = 0; i < 30; i++)
            {
                int beeType = random.Next(3); 
                switch (beeType)
                {
                    case 0:
                        beeList.Add(new WorkerBee());
                        break;
                    case 1:
                        beeList.Add(new DroneBee());
                        break;
                    case 2:
                        beeList.Add(new QueenBee());
                        break;
                }
            }
        }

        public void AttackAll(int damage)
        {
            foreach (var bee in beeList)
            {
                bee.Attack(damage);
            }
        }

        public void OutputAll()
        {
            foreach (var bee in beeList)
            {
                bee.Output();
            }
        }
    }
}
