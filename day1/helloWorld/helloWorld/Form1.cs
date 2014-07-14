using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idadePessoa1 = 29;
            int idadePessoa2 = 30;
            int idadePessoa3 = 4;
            double soma = idadePessoa1 + idadePessoa2 + idadePessoa3;
            double media = soma / 3;
            MessageBox.Show("Media de idade: " + media);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;
            MessageBox.Show("Pi Quebrado" + piQuebrado);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = 2;
            double b = 6;
            double c = 2;
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                MessageBox.Show("Delta negativo");
                Environment.Exit(0);
            }
            else 
                { 
                double a1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double a2 = (-b - Math.Sqrt(delta)) / (2 * a);
                MessageBox.Show("Primeira Raiz: " + a1 + " Segunda Raiz: " + a2);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valorSaque = 10.0;
            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque realizado com Sucesso");
            }
            else
            { 
                MessageBox.Show("Saldo Insuficiente");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double saldo = 500.0;

            if (saldo < 0.0)
            {
                MessageBox.Show("Voce esta no negativo");
            }

        else if (saldo < 1000000.0)
            {
                MessageBox.Show("Voce e um bom cliente");
            }   
       else
            {
                MessageBox.Show("Voce e milionaro");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int idade = 18;
            bool brasileira = true;
            bool maior = idade >= 16;

            if (maior && brasileira)
            {
                MessageBox.Show("Apta a Votar");
            }
            else
            {
                MessageBox.Show("Nao Esta apta a votar");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            double valorDaNotaFiscal = 7867.0;
            double imposto;
            if (valorDaNotaFiscal < 999)
            {
                 imposto = valorDaNotaFiscal * 0.02;
            }
            else if ( valorDaNotaFiscal >= 1000 && valorDaNotaFiscal <= 2999)
            {
                 imposto = valorDaNotaFiscal * 0.025;
            }
            else if ( valorDaNotaFiscal >= 3000 && valorDaNotaFiscal <= 6999)
            {
                 imposto = valorDaNotaFiscal * 0.028;
            }
            else
            {
                 imposto = valorDaNotaFiscal * 0.03;
            }
            MessageBox.Show("Imposto: " + imposto);
        }
    }
}
