using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r1 = new Retangulo();
            Console.WriteLine("Entre com a Largura  e Altura do Retângulo: ");
            r1.Largura = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            r1.Altura = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            Console.WriteLine("AREA = " + r1.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + r1.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + r1.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
