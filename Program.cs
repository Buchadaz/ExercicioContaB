using ContaBanco;
using System;
using System.Globalization;

namespace Course;

class Program
{
    static void Main(string[] args)
    {
        Operacoes operacoes;
        Console.Write("Entre com o número da conta: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write("Entre com o nome do titular do conta: ");
        string nome = Console.ReadLine();
        Console.Write("Haverá depósito inicial(s/n) ? ");
        char resp = char.Parse(Console.ReadLine());
        if (resp == 's' || resp == 'S')
        {
            Console.Write("Digite o valor do deposito inicial: ");
            double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            operacoes = new Operacoes(numero, nome, depositoInicial);

        }
        else { 
            operacoes = new Operacoes(numero, nome); 
        }
        Console.WriteLine();
        Console.WriteLine("Dados da conta:");
        Console.WriteLine(operacoes);
        Console.WriteLine();
        Console.Write("Informe o valor de deposito: ");
        double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        operacoes.Deposito(quantia);
        Console.WriteLine("Dados da conta atualizados: ");
        Console.WriteLine(operacoes);
        Console.WriteLine();
        Console.Write("Informe o valor de saque: ");
        quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        operacoes.Saque(quantia);
        Console.WriteLine("Dados da conta atualizados: ");
        Console.WriteLine(operacoes);


    }
}