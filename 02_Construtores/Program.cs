using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado();
            quadrado.ImprimirArea();

            Quadrado quadrado1 = new Quadrado(10);
            quadrado1.ImprimirArea();

            Retangulo obj3 = new Retangulo(15, 5);
            obj3.ImprimeArea();

            Circulo obj4 = new Circulo(7.5);
            obj4.ImprimeArea();

            Triangulo obj5 = new Triangulo(12.75, 25.5);
            obj5.ImprimeArea();
        }

    }

    public class Quadrado
    {
        //Modificar de acesso Private
        //pode ser acessado apenas dentro da Classe
        private int Lado;

        //Overload (Sobrecarga) de Construtor
        //Declarar mais de um construtor com a lista de argumentos diferentes
        //this(5) aciona o construtor que recebe um parâmetro
        public Quadrado(): this(5)
        {
            //this.Lado = 5;
        }

        //O Construtor serve para instanciar o objeto e
        //Inicializar os atributos
        public Quadrado(int Lado)
        {
            //this: acessa o membro da classe
            if(Lado > 0 )
            this.Lado = Lado;
        }

        public int CalculaArea()
        {
            return Lado * Lado;
        }

        public void ImprimirArea()
        {
            Console.WriteLine($"Quadrado com lado de {Lado} possui uma área de {CalculaArea()}");
        }
    }

    public class Retangulo
    {
        private int Largura, Altura;

        public Retangulo(int Largura, int Altura)
        {
            this.Largura = Largura;
            this.Altura = Altura;
        }
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
        private double Raio;

        public Circulo(double Raio)
        {
            this.Raio = Raio;
        }

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
        private double Base, Altura;

        public Triangulo(double Base, double Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }

        public double CalculaArea()
        {
            return Base * Altura / 2;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($"Triângulo com base de {Base:N2}, altura de {Altura:N2} possui uma área de {CalculaArea():N2}");

        }
    }
}