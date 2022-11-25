using System;

namespace FactoryMethod_02
{
    public class RandomEnemyFactory : EnemyFactory
    {
        public override IEnemy CreateEnemy()
        {
            IEnemy enemy;
            Random randomEnemy = new Random();
            switch (randomEnemy.Next(1,3))
            {
                case 1:
                    enemy = new Boo();
                    break;
                case 2:
                    enemy = new Goomba();
                    break;
                case 3:
                    enemy = new Koopa();
                    break;
                default:
                    enemy = null;
                    break;
            }

            return enemy;
        }
    }
}