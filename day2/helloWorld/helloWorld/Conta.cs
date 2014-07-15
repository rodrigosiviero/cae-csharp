using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    class Conta
    {
        public double Saldo { get; private set; }
        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        public int Agencia {get; set;}

        public Conta(int numero, Cliente titular)
        {
            this.Numero = numero;
            this.Titular = titular;
        }

        public Conta(int Numero, Cliente Titular, int Agencia):this(Numero,Titular)
        {
            this.Agencia = Agencia;
        }
        public bool Saca(double valor)
        {
            if (Titular.EhMaiorDeIdade()) 
            {
                if (this.Saldo >= valor && valor > 0)
                {
                    this.Saldo -= valor;
                    return true;
                }
            }
            else if (valor <= 200 && valor > 0 )
            {
                this.Saldo -= valor;
                return true;
            }
            return false;
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
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
