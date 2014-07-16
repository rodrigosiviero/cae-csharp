using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco
{
    class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        //CTOR 
        public Conta()
        {

        }

        public bool Deposita(double valorDeposito)
        {
            if (valorDeposito < 0 && valorDeposito != null)
            {
                return false;
            }
            this.Saldo += valorDeposito;
            return true;
        }

        public bool Saca(double valorSaque)
        {
            if (valorSaque > this.Saldo && valorSaque != null)
            {
                return false;
            }
            else
            {
                this.Saldo -= valorSaque;
                return true;
            }
        }

        public bool Transfere(Conta destino, double valor)
        {
            if (this.Saldo >= valor)
            {
                this.Saca(valor);
                destino.Deposita(valor);
                return true;
            }
            return false;
        }
    }
}
