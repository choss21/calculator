namespace MathLib
{
    public class RestaOperacion : OperacionAritmetica
    {
        public override void RealizarOperacion()
        {
            Resultado = Numero1 - Numero2;
        }
    }
}
