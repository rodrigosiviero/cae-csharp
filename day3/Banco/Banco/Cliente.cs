using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco
{
    public class Cliente
    {
        private string p;
        public string Nome { get; set; }

        public Cliente(string p)
        {
            // TODO: Complete member initialization
            this.Nome = p;
        }        
    }
}
