using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBanco
{
    public class Operacoes
    {
        public Operacoes(int numeroConta, string nomeConta)
        {
            NumeroConta = numeroConta;
            NomeConta = nomeConta;
            Saldo = 0.0;
        }

        public Operacoes(int numeroConta, string nomeConta, double depositoInicial) : this(numeroConta, nomeConta)//Reaproveita o anterior
        {
            Deposito(depositoInicial); // Dessa forma acomapanha as mudanças da função
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.00;
        }

        public override string ToString()
        {
            return "Conta: " + NumeroConta 
                + ", Titular: " 
                + NomeConta + ", Saldo: $ " 
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

        [Required]
        [StringLength(6, ErrorMessage = "Esse campo precisa ser preenchido", MinimumLength = 3)]
        public int NumeroConta { get; private set; }

        [Required]
        [StringLength(100, ErrorMessage = "Esse campo precisa ser preenchido", MinimumLength = 2)]
        public string NomeConta { get; set;}

        public double Saldo { get; private set; }

        
    }
}
