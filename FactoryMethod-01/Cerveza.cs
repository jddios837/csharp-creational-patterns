namespace FactoryMethod_01
{
    public class Cerveza : BebidaEnbriagante
    {
        public override int CuantoMeEnbriagoPorHora()
        {
            return 5;
        }
    }
}