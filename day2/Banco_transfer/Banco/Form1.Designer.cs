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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextoSaldo2 = new System.Windows.Forms.TextBox();
            this.TextoNumero2 = new System.Windows.Forms.TextBox();
            this.TextoTitular2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.TextoTransfer = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextoTitular
            // 
            this.TextoTitular.Location = new System.Drawing.Point(83, 34);
            this.TextoTitular.Name = "TextoTitular";
            this.TextoTitular.ReadOnly = true;
            this.TextoTitular.Size = new System.Drawing.Size(100, 20);
            this.TextoTitular.TabIndex = 0;
            // 
            // TextoNumero
            // 
            this.TextoNumero.Location = new System.Drawing.Point(83, 82);
            this.TextoNumero.Name = "TextoNumero";
            this.TextoNumero.ReadOnly = true;
            this.TextoNumero.Size = new System.Drawing.Size(100, 20);
            this.TextoNumero.TabIndex = 1;
            // 
            // TextoSaldo
            // 
            this.TextoSaldo.Location = new System.Drawing.Point(83, 127);
            this.TextoSaldo.Name = "TextoSaldo";
            this.TextoSaldo.ReadOnly = true;
            this.TextoSaldo.Size = new System.Drawing.Size(100, 20);
            this.TextoSaldo.TabIndex = 2;
            this.TextoSaldo.TextChanged += new System.EventHandler(this.TextoSaldo_TextChanged);
            // 
            // TextoValor
            // 
            this.TextoValor.Location = new System.Drawing.Point(9, 157);
            this.TextoValor.Name = "TextoValor";
            this.TextoValor.Size = new System.Drawing.Size(75, 20);
            this.TextoValor.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Depositar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextoSaque
            // 
            this.TextoSaque.Location = new System.Drawing.Point(178, 157);
            this.TextoSaque.Name = "TextoSaque";
            this.TextoSaque.Size = new System.Drawing.Size(75, 20);
            this.TextoSaque.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sacar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TextoSaque);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TextoValor);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 190);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextoSaldo2);
            this.groupBox2.Controls.Add(this.TextoNumero2);
            this.groupBox2.Controls.Add(this.TextoTitular2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(306, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 190);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conta 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Saldo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Numero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nome";
            // 
            // TextoSaldo2
            // 
            this.TextoSaldo2.Location = new System.Drawing.Point(80, 115);
            this.TextoSaldo2.Name = "TextoSaldo2";
            this.TextoSaldo2.ReadOnly = true;
            this.TextoSaldo2.Size = new System.Drawing.Size(100, 20);
            this.TextoSaldo2.TabIndex = 13;
            // 
            // TextoNumero2
            // 
            this.TextoNumero2.Location = new System.Drawing.Point(80, 70);
            this.TextoNumero2.Name = "TextoNumero2";
            this.TextoNumero2.ReadOnly = true;
            this.TextoNumero2.Size = new System.Drawing.Size(100, 20);
            this.TextoNumero2.TabIndex = 12;
            // 
            // TextoTitular2
            // 
            this.TextoTitular2.Location = new System.Drawing.Point(80, 22);
            this.TextoTitular2.Name = "TextoTitular2";
            this.TextoTitular2.ReadOnly = true;
            this.TextoTitular2.Size = new System.Drawing.Size(100, 20);
            this.TextoTitular2.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(197, 251);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Transfere";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // TextoTransfer
            // 
            this.TextoTransfer.Location = new System.Drawing.Point(108, 253);
            this.TextoTransfer.Name = "TextoTransfer";
            this.TextoTransfer.Size = new System.Drawing.Size(75, 20);
            this.TextoTransfer.TabIndex = 6;
            this.TextoTransfer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 286);
            this.Controls.Add(this.TextoTransfer);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextoSaldo2;
        private System.Windows.Forms.TextBox TextoNumero2;
        private System.Windows.Forms.TextBox TextoTitular2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox TextoTransfer;
    }
}

