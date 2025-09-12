using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04PropriedadesAtenet8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conta conta = new Conta();
            Conta conta = new Conta("999-88");
            conta.nome = "Gustavo Santos de Souza";//
            //conta.nome = "Gustavo Santos de Souza";

            //Não é possivel atribuir p valor em um atributo privado 
            //conta.numero = "999-88";


            conta.Depositar(-1000.00m);
            // utilizando o metodo acessador
            conta.Saldo = 1000.00m;
            // Console.WriteLine($"Saldo atual : {conta.getSaldo():c2}");
            conta.ImprimirSaldo();

            while (true)
            {
                Console.WriteLine("Informe a operação: [D]-Depositar, [S]-Sacar ou [E]-Sair");
                string operacao = Console.ReadLine();

                if (operacao.ToUpper() == "D")
                {
                    Console.WriteLine("Informe o valor para depositar");
                    decimal valorDeposito = decimal.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito);
                    conta.ImprimirSaldo();
                }
                else if (operacao.ToUpper() == "S")
                {
                    Console.WriteLine("Informe o valor para saque");
                    decimal valorSaque = decimal.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque);
                    conta.ImprimirSaldo();
                }
                else if (operacao.ToUpper() == "E")
                {
                    // Corrigido fechamento de chaves e parênteses
                    Console.WriteLine($"Conta {conta.Numero} Nome: {conta.nome} Saldo: {conta.Saldo:c2}");
                    break;
                }
                else
                {
                    Console.WriteLine("Informe apenas as letras [D] para Depositar, [S] para Sacar ou [E] para Sair");
                }
            }
        }

        public class Conta
        {
            private string numero;
            public string Numero { get; }
          

            public string nome;

            public Conta(string numero)
            {
                this.numero = numero;
            }
            private decimal saldo;

            //declaraçao da propriedade até a versão 8 do .NET
            public decimal Saldo
            {
                get { return saldo; }
                set
                {
                    this.Depositar(value);
                }
            }

            // métodos acessadores
            //public decimal getSaldo() 
            //{
            //    return saldo;
            //}

            //public void setSaldo(decimal saldo)
            //{
            //    this.Depositar(saldo);
            //}
            //public string getNumero()
            //{
            //    return numero;
            //}

            //public string getNome()//

            //{
            //    return nome;
            //}

            //public void setNome(string nome)
            //{
            //    this.nome = nome;//
            //}

            public void Depositar(decimal valor)
            {
                if (valor > 0)
                    saldo += valor;
                else
                    Console.WriteLine("Valor de deposito incorreto, deve ser maior que zero!");
            }

            public void Sacar(decimal valor)
            {
                saldo -= valor;
            }

            public void ImprimirSaldo()
            {
                Console.WriteLine($"Saldo atual: {saldo:c2}");
            }
        }
    }
}
