using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Banco.Contas;

namespace Banco
{
    class ContaCorrente : Conta, ITributavel
    {
        public override void Saca(double valorSaque)
        {
            if (valorSaque < 0.0)
            {
                throw new ArgumentException();
            }
            else if (valorSaque > this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                this.Saldo -= valorSaque + 0.05;
                //return true;
            }
        }

        public override void Deposita(double valorDeposito)
        {
            if (valorDeposito < 0)
            {
                throw new ArgumentException();
            }
            this.Saldo += valorDeposito - 0.10;
            //return true;
        }

        public double CalculaTributavel()
        {
            return this.Saldo * 0.05;
        }
    }
}
