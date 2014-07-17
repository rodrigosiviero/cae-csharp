using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco
{
    public abstract class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }

        //CTOR 
        public Conta()
        {

        }

        public abstract void Deposita(double valorDeposito);

        public abstract void Saca(double valorSaque);

        public bool Transferencia(Conta destino, double valor)
        {
            if (this.Saldo >= valor && this.Numero != destino.Numero)
            {
                Saca(this.Saldo);
                destino.Deposita(valor);
                return true;
            }
            return false;
        }
    }
}
