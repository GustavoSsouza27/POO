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
            
        }

        
    }

    public class Quadrado
    {
        //Modificador de acesso Private
        //pode ser acessado apenas dentro da Classe 
        private int Lado;

        public int CalcualaArea()

        public Quadrado(int lado)
        {
            Lado = lado;
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
}
