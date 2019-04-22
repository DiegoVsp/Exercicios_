using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CotaDollar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do Dollar? ");
            double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Quantos Dollars você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = Cotar.Calcular(quantia, cotacao);

            Console.WriteLine("Valor a ser pago em reais: " + resultado.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
