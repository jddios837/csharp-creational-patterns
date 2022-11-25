using System;

namespace FactoryMethod_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Game");

            RandomEnemyFactory factory = new RandomEnemyFactory();
            var enemy1 = factory.CreateEnemy();
            Console.WriteLine("El enemigo {0} ataca con {1}", enemy1.Nombre(), enemy1.Ataque());
            var enemy2 = factory.CreateEnemy();
            Console.WriteLine("El enemigo {0} ataca con {1}", enemy2.Nombre(), enemy2.Ataque());
            var enemy3 = factory.CreateEnemy();
            Console.WriteLine("El enemigo {0} ataca con {1}", enemy3.Nombre(), enemy3.Ataque());
        }
    }
}