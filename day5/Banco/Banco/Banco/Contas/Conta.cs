using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco.Contas
{
    public abstract class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }
        private static int numeroDeContas;

        //CTOR 
        public Conta()
        {
            Conta.numeroDeContas++;
            this.Numero = Conta.numeroDeContas;
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

        public static int ProximoNumero()
        {
            return Conta.numeroDeContas+1;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return "Titular: " + this.Titular.Nome;
        }
    }
}