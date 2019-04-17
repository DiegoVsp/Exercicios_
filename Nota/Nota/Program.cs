using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Nota
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoNotas a1 = new AlunoNotas();

            Console.WriteLine("Nome do Aluno: ");
            a1.nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno " + a1.nome);
            a1.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota Final = " + a1.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (a1.Aprovado())
            {
                Console.WriteLine("APROVADO!");
            }
            else
            {
                Console.WriteLine("REPROVADO!");
                Console.WriteLine("FALTARAM: " + a1.NotaRestante().ToString("F2",CultureInfo.InvariantCulture)+" PONTOS");
            }

            Console.ReadKey();

        }
    }
}
