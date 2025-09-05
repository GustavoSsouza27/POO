using System;
using System.Security.Cryptography.X509Certificates;

namespace _01_DeclaracaoClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado obj1 = new Quadrado();
            obj1.Lado = 5;
            obj1.ImprimeArea();

            obj1.Lado = 15;
            obj1.ImprimeArea();

            Quadrado obj2 = new Quadrado();
            obj2.Lado = 25;
            obj2.ImprimeArea();

            Retangulo obj3 = new Retangulo();
            obj3.Largura = 15;
            obj3.Altura = 5;
            obj3.ImprimeArea();

            Circulo obj4 = new Circulo();
            obj4.Raio = 7.5;
            obj4.ImprimeArea();

            Triangulo obj5 = new Triangulo();
            obj5.Altura = 25.5;
            obj5.Base = 12.75;
            obj5.ImprimeArea();

            conta contaGustavo = new conta();
            contaGustavo.banco = 237;
            contaGustavo.agencia = "002-7";
            contaGustavo.numero = "99520-7";
            contaGustavo.saldo = 0.00;
            contaGustavo.limite = 500.00;

            contaGustavo.Depositar(1050.00);
            Console.WriteLine($"Saldo Atual: {contaGustavo.ConsultaSaldo()}");

            contaGustavo.sacar(200.00);
            Console.WriteLine($"Saldo atual: {contaGustavo.ConsultaSaldo()}");
        }
    }

    public class Quadrado
    {
        public int Lado;

        public int CalculaArea()
        {
            int area = Lado * Lado;
            return area;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($"Quadrado com lado de {Lado} possui uma área de {CalculaArea()}");
        }
    }

    public class Retangulo
    {
        public int Largura, Altura;

        public int CalculaArea()
        {
            return Largura * Altura;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($"Retângulo com largura de {Largura}, altura de {Altura} possui uma área de {CalculaArea()}");
        }
    }

    public class Circulo
    {
        public double Raio;

        public double CalculaArea()
        {
            return Math.Pow(Raio, 2) * Math.PI;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($"Círculo com raio de {Raio:N2} possui uma área de {CalculaArea():N2}");
        }
    }

    public class Triangulo
    {
        public double Base, Altura;

        public double CalculaArea()
        {
            return Base * Altura / 2;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($"Triângulo com base de {Base:N2}, altura de {Altura:N2} possui uma área de {CalculaArea():N2}");
        }
    }

    // Classe conta deve estar fora de Triangulo
    public class conta
    {
        public int banco;
        public string agencia;
        public string numero;
        public double saldo;
        public double limite;

        public void Depositar(double valor)
        {
            saldo = saldo + valor;
        }

        public void sacar(double valor)
        {
            if (saldo >= valor)
            {
                saldo = saldo - valor;
            }
            // Fechando o método sacar corretamente
        }




        public double ConsultaSaldo()
        {
            return saldo;
        }

        public class aluno
        {
            public int codigo;
            public string nome;
            public double[] notas = new double[4];

            public void LancaNota(int trimestre, double nota)
            {
                notas[trimestre - 1] = nota;  // corrigido o "=" aqui
            }

            public double CalculaMedia()
            {
                double media = 0;
                foreach (double nota in notas)
                {
                    media += nota;
                }
                return media / 4.0;
            }  // fechando CalculaMedia aqui

            public string mencao()
            {
                if (CalculaMedia() >= 5.0)
                    return "aprovado";
                else
                    return "reprovado";
            }
        }
    }
}