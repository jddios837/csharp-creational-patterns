using System;

namespace FactoryMethod_02
{
    public class Koopa : IEnemy
    {
        private const string name = "Koopa";
        
        public string Nombre()
        {
            Random randomName = new Random();
            return name + " " + randomName.Next(100, 1000);
        }
        public string Ataque()
        {
            return "Golpe de Caparazon";
        }
    }
}