namespace GestaodeJogadores
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nomeJogador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_listaJogadores = new System.Windows.Forms.TextBox();
            this.button_gravar = new System.Windows.Forms.Button();
            this.button_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Jogador";
            // 
            // textBox_nomeJogador
            // 
            this.textBox_nomeJogador.Location = new System.Drawing.Point(106, 13);
            this.textBox_nomeJogador.Name = "textBox_nomeJogador";
            this.textBox_nomeJogador.Size = new System.Drawing.Size(123, 20);
            this.textBox_nomeJogador.TabIndex = 1;
            this.textBox_nomeJogador.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lista de Jogadores Cadastrados";
            // 
            // textBox_listaJogadores
            // 
            this.textBox_listaJogadores.Enabled = false;
            this.textBox_listaJogadores.Location = new System.Drawing.Point(230, 42);
            this.textBox_listaJogadores.Multiline = true;
            this.textBox_listaJogadores.Name = "textBox_listaJogadores";
            this.textBox_listaJogadores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_listaJogadores.Size = new System.Drawing.Size(400, 201);
            this.textBox_listaJogadores.TabIndex = 3;
            this.textBox_listaJogadores.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button_gravar
            // 
            this.button_gravar.Location = new System.Drawing.Point(25, 119);
            this.button_gravar.Name = "button_gravar";
            this.button_gravar.Size = new System.Drawing.Size(75, 23);
            this.button_gravar.TabIndex = 4;
            this.button_gravar.Text = "Gravar";
            this.button_gravar.UseVisualStyleBackColor = true;
            this.button_gravar.Click += new System.EventHandler(this.button_gravar_Click);
            this.button_gravar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_gravar_MouseClick);
            // 
            // button_limpar
            // 
            this.button_limpar.Location = new System.Drawing.Point(116, 119);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(75, 23);
            this.button_limpar.TabIndex = 5;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_limpar_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.button_gravar);
            this.Controls.Add(this.textBox_listaJogadores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_nomeJogador);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " Formulário de Gestão de Jogadores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nomeJogador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_listaJogadores;
        private System.Windows.Forms.Button button_gravar;
        private System.Windows.Forms.Button button_limpar;
    }
}

