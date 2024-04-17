using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teoria_de_DLL__biblioteca_
{
    public class Pessoa
    {
        protected string rg;
        protected string nome;
        protected string email;
        protected string telefone;


        public void cadastrar()
        {
            Console.WriteLine("Digite seu nome:\n");
            this.nome = Console.ReadLine();
            Console.WriteLine("Digite seu email:\n");
            this.email = Console.ReadLine();
            Console.WriteLine("Digite seu telefone:\n");
            this.telefone = Console.ReadLine();
            Console.WriteLine("Digite o seu rg:\n");
            this.rg = Console.ReadLine();
        }


        public void exibir()
        {
            Console.WriteLine("Nome:{0}\n Email:{1}\n Telefone:{2}\n RG:{3}\n ", this.nome, this.email, this.telefone, this.rg);
        }
    }

    


}
