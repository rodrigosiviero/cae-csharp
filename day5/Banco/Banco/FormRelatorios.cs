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

namespace Banco
{
    public partial class FormRelatorios : Form
    {
        private List<Conta> contas;
        public FormRelatorios(List<Conta> contas)
        {
            InitializeComponent();
            this.contas = contas;
        }

        private void botaoFiltroSaldo_Click(object sender, EventArgs e)
        {
            listaResultado.Items.Clear();
            
            var resultado = from c in contas
                            where c.Saldo > 5000
                            select c;
            foreach(Conta c in resultado)
            {
                listaResultado.Items.Add(c.Titular.Nome);
            }

            double saldoTotal = resultado.Sum(conta => conta.Saldo);
            double maiorSaldo = resultado.Max(conta => conta.Saldo);

            labelMaiorSaldo.Text = Convert.ToString(maiorSaldo);
            labelSaldototal.Text = Convert.ToString(saldoTotal);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaResultado.Items.Clear();
            var resultado = from c in contas
                            where c.Numero <= 10 && c.Saldo > 1000
                            select c;
            foreach (Conta c in resultado)
            {
                listaResultado.Items.Add(c);
            }

        }
    }
}
