namespace CalculadoraChurrasco
{
    partial class frmChurrasco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChurrasco));
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.cbFrango = new System.Windows.Forms.CheckBox();
            this.cbMaminha = new System.Windows.Forms.CheckBox();
            this.cbLinguica = new System.Windows.Forms.CheckBox();
            this.cbPicanha = new System.Windows.Forms.CheckBox();
            this.cbPaes = new System.Windows.Forms.CheckBox();
            this.cbFarofa = new System.Windows.Forms.CheckBox();
            this.cbCarvao = new System.Windows.Forms.CheckBox();
            this.cbGelo = new System.Windows.Forms.CheckBox();
            this.txtRefrigerante = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cbRefrigerante = new System.Windows.Forms.CheckBox();
            this.numPessoas = new System.Windows.Forms.NumericUpDown();
            this.gpCarnes = new System.Windows.Forms.GroupBox();
            this.txtPicanha = new System.Windows.Forms.TextBox();
            this.txtFrango = new System.Windows.Forms.TextBox();
            this.txtMaminha = new System.Windows.Forms.TextBox();
            this.txtLinguica = new System.Windows.Forms.TextBox();
            this.gpOutros = new System.Windows.Forms.GroupBox();
            this.txtPaes = new System.Windows.Forms.TextBox();
            this.txtCarvao = new System.Windows.Forms.TextBox();
            this.txtFarofa = new System.Windows.Forms.TextBox();
            this.txtGelo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPessoas)).BeginInit();
            this.gpCarnes.SuspendLayout();
            this.gpOutros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(12, 21);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(117, 13);
            this.lblQuantidade.TabIndex = 0;
            this.lblQuantidade.Text = "Quantidade de pesoas:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 266);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(74, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total em (R$):";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(145, 260);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(241, 260);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // cbFrango
            // 
            this.cbFrango.AutoSize = true;
            this.cbFrango.Location = new System.Drawing.Point(11, 19);
            this.cbFrango.Name = "cbFrango";
            this.cbFrango.Size = new System.Drawing.Size(59, 17);
            this.cbFrango.TabIndex = 5;
            this.cbFrango.Text = "Frango";
            this.cbFrango.UseVisualStyleBackColor = true;
            // 
            // cbMaminha
            // 
            this.cbMaminha.AutoSize = true;
            this.cbMaminha.Location = new System.Drawing.Point(153, 19);
            this.cbMaminha.Name = "cbMaminha";
            this.cbMaminha.Size = new System.Drawing.Size(69, 17);
            this.cbMaminha.TabIndex = 6;
            this.cbMaminha.Text = "Maminha";
            this.cbMaminha.UseVisualStyleBackColor = true;
            // 
            // cbLinguica
            // 
            this.cbLinguica.AutoSize = true;
            this.cbLinguica.Location = new System.Drawing.Point(11, 48);
            this.cbLinguica.Name = "cbLinguica";
            this.cbLinguica.Size = new System.Drawing.Size(66, 17);
            this.cbLinguica.TabIndex = 7;
            this.cbLinguica.Text = "Linguiça";
            this.cbLinguica.UseVisualStyleBackColor = true;
            // 
            // cbPicanha
            // 
            this.cbPicanha.AutoSize = true;
            this.cbPicanha.Location = new System.Drawing.Point(153, 46);
            this.cbPicanha.Name = "cbPicanha";
            this.cbPicanha.Size = new System.Drawing.Size(65, 17);
            this.cbPicanha.TabIndex = 8;
            this.cbPicanha.Text = "Picanha";
            this.cbPicanha.UseVisualStyleBackColor = true;
            // 
            // cbPaes
            // 
            this.cbPaes.AutoSize = true;
            this.cbPaes.Location = new System.Drawing.Point(12, 19);
            this.cbPaes.Name = "cbPaes";
            this.cbPaes.Size = new System.Drawing.Size(50, 17);
            this.cbPaes.TabIndex = 9;
            this.cbPaes.Text = "Pães";
            this.cbPaes.UseVisualStyleBackColor = true;
            // 
            // cbFarofa
            // 
            this.cbFarofa.AutoSize = true;
            this.cbFarofa.Location = new System.Drawing.Point(154, 19);
            this.cbFarofa.Name = "cbFarofa";
            this.cbFarofa.Size = new System.Drawing.Size(59, 17);
            this.cbFarofa.TabIndex = 10;
            this.cbFarofa.Text = "Farofa ";
            this.cbFarofa.UseVisualStyleBackColor = true;
            // 
            // cbCarvao
            // 
            this.cbCarvao.AutoSize = true;
            this.cbCarvao.Location = new System.Drawing.Point(12, 48);
            this.cbCarvao.Name = "cbCarvao";
            this.cbCarvao.Size = new System.Drawing.Size(60, 17);
            this.cbCarvao.TabIndex = 11;
            this.cbCarvao.Text = "Carvão";
            this.cbCarvao.UseVisualStyleBackColor = true;
            // 
            // cbGelo
            // 
            this.cbGelo.AutoSize = true;
            this.cbGelo.Location = new System.Drawing.Point(154, 48);
            this.cbGelo.Name = "cbGelo";
            this.cbGelo.Size = new System.Drawing.Size(48, 17);
            this.cbGelo.TabIndex = 12;
            this.cbGelo.Text = "Gelo";
            this.cbGelo.UseVisualStyleBackColor = true;
            // 
            // txtRefrigerante
            // 
            this.txtRefrigerante.Location = new System.Drawing.Point(136, 220);
            this.txtRefrigerante.Name = "txtRefrigerante";
            this.txtRefrigerante.Size = new System.Drawing.Size(100, 20);
            this.txtRefrigerante.TabIndex = 13;
            this.txtRefrigerante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(95, 263);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(41, 20);
            this.txtTotal.TabIndex = 14;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbRefrigerante
            // 
            this.cbRefrigerante.AutoSize = true;
            this.cbRefrigerante.Location = new System.Drawing.Point(15, 223);
            this.cbRefrigerante.Name = "cbRefrigerante";
            this.cbRefrigerante.Size = new System.Drawing.Size(121, 17);
            this.cbRefrigerante.TabIndex = 15;
            this.cbRefrigerante.Text = "Refrigerante em lata";
            this.cbRefrigerante.UseVisualStyleBackColor = true;
            // 
            // numPessoas
            // 
            this.numPessoas.Location = new System.Drawing.Point(135, 19);
            this.numPessoas.Name = "numPessoas";
            this.numPessoas.Size = new System.Drawing.Size(35, 20);
            this.numPessoas.TabIndex = 16;
            this.numPessoas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gpCarnes
            // 
            this.gpCarnes.Controls.Add(this.txtPicanha);
            this.gpCarnes.Controls.Add(this.txtFrango);
            this.gpCarnes.Controls.Add(this.txtMaminha);
            this.gpCarnes.Controls.Add(this.cbFrango);
            this.gpCarnes.Controls.Add(this.txtLinguica);
            this.gpCarnes.Controls.Add(this.cbMaminha);
            this.gpCarnes.Controls.Add(this.cbLinguica);
            this.gpCarnes.Controls.Add(this.cbPicanha);
            this.gpCarnes.Location = new System.Drawing.Point(15, 45);
            this.gpCarnes.Name = "gpCarnes";
            this.gpCarnes.Size = new System.Drawing.Size(312, 78);
            this.gpCarnes.TabIndex = 17;
            this.gpCarnes.TabStop = false;
            this.gpCarnes.Text = "Carnes:";
            // 
            // txtPicanha
            // 
            this.txtPicanha.Location = new System.Drawing.Point(228, 45);
            this.txtPicanha.Name = "txtPicanha";
            this.txtPicanha.Size = new System.Drawing.Size(70, 20);
            this.txtPicanha.TabIndex = 21;
            this.txtPicanha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFrango
            // 
            this.txtFrango.Location = new System.Drawing.Point(77, 19);
            this.txtFrango.Name = "txtFrango";
            this.txtFrango.Size = new System.Drawing.Size(70, 20);
            this.txtFrango.TabIndex = 18;
            this.txtFrango.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaminha
            // 
            this.txtMaminha.Location = new System.Drawing.Point(228, 17);
            this.txtMaminha.Name = "txtMaminha";
            this.txtMaminha.Size = new System.Drawing.Size(70, 20);
            this.txtMaminha.TabIndex = 20;
            this.txtMaminha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLinguica
            // 
            this.txtLinguica.Location = new System.Drawing.Point(77, 46);
            this.txtLinguica.Name = "txtLinguica";
            this.txtLinguica.Size = new System.Drawing.Size(70, 20);
            this.txtLinguica.TabIndex = 19;
            this.txtLinguica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gpOutros
            // 
            this.gpOutros.Controls.Add(this.txtGelo);
            this.gpOutros.Controls.Add(this.cbPaes);
            this.gpOutros.Controls.Add(this.txtFarofa);
            this.gpOutros.Controls.Add(this.cbFarofa);
            this.gpOutros.Controls.Add(this.txtCarvao);
            this.gpOutros.Controls.Add(this.cbCarvao);
            this.gpOutros.Controls.Add(this.txtPaes);
            this.gpOutros.Controls.Add(this.cbGelo);
            this.gpOutros.Location = new System.Drawing.Point(15, 129);
            this.gpOutros.Name = "gpOutros";
            this.gpOutros.Size = new System.Drawing.Size(312, 78);
            this.gpOutros.TabIndex = 18;
            this.gpOutros.TabStop = false;
            this.gpOutros.Text = "Outros:";
            // 
            // txtPaes
            // 
            this.txtPaes.Location = new System.Drawing.Point(78, 16);
            this.txtPaes.Name = "txtPaes";
            this.txtPaes.Size = new System.Drawing.Size(70, 20);
            this.txtPaes.TabIndex = 19;
            this.txtPaes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCarvao
            // 
            this.txtCarvao.Location = new System.Drawing.Point(78, 43);
            this.txtCarvao.Name = "txtCarvao";
            this.txtCarvao.Size = new System.Drawing.Size(70, 20);
            this.txtCarvao.TabIndex = 20;
            this.txtCarvao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFarofa
            // 
            this.txtFarofa.Location = new System.Drawing.Point(229, 19);
            this.txtFarofa.Name = "txtFarofa";
            this.txtFarofa.Size = new System.Drawing.Size(70, 20);
            this.txtFarofa.TabIndex = 21;
            this.txtFarofa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGelo
            // 
            this.txtGelo.Location = new System.Drawing.Point(229, 46);
            this.txtGelo.Name = "txtGelo";
            this.txtGelo.Size = new System.Drawing.Size(70, 20);
            this.txtGelo.TabIndex = 22;
            this.txtGelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmChurrasco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 297);
            this.Controls.Add(this.gpOutros);
            this.Controls.Add(this.gpCarnes);
            this.Controls.Add(this.numPessoas);
            this.Controls.Add(this.cbRefrigerante);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtRefrigerante);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblQuantidade);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(358, 336);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(358, 336);
            this.Name = "frmChurrasco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Churrasco";
            ((System.ComponentModel.ISupportInitialize)(this.numPessoas)).EndInit();
            this.gpCarnes.ResumeLayout(false);
            this.gpCarnes.PerformLayout();
            this.gpOutros.ResumeLayout(false);
            this.gpOutros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.CheckBox cbFrango;
        private System.Windows.Forms.CheckBox cbMaminha;
        private System.Windows.Forms.CheckBox cbLinguica;
        private System.Windows.Forms.CheckBox cbPicanha;
        private System.Windows.Forms.CheckBox cbPaes;
        private System.Windows.Forms.CheckBox cbFarofa;
        private System.Windows.Forms.CheckBox cbCarvao;
        private System.Windows.Forms.CheckBox cbGelo;
        private System.Windows.Forms.TextBox txtRefrigerante;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.CheckBox cbRefrigerante;
        private System.Windows.Forms.NumericUpDown numPessoas;
        private System.Windows.Forms.GroupBox gpCarnes;
        private System.Windows.Forms.TextBox txtFrango;
        private System.Windows.Forms.TextBox txtLinguica;
        private System.Windows.Forms.TextBox txtMaminha;
        private System.Windows.Forms.TextBox txtPicanha;
        private System.Windows.Forms.GroupBox gpOutros;
        private System.Windows.Forms.TextBox txtGelo;
        private System.Windows.Forms.TextBox txtFarofa;
        private System.Windows.Forms.TextBox txtCarvao;
        private System.Windows.Forms.TextBox txtPaes;
    }
}

