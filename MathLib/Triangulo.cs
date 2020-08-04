namespace MathLib
{
    public class Triangulo : FiguraGeometrica
    {
        public override string TipoFigura => "Triangulo";

        public override int NumeroLados => 3;
        public double Base { get; set; }
        public double Altura { get; set; }
        public Triangulo(double vbase, double altura, string color = "Blanco")
        {
            this.Base = vbase;
            this.Altura = altura;
            this.Color = color;
        }
        public override double CalcularArea()
        {
            return Base * Altura / 2;
        }
    }
}
