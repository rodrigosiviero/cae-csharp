using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Contas;
using Banco.Busca;


namespace Banco
{
    public partial class FormCadastraConta : Form
    {
        private int selecionada;
        private Form1 FormPrincipal;
        private Conta c;
        private ICollection<string> devedores;

        public FormCadastraConta()
        {
            InitializeComponent();
        }

        public FormCadastraConta(Form1 formPrincipal)
        {
            this.FormPrincipal = formPrincipal;
            InitializeComponent();
            this.ComboTipo.Items.Add("Conta Corrente");
            this.ComboTipo.Items.Add("Conta Poupanca");
            TextoProxNumero.Text = Convert.ToString(Conta.ProximoNumero());

            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.GeraList();

        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            String nomeTitular = TextoTitular.Text;
            //int numero = Convert.ToInt32(TextoNumero.Text);
            //bool ehDevedor = this.devedores.Contains(nomeTitular);
            bool ehDevedor = false;
            for (int i = 0; i < 3000; i++)
            {
                ehDevedor = this.devedores.Contains(nomeTitular);
                if (!ehDevedor)
                {
                    if (this.selecionada == 0)
                    {
                        c = new ContaCorrente();
                    }
                    else
                    {
                        c = new ContaPoupanca();
                    }
                    c.Titular = new Cliente(nomeTitular);
                    this.FormPrincipal.Adiciona(c);
                    TextoProxNumero.Text = Convert.ToString(Conta.ProximoNumero());
                }
                else
                {
                    MessageBox.Show("Devedor");
                }
            }
            //if (!ehDevedor)
            //{
            //    if (this.selecionada == 0)
            //    {
            //        c = new ContaCorrente();
            //    }
            //    else
            //    {
            //        c = new ContaPoupanca();
            //    }
            //    c.Titular = new Cliente(nomeTitular);
            //    this.FormPrincipal.Adiciona(c);
            //    TextoProxNumero.Text = Convert.ToString(Conta.ProximoNumero());
            //}
            //else
            //{
            //    MessageBox.Show("Devedor");
            //}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selecionada = ComboTipo.SelectedIndex;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //implement later
        }
    }
}
