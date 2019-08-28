using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercícioBanco
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public Conta(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.00;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public override string ToString()
        {
            return " Conta nº: " + Numero +
                    ", Titular: " + Titular +
                    ", Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
