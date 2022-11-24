namespace FactoryMethod_01
{
    public class VinoTinto : BebidaEnbriagante
    {
        public override int CuantoMeEnbriagoPorHora()
        {
            return 20;
        }
    }
}