namespace MathLib
{
    public class DivicionOperacion : OperacionAritmetica
    {
        public override void RealizarOperacion()
        {
            Resultado = Numero1 / Numero2;
        }
    }
}
