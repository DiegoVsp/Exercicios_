using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace ExercicioRetangulo
{
    class Retangulo
    {
        private double largura;
        private double altura;

        public double Largura { get => largura; set => largura = value; }
        public double Altura { get => altura; set => altura = value; }

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }
        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }
}
