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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nome_classe = new System.Windows.Forms.TextBox();
            this.lb_lista_propriedade = new System.Windows.Forms.ListBox();
            this.btn_add_propriedade = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_gerar_classe = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_propriedade_classe = new System.Windows.Forms.TextBox();
            this.btn_path = new System.Windows.Forms.Button();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.cb_path = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.label2.Text = "Propriedade(s):";
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
            this.lb_lista_propriedade.Location = new System.Drawing.Point(25, 249);
            this.lb_lista_propriedade.Name = "lb_lista_propriedade";
            this.lb_lista_propriedade.Size = new System.Drawing.Size(176, 134);
            this.lb_lista_propriedade.TabIndex = 5;
            // 
            // btn_add_propriedade
            // 
            this.btn_add_propriedade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_propriedade.Location = new System.Drawing.Point(25, 211);
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
            this.btn_limpar.Location = new System.Drawing.Point(25, 414);
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
            this.btn_gerar_classe.Location = new System.Drawing.Point(25, 465);
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
            // btn_path
            // 
            this.btn_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_path.Location = new System.Drawing.Point(265, 173);
            this.btn_path.Name = "btn_path";
            this.btn_path.Size = new System.Drawing.Size(176, 32);
            this.btn_path.TabIndex = 11;
            this.btn_path.Text = "Escolha o path do projeto";
            this.btn_path.UseVisualStyleBackColor = true;
            this.btn_path.Click += new System.EventHandler(this.btn_path_Click);
            // 
            // tb_path
            // 
            this.tb_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_path.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_path.Location = new System.Drawing.Point(265, 211);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(176, 29);
            this.tb_path.TabIndex = 12;
            this.tb_path.Text = "Path selecionado";
            this.tb_path.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_path.TextChanged += new System.EventHandler(this.tb_path_TextChanged);
            // 
            // cb_path
            // 
            this.cb_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_path.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cb_path.FormattingEnabled = true;
            this.cb_path.Location = new System.Drawing.Point(265, 324);
            this.cb_path.Name = "cb_path";
            this.cb_path.Size = new System.Drawing.Size(176, 28);
            this.cb_path.TabIndex = 13;
            this.cb_path.Text = "Nome Projeto";
            this.cb_path.SelectedIndexChanged += new System.EventHandler(this.cb_path_SelectedIndexChanged);
            this.cb_path.MouseHover += new System.EventHandler(this.cb_path_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Selecionar o projeto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Caso haja mais de um projeto:";
            // 
            // GeradorClasseIHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 523);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_path);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.btn_path);
            this.Controls.Add(this.tb_propriedade_classe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_gerar_classe);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_add_propriedade);
            this.Controls.Add(this.lb_lista_propriedade);
            this.Controls.Add(this.tb_nome_classe);
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
        private System.Windows.Forms.TextBox tb_nome_classe;
        private System.Windows.Forms.ListBox lb_lista_propriedade;
        private System.Windows.Forms.Button btn_add_propriedade;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_gerar_classe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_propriedade_classe;
        private System.Windows.Forms.Button btn_path;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.ComboBox cb_path;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

