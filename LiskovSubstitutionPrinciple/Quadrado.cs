using System;
namespace Solid.LiskovSubstitutionPrinciple
{
    public class Retangulo
    {
        public virtual double Altura { get; set; }
        public virtual double Comprimento { get; set; }
        public double Area { get { return Altura * Comprimento; } }
    }

    public class Quadrado : Retangulo
    {
        public override double Altura
        {
            set { base.Altura = base.Comprimento = value; }
        }

        public override double Comprimento
        {
            set { base.Altura = base.Comprimento = value; }
        }
    }

    public class Calcular
    {
        public void RealizarCalculo(Retangulo retangulo)
        {
            retangulo.Altura = retangulo.Altura * 2;
            retangulo.Comprimento = retangulo.Comprimento * 4;
        }
    }
}
