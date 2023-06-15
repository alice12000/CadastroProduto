namespace CadastroProduto
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.unidade_tx = new System.Windows.Forms.ComboBox();
            this.cadastrar_tx = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pis_tx = new System.Windows.Forms.TextBox();
            this.confins_tx = new System.Windows.Forms.TextBox();
            this.icms_tx = new System.Windows.Forms.TextBox();
            this.descricao_tx = new System.Windows.Forms.TextBox();
            this.valor_tx = new System.Windows.Forms.TextBox();
            this.lucro_tx = new System.Windows.Forms.TextBox();
            this.codigo_tx = new System.Windows.Forms.TextBox();
            this.valor_final = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unidade: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(475, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "PIS:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lucro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(475, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Confins:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(475, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "ICMS:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(76, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Valor da Venda:";
            // 
            // unidade_tx
            // 
            this.unidade_tx.FormattingEnabled = true;
            this.unidade_tx.Items.AddRange(new object[] {
            "UN",
            "KG",
            "LT"});
            this.unidade_tx.Location = new System.Drawing.Point(544, 121);
            this.unidade_tx.Name = "unidade_tx";
            this.unidade_tx.Size = new System.Drawing.Size(121, 24);
            this.unidade_tx.TabIndex = 10;
            // 
            // cadastrar_tx
            // 
            this.cadastrar_tx.Location = new System.Drawing.Point(267, 347);
            this.cadastrar_tx.Name = "cadastrar_tx";
            this.cadastrar_tx.Size = new System.Drawing.Size(141, 46);
            this.cadastrar_tx.TabIndex = 11;
            this.cadastrar_tx.Text = "Cadastrar";
            this.cadastrar_tx.UseVisualStyleBackColor = true;
            this.cadastrar_tx.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(137, 128);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 16);
            this.linkLabel1.TabIndex = 12;
            // 
            // pis_tx
            // 
            this.pis_tx.Location = new System.Drawing.Point(544, 160);
            this.pis_tx.Name = "pis_tx";
            this.pis_tx.Size = new System.Drawing.Size(121, 22);
            this.pis_tx.TabIndex = 13;
            // 
            // confins_tx
            // 
            this.confins_tx.Location = new System.Drawing.Point(544, 205);
            this.confins_tx.Name = "confins_tx";
            this.confins_tx.Size = new System.Drawing.Size(121, 22);
            this.confins_tx.TabIndex = 14;
            // 
            // icms_tx
            // 
            this.icms_tx.Location = new System.Drawing.Point(544, 250);
            this.icms_tx.Name = "icms_tx";
            this.icms_tx.Size = new System.Drawing.Size(121, 22);
            this.icms_tx.TabIndex = 15;
            // 
            // descricao_tx
            // 
            this.descricao_tx.Location = new System.Drawing.Point(154, 162);
            this.descricao_tx.Name = "descricao_tx";
            this.descricao_tx.Size = new System.Drawing.Size(128, 22);
            this.descricao_tx.TabIndex = 16;
            // 
            // valor_tx
            // 
            this.valor_tx.Location = new System.Drawing.Point(140, 202);
            this.valor_tx.Name = "valor_tx";
            this.valor_tx.Size = new System.Drawing.Size(142, 22);
            this.valor_tx.TabIndex = 17;
            // 
            // lucro_tx
            // 
            this.lucro_tx.Location = new System.Drawing.Point(140, 247);
            this.lucro_tx.Name = "lucro_tx";
            this.lucro_tx.Size = new System.Drawing.Size(142, 22);
            this.lucro_tx.TabIndex = 18;
            // 
            // codigo_tx
            // 
            this.codigo_tx.Location = new System.Drawing.Point(154, 114);
            this.codigo_tx.Name = "codigo_tx";
            this.codigo_tx.Size = new System.Drawing.Size(128, 22);
            this.codigo_tx.TabIndex = 19;
            this.codigo_tx.TextChanged += new System.EventHandler(this.codigo_tx_TextChanged);
            // 
            // valor_final
            // 
            this.valor_final.AutoSize = true;
            this.valor_final.Location = new System.Drawing.Point(198, 291);
            this.valor_final.Name = "valor_final";
            this.valor_final.Size = new System.Drawing.Size(68, 16);
            this.valor_final.TabIndex = 21;
            this.valor_final.Text = "valor_final";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.valor_final);
            this.Controls.Add(this.codigo_tx);
            this.Controls.Add(this.lucro_tx);
            this.Controls.Add(this.valor_tx);
            this.Controls.Add(this.descricao_tx);
            this.Controls.Add(this.icms_tx);
            this.Controls.Add(this.confins_tx);
            this.Controls.Add(this.pis_tx);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cadastrar_tx);
            this.Controls.Add(this.unidade_tx);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox unidade_tx;
        private System.Windows.Forms.Button cadastrar_tx;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox pis_tx;
        private System.Windows.Forms.TextBox confins_tx;
        private System.Windows.Forms.TextBox icms_tx;
        private System.Windows.Forms.TextBox descricao_tx;
        private System.Windows.Forms.TextBox valor_tx;
        private System.Windows.Forms.TextBox lucro_tx;
        private System.Windows.Forms.TextBox codigo_tx;
        private System.Windows.Forms.Label valor_final;
    }
}

