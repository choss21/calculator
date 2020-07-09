namespace MathLib
{
    public class Rectangulo : FiguraGeometrica
    {
        public override string TipoFigura => "Rectangulo";

        public override int NumeroLados => 4;
        public double Base { get; set; }
        public double Altura { get; set; }
        public Rectangulo(double vbase, double altura, string color = "Blanco")
        {
            this.Base = vbase;
            this.Altura = altura;
            this.Color = color;
        }
        public override double CalcularArea()
        {
            return Base * Altura;
        }
    }
}
