using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1_POO2
{
    internal class Exercicio4
    {
    }

    public abstract class Figura
    {
        public abstract string Cor { get; set; }
        public abstract double Area();
    }

    public class Retangulo : Figura
    {
        public double lado1 { get; set; }
        public double lado2 { get; set; }
        public string cor;

        public override string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public override double Area()
        {
            return lado1 * lado2;
        }
    }

    public class Triangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public string cor;

        public override string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public override double Area()
        {
            return Base * Altura;
        }
    }

    public static class Teste
    {
        public static string DetalhesFigura(Figura figura)
        {
            return $"Cor da figura: {figura.Cor} - Área da figura: {figura.Area()}";
        }
    }
}
