using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    class Conta
    {
        public double saldo;
        public int numero;
        public string titular;

        public bool Saca(double valor)
        {
            if(this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            return false;
        }

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public bool Transfere(Conta destino, double valor)
        {
            if (this.Saca(valor))
            {
                destino.Deposita(valor);
                return true;
            }
            return false;
        }
    }
}
