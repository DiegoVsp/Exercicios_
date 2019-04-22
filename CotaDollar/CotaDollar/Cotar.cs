using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotaDollar
{
    class Cotar
    {
        public static double iof = 6.00;

        public static double Calcular(double quantia, double cotacao)
        {

            double total = quantia * cotacao;
            return total + total * iof / 100;
             
        }
    }
}
