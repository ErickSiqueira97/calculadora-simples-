namespace Calculadora
{
    partial class Calculadora
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
            this.btIgual = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btQuatro = new System.Windows.Forms.Button();
            this.btCinco = new System.Windows.Forms.Button();
            this.btSeis = new System.Windows.Forms.Button();
            this.btSubtracao = new System.Windows.Forms.Button();
            this.btMultiplicacao = new System.Windows.Forms.Button();
            this.btSete = new System.Windows.Forms.Button();
            this.btOito = new System.Windows.Forms.Button();
            this.btNove = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.btAdicao = new System.Windows.Forms.Button();
            this.btTres = new System.Windows.Forms.Button();
            this.btDois = new System.Windows.Forms.Button();
            this.btUm = new System.Windows.Forms.Button();
            this.btDivisao = new System.Windows.Forms.Button();
            this.btZero = new System.Windows.Forms.Button();
            this.btPonto = new System.Windows.Forms.Button();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btIgual
            // 
            this.btIgual.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btIgual.Location = new System.Drawing.Point(210, 214);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(59, 35);
            this.btIgual.TabIndex = 0;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = false;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.Menu;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(12, 12);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(261, 29);
            this.txtResultado.TabIndex = 1;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // btQuatro
            // 
            this.btQuatro.Location = new System.Drawing.Point(12, 132);
            this.btQuatro.Name = "btQuatro";
            this.btQuatro.Size = new System.Drawing.Size(59, 35);
            this.btQuatro.TabIndex = 2;
            this.btQuatro.Text = "4";
            this.btQuatro.UseVisualStyleBackColor = true;
            this.btQuatro.Click += new System.EventHandler(this.btQuatro_Click);
            // 
            // btCinco
            // 
            this.btCinco.Location = new System.Drawing.Point(80, 132);
            this.btCinco.Name = "btCinco";
            this.btCinco.Size = new System.Drawing.Size(59, 35);
            this.btCinco.TabIndex = 3;
            this.btCinco.Text = "5";
            this.btCinco.UseVisualStyleBackColor = true;
            this.btCinco.Click += new System.EventHandler(this.btCinco_Click);
            // 
            // btSeis
            // 
            this.btSeis.Location = new System.Drawing.Point(145, 132);
            this.btSeis.Name = "btSeis";
            this.btSeis.Size = new System.Drawing.Size(59, 35);
            this.btSeis.TabIndex = 4;
            this.btSeis.Text = "6";
            this.btSeis.UseVisualStyleBackColor = true;
            this.btSeis.Click += new System.EventHandler(this.btSeis_Click);
            // 
            // btSubtracao
            // 
            this.btSubtracao.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btSubtracao.Location = new System.Drawing.Point(210, 132);
            this.btSubtracao.Name = "btSubtracao";
            this.btSubtracao.Size = new System.Drawing.Size(59, 35);
            this.btSubtracao.TabIndex = 5;
            this.btSubtracao.Text = "-";
            this.btSubtracao.UseVisualStyleBackColor = false;
            this.btSubtracao.Click += new System.EventHandler(this.btSubtrair_Click);
            // 
            // btMultiplicacao
            // 
            this.btMultiplicacao.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btMultiplicacao.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btMultiplicacao.Location = new System.Drawing.Point(210, 91);
            this.btMultiplicacao.Name = "btMultiplicacao";
            this.btMultiplicacao.Size = new System.Drawing.Size(59, 35);
            this.btMultiplicacao.TabIndex = 6;
            this.btMultiplicacao.Text = "x";
            this.btMultiplicacao.UseVisualStyleBackColor = false;
            this.btMultiplicacao.Click += new System.EventHandler(this.btMultiplicar_Click);
            // 
            // btSete
            // 
            this.btSete.Location = new System.Drawing.Point(12, 91);
            this.btSete.Name = "btSete";
            this.btSete.Size = new System.Drawing.Size(59, 35);
            this.btSete.TabIndex = 7;
            this.btSete.Text = "7";
            this.btSete.UseVisualStyleBackColor = true;
            this.btSete.Click += new System.EventHandler(this.btSete_Click);
            // 
            // btOito
            // 
            this.btOito.Location = new System.Drawing.Point(80, 91);
            this.btOito.Name = "btOito";
            this.btOito.Size = new System.Drawing.Size(59, 35);
            this.btOito.TabIndex = 8;
            this.btOito.Text = "8";
            this.btOito.UseVisualStyleBackColor = true;
            this.btOito.Click += new System.EventHandler(this.btOito_Click);
            // 
            // btNove
            // 
            this.btNove.Location = new System.Drawing.Point(145, 91);
            this.btNove.Name = "btNove";
            this.btNove.Size = new System.Drawing.Size(59, 35);
            this.btNove.TabIndex = 9;
            this.btNove.Text = "9";
            this.btNove.UseVisualStyleBackColor = true;
            this.btNove.Click += new System.EventHandler(this.btNove_Click);
            // 
            // btC
            // 
            this.btC.Location = new System.Drawing.Point(222, 61);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(47, 24);
            this.btC.TabIndex = 10;
            this.btC.Text = "c";
            this.btC.UseVisualStyleBackColor = true;
            this.btC.Click += new System.EventHandler(this.btC_Click);
            // 
            // btAdicao
            // 
            this.btAdicao.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btAdicao.Location = new System.Drawing.Point(210, 173);
            this.btAdicao.Name = "btAdicao";
            this.btAdicao.Size = new System.Drawing.Size(59, 35);
            this.btAdicao.TabIndex = 11;
            this.btAdicao.Text = "+";
            this.btAdicao.UseVisualStyleBackColor = false;
            this.btAdicao.Click += new System.EventHandler(this.btSomar_Click);
            // 
            // btTres
            // 
            this.btTres.Location = new System.Drawing.Point(145, 173);
            this.btTres.Name = "btTres";
            this.btTres.Size = new System.Drawing.Size(59, 35);
            this.btTres.TabIndex = 12;
            this.btTres.Text = "3";
            this.btTres.UseVisualStyleBackColor = true;
            this.btTres.Click += new System.EventHandler(this.btTres_Click);
            // 
            // btDois
            // 
            this.btDois.Location = new System.Drawing.Point(80, 173);
            this.btDois.Name = "btDois";
            this.btDois.Size = new System.Drawing.Size(59, 35);
            this.btDois.TabIndex = 13;
            this.btDois.Text = "2";
            this.btDois.UseVisualStyleBackColor = true;
            this.btDois.Click += new System.EventHandler(this.btDois_Click);
            // 
            // btUm
            // 
            this.btUm.Location = new System.Drawing.Point(12, 173);
            this.btUm.Name = "btUm";
            this.btUm.Size = new System.Drawing.Size(59, 35);
            this.btUm.TabIndex = 14;
            this.btUm.Text = "1";
            this.btUm.UseVisualStyleBackColor = true;
            this.btUm.Click += new System.EventHandler(this.btUm_Click);
            // 
            // btDivisao
            // 
            this.btDivisao.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btDivisao.Location = new System.Drawing.Point(145, 214);
            this.btDivisao.Name = "btDivisao";
            this.btDivisao.Size = new System.Drawing.Size(59, 35);
            this.btDivisao.TabIndex = 15;
            this.btDivisao.Text = "/";
            this.btDivisao.UseVisualStyleBackColor = false;
            this.btDivisao.Click += new System.EventHandler(this.btDividir_Click);
            // 
            // btZero
            // 
            this.btZero.Location = new System.Drawing.Point(80, 214);
            this.btZero.Name = "btZero";
            this.btZero.Size = new System.Drawing.Size(59, 35);
            this.btZero.TabIndex = 16;
            this.btZero.Text = "0";
            this.btZero.UseVisualStyleBackColor = true;
            this.btZero.Click += new System.EventHandler(this.btZero_Click);
            // 
            // btPonto
            // 
            this.btPonto.Location = new System.Drawing.Point(12, 214);
            this.btPonto.Name = "btPonto";
            this.btPonto.Size = new System.Drawing.Size(59, 35);
            this.btPonto.TabIndex = 17;
            this.btPonto.Text = ",";
            this.btPonto.UseVisualStyleBackColor = true;
            this.btPonto.Click += new System.EventHandler(this.btPonto_Click);
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacao.Location = new System.Drawing.Point(246, 15);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(0, 24);
            this.lblOperacao.TabIndex = 18;
            // 
            // Calculadora
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(285, 267);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.btPonto);
            this.Controls.Add(this.btZero);
            this.Controls.Add(this.btDivisao);
            this.Controls.Add(this.btUm);
            this.Controls.Add(this.btDois);
            this.Controls.Add(this.btTres);
            this.Controls.Add(this.btAdicao);
            this.Controls.Add(this.btC);
            this.Controls.Add(this.btNove);
            this.Controls.Add(this.btOito);
            this.Controls.Add(this.btSete);
            this.Controls.Add(this.btMultiplicacao);
            this.Controls.Add(this.btSubtracao);
            this.Controls.Add(this.btSeis);
            this.Controls.Add(this.btCinco);
            this.Controls.Add(this.btQuatro);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btIgual);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btQuatro;
        private System.Windows.Forms.Button btCinco;
        private System.Windows.Forms.Button btSeis;
        private System.Windows.Forms.Button btSubtracao;
        private System.Windows.Forms.Button btMultiplicacao;
        private System.Windows.Forms.Button btSete;
        private System.Windows.Forms.Button btOito;
        private System.Windows.Forms.Button btNove;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button btAdicao;
        private System.Windows.Forms.Button btTres;
        private System.Windows.Forms.Button btDois;
        private System.Windows.Forms.Button btUm;
        private System.Windows.Forms.Button btDivisao;
        private System.Windows.Forms.Button btZero;
        private System.Windows.Forms.Button btPonto;
        private System.Windows.Forms.Label lblOperacao;
    }
}

