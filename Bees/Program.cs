using System;
using Bees;

namespace Bees
{
    class Program
    {
        static void Main(string[] args)
        {
            BeeManager manager = new BeeManager();

            Console.WriteLine("== Initial Bee Status ==");
            manager.OutputAll();

            Console.WriteLine("==========================");
            while (true)
            {
                Console.Write("Nhập số lượng sát thương (hoặc nhập 0 để thoát): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int n)) 
                {
                    Console.WriteLine("\n== Attacking All Bees (Damage: " + n + ") ==");
                    manager.AttackAll(n);
                    manager.OutputAll();

                    if (n == 0) break; 
                }
                else
                {
                    Console.WriteLine("Vui lòng nhập một số hợp lệ.");
                }
            }

        }
    }
}
