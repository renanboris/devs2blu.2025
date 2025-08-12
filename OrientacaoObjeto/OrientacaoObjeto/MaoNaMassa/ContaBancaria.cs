using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto.MaoNaMassa
{
    public class ContaBancaria
    {
        public const decimal TARIFA_VIGENTE = 1.5m;
        public static decimal SaldoTotal { get; private set; } = 0;        
        public static int QtdContasCadastradas { get; private set; } = 0;
        public string Titular { get; set; }
        public decimal Saldo { get; set; }

        public bool EmprestimosAtivos { get; set; }

        public ContaBancaria(string titular)
        {
            Titular = titular;
            QtdContasCadastradas++;
        }

        public ContaBancaria(string titular, decimal saldo)
        {
            Titular = titular;
            Saldo = saldo;
            SaldoTotal += saldo;
            QtdContasCadastradas++;
        }

        public decimal Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor incorreto. Verifique e tente novamente...");
                return 0;
            }
            else
            {
                SaldoTotal += valor;
                return Saldo += valor;
            }
            
        }

        public decimal Sacar(decimal valor)
        {
            if (valor <= 0 || valor > Saldo)
            {
                Console.WriteLine("Valor incorreto ou Saldo Insuficiente. Verifique e tente novamente...");
                return 0;
            }
            else
            {
                SaldoTotal -= valor;
                return Saldo -= valor;                
            }
        }

        public decimal Emprestimo(decimal valorEmprestimo, decimal renda, int parcelas)
        {

            decimal valorParcela = valorEmprestimo / parcelas;
            decimal calculoPorcentagem = renda * 0.3m; //30%

            if ((valorEmprestimo * 5) < SaldoTotal)
            {
                if (valorParcela <= calculoPorcentagem)
                {
                    Console.WriteLine("Empréstimo efetuado com sucesso! Já está na conta :)");
                    EmprestimosAtivos = true;
                    SaldoTotal += valorEmprestimo;
                    return Saldo += valorEmprestimo;
                }
                else
                {
                    Console.WriteLine("Parcelas mensais não compatível com a Renda");
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("Não será possível o empréstimo deste valor.");
                return 0;
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"{Titular}, seu saldo atual é de R${Saldo:F2}");
        }
    }


}
