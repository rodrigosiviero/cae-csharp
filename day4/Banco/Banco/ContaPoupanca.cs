﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaPoupanca : Conta
    {
        public override bool Saca(double valorSaque)
        {
            if (valorSaque > this.Saldo && valorSaque != null)
            {
                return false;
            }
            else
            {
                this.Saldo -= valorSaque + 0.10;
                return true;
            }
        }

        public override bool Deposita(double valorDeposito)
        {
            if (valorDeposito < 0 && valorDeposito != null)
            {
                return false;
            }
            this.Saldo += valorDeposito;
            return true;
        }
    }
}
