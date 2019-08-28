using System;
using System.Globalization;

namespace ExercícioBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Banco Rodrigo - Desenvolvido em C# com Orientação a Objeto");

            Conta c;

            Console.Write("\n" + "Informe o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("\n" + "Informe o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("\n" + "Haverá depósito inicial (S/N)? ");
            string resp = Console.ReadLine();
            Console.WriteLine();
            if (resp == "S" || resp == "s")
            {
                Console.Write("\n" + "Informe o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(numero, titular, depositoInicial);
            }
            else
            {
                c = new Conta(numero, titular);
            }
            Console.WriteLine();
            
            Console.WriteLine("Dados da Conta: " + "\n" + c);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine();

            Console.Write("Qual operação deseja realizar (Depósito / Saque / Saldo / Sair)? ");
            string resp1 = Console.ReadLine();
            Console.WriteLine();

            while (resp1 == "Depósito" || resp1 == "Saque"|| resp1 == "Saldo")
            {
                if (resp1 == "Depósito")
                {
                    Console.Write("Entre com um valor para Depósito: ");
                    double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    c.Deposito(valor);
                    Console.WriteLine();
                    Console.WriteLine("Transação realizada com Sucesso!" + "\n" + "Dados da conta Atualizados: " + c);
                    Console.WriteLine();
                    Console.WriteLine();
                }

                else if (resp1 == "Saque")
                {
                    Console.Write("Entre com um valor para Saque: ");
                    double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    c.Saque(quantia);
                    Console.WriteLine();
                    Console.WriteLine("Transação realizada com Sucesso!" + "\n" + "Dados da conta Atualizados: " + c);
                    Console.WriteLine();
                    Console.WriteLine();
                    
                }

                else if(resp1 == "Saldo")
                {
                    Console.WriteLine();
                    Console.WriteLine("Seu saldo atual é de: R$ " + c.Saldo.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine();
                    Console.WriteLine();

                }
                Console.Write("Qual operação deseja realizar (Depósito / Saque / Saldo / Sair)? ");
                resp1 = Console.ReadLine();
                Console.WriteLine();
            }
        }
    }
}
