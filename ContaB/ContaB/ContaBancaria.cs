using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ContaB
{
    class ContaBancaria
    {
        private int Numero;
        private string Titular;
        private double Saldo;

        public int Numero1 { get => Numero; private set => Numero = value; }
        public string Titular1 { get => Titular; set => Titular = value; }
        public double Saldo1 { get => Saldo; private set => Saldo = value; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;

        }
        public ContaBancaria(int numero, string titular, double depositoInicial):this(numero,titular)
        {
            Deposito(depositoInicial);
        }
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5.0; // Taxa de Saque
        }

        public override string ToString()
        {
            return "Conta: " 
                + Numero 
                + ", Titular: " 
                + Titular 
                + ", Saldo: $" 
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
