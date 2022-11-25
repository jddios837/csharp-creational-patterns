using System;

namespace FactoryMethod_02
{
    public class Goomba : IEnemy
    {
        private const string name = "Goomba";
        
        public string Nombre()
        {
            Random randomName = new Random();
            return name + " " + randomName.Next(100, 1000);
        }
        public string Ataque()
        {
            return "Mordisco de Colmillo";
        }
    }
}