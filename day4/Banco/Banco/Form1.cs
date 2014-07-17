using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private Conta[] contas;
        private int numeroContas;
        private Conta selecionada;
        private Conta selecionadaDestino;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //this.conta = new ContaCorrente();
            //this.conta.Numero = 1;
            //Cliente Joao = new Cliente("Joao");
            //this.conta.Titular = Joao;
            //TextoTitular.Text = conta.Titular.Nome;
            //TextoNumero.Text = Convert.ToString(conta.Numero);
            //TextoSaldo.Text = Convert.ToString(conta.Saldo);

            this.contas = new Conta[10];

            //this.contas[0] = new Conta();
            //this.contas[0].Titular = new Cliente("Victor");
            //this.contas[0].Numero = 1;
            //this.numeroContas++;

            //this.contas[1] = new ContaPoupanca();
            //this.contas[1].Titular = new Cliente("Mauricio");
            //this.contas[1].Numero = 2;
            //this.numeroContas++;

            //this.contas[2] = new ContaCorrente();
            //this.contas[2].Titular = new Cliente("Osni");
            //this.contas[2].Numero = 3;
            //this.numeroContas++;

            Conta c1 = new ContaCorrente();
            c1.Titular = new Cliente("Victor");
            c1.Numero = 1;
            this.Adiciona(c1);

            Conta c2 = new ContaCorrente();
            c2.Titular = new Cliente("Mauricio");
            c2.Numero = 2;
            this.Adiciona(c2);

            Conta c3 = new ContaCorrente();
            c3.Titular = new Cliente("Osni");
            c3.Numero = 3;
            this.Adiciona(c3);

            //foreach (Conta conta in this.contas)
            //{
            //    ComboContas.Items.Add(conta.Titular.Nome);
            //}

            //foreach (Conta contasTransf in this.contas)
            //{
            //    comboTransferencia.Items.Add(contasTransf.Titular.Nome);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorDeposito = Convert.ToDouble(TextoValor.Text);
            int indice = Convert.ToInt32(ComboContas.SelectedIndex);
            Conta selecionada = this.contas[indice];

            try
            {
                selecionada.Deposita(valorDeposito);
                MessageBox.Show("Depositado com Sucesso");
                TextoSaldo.Text = Convert.ToString(selecionada.Saldo);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Argumento Invalido");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double valorSaque = Convert.ToDouble(TextoSaque.Text);
            int indice = Convert.ToInt32(ComboContas.SelectedIndex);
            Conta selecionada = this.contas[indice];

            try
            {
                selecionada.Saca(valorSaque);
                MessageBox.Show("Saque feito com Sucesso");
                TextoSaldo.Text = Convert.ToString(selecionada.Saldo);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Argumento Invalido");
            }
            catch (SaldoInsuficienteException ex)
            {
                MessageBox.Show("Saldo Insuficiente");
            }
            finally
            {
                MessageBox.Show("Obrigado!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TextoValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextoSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ContaCorrente cc = new ContaCorrente();
            cc.Deposita(500);
            ContaPoupanca cp = new ContaPoupanca();
            cp.Deposita(500);
            TotalizadorDeContas tdc = new TotalizadorDeContas();
            tdc.Adiciona(cc);
            tdc.Adiciona(cp);
            TextoSaldoTotal.Text = Convert.ToString(tdc.SaldoTotal);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Old New Account method. code belo replaced by function button4_Click_1
            //int indice = Convert.ToInt32(TextoIndice.Text);
            //Conta selecionada = this.contas[indice];
            //TextoNumero.Text = Convert.ToString(selecionada.Numero);
            //TextoTitular.Text = selecionada.Titular.Nome;
            //TextoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void ComboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = ComboContas.SelectedIndex;
            this.selecionada = contas[indice];
            TextoTitular.Text = selecionada.Titular.Nome;
            TextoNumero.Text = Convert.ToString(selecionada.Numero);
            TextoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboTransferencia.SelectedIndex;
            this.selecionadaDestino = contas[indice];
            TextoTransfTitular.Text = selecionadaDestino.Titular.Nome;
            TextoTransfNumero.Text = Convert.ToString(selecionadaDestino.Numero);
        }

        private void TextoSaque_TextChanged(object sender, EventArgs e)
        {

        }

        private void Transferencia_Click(object sender, EventArgs e)
        {
            if (selecionada.Transferencia(selecionadaDestino, Convert.ToDouble(TextoTransferencia.Text)))
            {
                MessageBox.Show("Transferencia realizada com Sucesso");
                TextoSaldoTransferencia.Text = Convert.ToString(selecionadaDestino.Saldo);
            }
            else
            {
                MessageBox.Show("Transferencia nao realizada");
            }

        }

        public void Adiciona(Conta conta)
        {
            this.contas[this.numeroContas] = conta;
            this.numeroContas++;
            ComboContas.Items.Add(conta.Titular.Nome);
            comboTransferencia.Items.Add(conta.Titular.Nome);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            FormCadastraConta form = new FormCadastraConta(this);
            form.ShowDialog();
        }

        private void botaoImpostos_Click(object sender, EventArgs e)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Deposita(200.0);

            //SeguroDeVida vd = new SeguroDeVida();
            //TotalizadorDeTributos tdc = new TotalizadorDeTributos();
            //tdc.Adiciona(conta);
            //MessageBox.Show("Total = " + tdc.Total);
            //tdc.Adiciona(vd);
            //MessageBox.Show("Total = " + tdc.Total);

            foreach (Conta contas in this.contas)
            {
                if (contas is ITributavel)
                {
                    ITributavel t = (ITributavel)contas;
                    TotalizadorDeTributos tdc = new TotalizadorDeTributos();
                    double tributos = t.CalculaTributavel();
                    MessageBox.Show("Total da conta = " + contas.Numero + "é igual: " + tributos);
                }
            }
        }
    }
}
