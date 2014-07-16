namespace Banco
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextoTitular = new System.Windows.Forms.TextBox();
            this.TextoNumero = new System.Windows.Forms.TextBox();
            this.TextoSaldo = new System.Windows.Forms.TextBox();
            this.TextoValor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TextoSaque = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TextoSaldoTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboContas = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboTransferencia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TextoTransfNumero = new System.Windows.Forms.TextBox();
            this.TextoTransfTitular = new System.Windows.Forms.TextBox();
            this.Transferencia = new System.Windows.Forms.Button();
            this.TextoTransferencia = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextoTitular
            // 
            this.TextoTitular.Location = new System.Drawing.Point(83, 79);
            this.TextoTitular.Name = "TextoTitular";
            this.TextoTitular.ReadOnly = true;
            this.TextoTitular.Size = new System.Drawing.Size(100, 20);
            this.TextoTitular.TabIndex = 0;
            // 
            // TextoNumero
            // 
            this.TextoNumero.Location = new System.Drawing.Point(83, 127);
            this.TextoNumero.Name = "TextoNumero";
            this.TextoNumero.ReadOnly = true;
            this.TextoNumero.Size = new System.Drawing.Size(100, 20);
            this.TextoNumero.TabIndex = 1;
            // 
            // TextoSaldo
            // 
            this.TextoSaldo.Location = new System.Drawing.Point(83, 172);
            this.TextoSaldo.Name = "TextoSaldo";
            this.TextoSaldo.ReadOnly = true;
            this.TextoSaldo.Size = new System.Drawing.Size(100, 20);
            this.TextoSaldo.TabIndex = 2;
            this.TextoSaldo.TextChanged += new System.EventHandler(this.TextoSaldo_TextChanged);
            // 
            // TextoValor
            // 
            this.TextoValor.Location = new System.Drawing.Point(12, 236);
            this.TextoValor.Name = "TextoValor";
            this.TextoValor.Size = new System.Drawing.Size(75, 20);
            this.TextoValor.TabIndex = 3;
            this.TextoValor.TextChanged += new System.EventHandler(this.TextoValor_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Depositar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextoSaque
            // 
            this.TextoSaque.Location = new System.Drawing.Point(107, 224);
            this.TextoSaque.Name = "TextoSaque";
            this.TextoSaque.Size = new System.Drawing.Size(75, 20);
            this.TextoSaque.TabIndex = 5;
            this.TextoSaque.TextChanged += new System.EventHandler(this.TextoSaque_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sacar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextoTransferencia);
            this.groupBox1.Controls.Add(this.Transferencia);
            this.groupBox1.Controls.Add(this.ComboContas);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TextoSaque);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TextoSaldoTotal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 293);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(188, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Totalizador";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Saldo Total";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TextoSaldoTotal
            // 
            this.TextoSaldoTotal.Location = new System.Drawing.Point(80, 198);
            this.TextoSaldoTotal.Name = "TextoSaldoTotal";
            this.TextoSaldoTotal.ReadOnly = true;
            this.TextoSaldoTotal.Size = new System.Drawing.Size(100, 20);
            this.TextoSaldoTotal.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Escolha a Conta";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ComboContas
            // 
            this.ComboContas.FormattingEnabled = true;
            this.ComboContas.Location = new System.Drawing.Point(107, 22);
            this.ComboContas.Name = "ComboContas";
            this.ComboContas.Size = new System.Drawing.Size(121, 21);
            this.ComboContas.TabIndex = 11;
            this.ComboContas.SelectedIndexChanged += new System.EventHandler(this.ComboContas_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.TextoTransfNumero);
            this.groupBox2.Controls.Add(this.comboTransferencia);
            this.groupBox2.Controls.Add(this.TextoTransfTitular);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(285, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 293);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transferencia";
            // 
            // comboTransferencia
            // 
            this.comboTransferencia.FormattingEnabled = true;
            this.comboTransferencia.Location = new System.Drawing.Point(107, 22);
            this.comboTransferencia.Name = "comboTransferencia";
            this.comboTransferencia.Size = new System.Drawing.Size(121, 21);
            this.comboTransferencia.TabIndex = 11;
            this.comboTransferencia.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Escolha a Conta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Numero";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nome";
            // 
            // TextoTransfNumero
            // 
            this.TextoTransfNumero.Location = new System.Drawing.Point(107, 115);
            this.TextoTransfNumero.Name = "TextoTransfNumero";
            this.TextoTransfNumero.ReadOnly = true;
            this.TextoTransfNumero.Size = new System.Drawing.Size(100, 20);
            this.TextoTransfNumero.TabIndex = 14;
            // 
            // TextoTransfTitular
            // 
            this.TextoTransfTitular.Location = new System.Drawing.Point(107, 67);
            this.TextoTransfTitular.Name = "TextoTransfTitular";
            this.TextoTransfTitular.ReadOnly = true;
            this.TextoTransfTitular.Size = new System.Drawing.Size(100, 20);
            this.TextoTransfTitular.TabIndex = 13;
            // 
            // Transferencia
            // 
            this.Transferencia.Location = new System.Drawing.Point(188, 251);
            this.Transferencia.Name = "Transferencia";
            this.Transferencia.Size = new System.Drawing.Size(81, 23);
            this.Transferencia.TabIndex = 12;
            this.Transferencia.Text = "Transferencia";
            this.Transferencia.UseVisualStyleBackColor = true;
            this.Transferencia.Click += new System.EventHandler(this.Transferencia_Click);
            // 
            // TextoTransferencia
            // 
            this.TextoTransferencia.Location = new System.Drawing.Point(188, 225);
            this.TextoTransferencia.Name = "TextoTransferencia";
            this.TextoTransferencia.Size = new System.Drawing.Size(75, 20);
            this.TextoTransferencia.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Saldo";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 312);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "NovaConta";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 347);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextoValor);
            this.Controls.Add(this.TextoSaldo);
            this.Controls.Add(this.TextoNumero);
            this.Controls.Add(this.TextoTitular);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextoTitular;
        private System.Windows.Forms.TextBox TextoNumero;
        private System.Windows.Forms.TextBox TextoSaldo;
        private System.Windows.Forms.TextBox TextoValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextoSaque;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextoSaldoTotal;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboContas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboTransferencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextoTransfNumero;
        private System.Windows.Forms.TextBox TextoTransfTitular;
        private System.Windows.Forms.TextBox TextoTransferencia;
        private System.Windows.Forms.Button Transferencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
    }
}

