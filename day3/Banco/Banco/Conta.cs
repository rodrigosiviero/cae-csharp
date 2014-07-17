using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }
        public string TipoConta { get; set; }

        //CTOR 
        public Conta()
        {

        }

        public virtual bool Deposita(double valorDeposito)
        {
            if (valorDeposito < 0 && valorDeposito != null)
            {
                return false;
            }
            this.Saldo += valorDeposito;
            return true;
        }

        public virtual bool Saca(double valorSaque)
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

        public bool Transferencia(Conta destino, double valor)
        {
            if (this.Saldo >= valor && this.Numero != destino.Numero)
            {
                if (Saca(this.Saldo))
                {
                    destino.Deposita(valor);
                    return true;
                }
            }
            return false;
        }
    }
}
