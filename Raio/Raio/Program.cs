using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Raio
{
    class Program
    {
        

        static void Main(string[] args)
        {
            

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = calculadora.Circunferencia(raio);
            double volume = calculadora.Volume(raio);

            Console.WriteLine("Cirunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + calculadora.PI.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
        

    }
}
