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
        private Form1 FormPrincipal;

        public FormCadastraConta()
        {
            InitializeComponent();
        }

        public FormCadastraConta(Form1 formPrincipal)
        {
            this.FormPrincipal = formPrincipal;
            InitializeComponent();
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            String nomeTitular = TextoTitular.Text;
            int numero = Convert.ToInt32(TextoNumero.Text);
            Conta c = new ContaCorrente();
            c.Numero = numero;
            c.Titular = new Cliente(nomeTitular);
            this.FormPrincipal.Adiciona(c);
        }
    }
}
