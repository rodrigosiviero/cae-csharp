namespace Banco
{
    partial class FormCadastraConta
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
            this.Adicionar = new System.Windows.Forms.Button();
            this.TextoTitular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextoProxNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Adicionar
            // 
            this.Adicionar.Location = new System.Drawing.Point(30, 155);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(75, 23);
            this.Adicionar.TabIndex = 0;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = true;
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // TextoTitular
            // 
            this.TextoTitular.Location = new System.Drawing.Point(78, 23);
            this.TextoTitular.Name = "TextoTitular";
            this.TextoTitular.Size = new System.Drawing.Size(100, 20);
            this.TextoTitular.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // ComboTipo
            // 
            this.ComboTipo.FormattingEnabled = true;
            this.ComboTipo.Location = new System.Drawing.Point(78, 100);
            this.ComboTipo.Name = "ComboTipo";
            this.ComboTipo.Size = new System.Drawing.Size(121, 21);
            this.ComboTipo.TabIndex = 5;
            this.ComboTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo";
            // 
            // TextoProxNumero
            // 
            this.TextoProxNumero.Location = new System.Drawing.Point(78, 59);
            this.TextoProxNumero.Name = "TextoProxNumero";
            this.TextoProxNumero.ReadOnly = true;
            this.TextoProxNumero.Size = new System.Drawing.Size(100, 20);
            this.TextoProxNumero.TabIndex = 7;
            this.TextoProxNumero.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Numero";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormCadastraConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextoProxNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextoTitular);
            this.Controls.Add(this.Adicionar);
            this.Name = "FormCadastraConta";
            this.Text = "FormCadastraConta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.TextBox TextoTitular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextoProxNumero;
        private System.Windows.Forms.Label label2;
    }
}