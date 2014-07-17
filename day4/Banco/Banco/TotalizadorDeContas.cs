using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco
{
    class TotalizadorDeContas
    {
        public double SaldoTotal { get; set; }

        public void Adiciona(Conta conta)
        {
            this.SaldoTotal += conta.Saldo;
        }
    }
}
