using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco
{
    class ContaCorrente : Conta
    {
        public override bool Saca(double valorSaque)
        {
            return base.Saca(valorSaque + 0.05);
        }

        public override bool Deposita(double valorDeposito)
        {
            return base.Deposita(valorDeposito - 0.10);
        }
    }
}
