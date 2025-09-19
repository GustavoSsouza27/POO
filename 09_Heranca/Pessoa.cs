using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _09_Heranca
{

   
    internal abstract class Pessoa
    {
        public int Id {  get; set; }
        public string Nome;
        public string Telefone;

        public abstract string GetDocumento();

        public void Imprimir()
        {
            Console.WriteLine($"LISTA DE PESSOAS\n\nNome: {this.Nome} Documento: {this.GetDocumento()} Telefone: {this.Telefone}");
        }
        public override string ToString() 
        {
            return $"<Tostring()> Nome: {{this.Nome}} Documento: {{this.GetDocumento()}} Telefone: {{this.Telefone}}\"";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;


            //cast=> COnversão de objeto
            //(pessoa)obj)=> Converte obj que é tipo object para tipo Pessoa
            return this.Id == ((Pessoa)obj).Id; 
        }

        public override int GetHashCode()
        {
            return this. Id.GetHashCode();
        }
    }
    
}