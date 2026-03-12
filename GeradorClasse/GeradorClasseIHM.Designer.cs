namespace GeradorClasse
{
    partial class GeradorClasseIHM
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
            this.tb_nome_classe = new System.Windows.Forms.TextBox();
            this.lb_lista_propriedade = new System.Windows.Forms.ListBox();
            this.btn_add_propriedade = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_gerar_classe = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_propriedade_classe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da Classe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prorpiedade(s):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lista de Propriedades:";
            // 
            // tb_nome_classe
            // 
            this.tb_nome_classe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome_classe.Location = new System.Drawing.Point(216, 86);
            this.tb_nome_classe.Name = "tb_nome_classe";
            this.tb_nome_classe.Size = new System.Drawing.Size(254, 29);
            this.tb_nome_classe.TabIndex = 3;
            // 
            // lb_lista_propriedade
            // 
            this.lb_lista_propriedade.FormattingEnabled = true;
            this.lb_lista_propriedade.Location = new System.Drawing.Point(216, 176);
            this.lb_lista_propriedade.Name = "lb_lista_propriedade";
            this.lb_lista_propriedade.Size = new System.Drawing.Size(254, 147);
            this.lb_lista_propriedade.TabIndex = 5;
            // 
            // btn_add_propriedade
            // 
            this.btn_add_propriedade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_propriedade.Location = new System.Drawing.Point(25, 210);
            this.btn_add_propriedade.Name = "btn_add_propriedade";
            this.btn_add_propriedade.Size = new System.Drawing.Size(176, 32);
            this.btn_add_propriedade.TabIndex = 6;
            this.btn_add_propriedade.Text = "Adicionar Propriedade";
            this.btn_add_propriedade.UseVisualStyleBackColor = true;
            this.btn_add_propriedade.Click += new System.EventHandler(this.btn_add_propriedade_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(25, 347);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(445, 34);
            this.btn_limpar.TabIndex = 7;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_gerar_classe
            // 
            this.btn_gerar_classe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerar_classe.Location = new System.Drawing.Point(25, 405);
            this.btn_gerar_classe.Name = "btn_gerar_classe";
            this.btn_gerar_classe.Size = new System.Drawing.Size(445, 32);
            this.btn_gerar_classe.TabIndex = 8;
            this.btn_gerar_classe.Text = "Gerar Classe";
            this.btn_gerar_classe.UseVisualStyleBackColor = true;
            this.btn_gerar_classe.Click += new System.EventHandler(this.btn_gerar_classe_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gerador de Classes";
            // 
            // tb_propriedade_classe
            // 
            this.tb_propriedade_classe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_propriedade_classe.Location = new System.Drawing.Point(25, 173);
            this.tb_propriedade_classe.Name = "tb_propriedade_classe";
            this.tb_propriedade_classe.Size = new System.Drawing.Size(176, 29);
            this.tb_propriedade_classe.TabIndex = 10;
            // 
            // GeradorClasseIHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.Controls.Add(this.tb_propriedade_classe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_gerar_classe);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_add_propriedade);
            this.Controls.Add(this.lb_lista_propriedade);
            this.Controls.Add(this.tb_nome_classe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GeradorClasseIHM";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nome_classe;
        private System.Windows.Forms.ListBox lb_lista_propriedade;
        private System.Windows.Forms.Button btn_add_propriedade;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_gerar_classe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_propriedade_classe;
    }
}

