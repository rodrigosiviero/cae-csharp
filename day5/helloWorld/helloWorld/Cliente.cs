using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    class Cliente
    {
        public string Nome { get; set; }
        public int cpf;
        public string endereco;
        public string rg;
        public int idade;

        public Cliente() {}

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public bool EhMaiorDeIdade()
        {
            if (this.idade >= 18)
            {
                return true;
            }
            return false;
        }
    }
}
