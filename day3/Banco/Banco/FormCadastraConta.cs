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
    public partial class FormCadastraConta : Form
    {
        private int selecionada;
        private Form1 FormPrincipal;
        private Conta c;

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
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            String nomeTitular = TextoTitular.Text;
            int numero = Convert.ToInt32(TextoNumero.Text);
            if (this.selecionada == 0)
            {
                c = new ContaCorrente();
            }
            else
            {
                c = new ContaPoupanca();
            }
            c.Numero = numero;
            c.Titular = new Cliente(nomeTitular);
            this.FormPrincipal.Adiciona(c);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selecionada = ComboTipo.SelectedIndex;
        }
    }
}
