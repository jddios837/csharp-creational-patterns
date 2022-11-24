using System;

namespace FactoryMethod_01
{
    class Program
    {
        static void Main(string[] args)
        {
            BebidaEnbriagante oBebida = Creador.CreadorBebida(Creador.CERVEZA);
            Console.WriteLine(oBebida.CuantoMeEnbriagoPorHora());
        }
    }
}