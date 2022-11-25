using System;

namespace FactoryMethod_02
{
    public class Boo : IEnemy
    {
        private const string name = "Boo";
        
        public string Nombre()
        {
            Random randomName = new Random();
            return name + " " + randomName.Next(100, 1000);
        }

        public string Ataque()
        {
            return "Asustar";
        }
    }
}