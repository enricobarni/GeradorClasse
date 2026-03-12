using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ErroLib;

namespace GeradorClasse
{
    public partial class GeradorClasseIHM : Form
    {
        public GeradorClasseIHM()
        {
            InitializeComponent();
        }
        GeradorClasse gC = new GeradorClasse();
        private void btn_add_propriedade_Click(object sender, EventArgs e)
        {
            gC.setNomeClasse(tb_nome_classe.Text);
            gC.setPropriedades(tb_propriedade_classe.Text);
            GeradorClasseBLL.validaDados(gC);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
                return;
            }
            else
            {
                lb_lista_propriedade.Items.Add(tb_propriedade_classe.Text);
                tb_propriedade_classe.Clear();
                return;
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            gC.setNomeClasse("");
            gC.setPropriedades("");
            tb_nome_classe.Clear();
            tb_propriedade_classe.Clear();
            lb_lista_propriedade.Items.Clear();
        }

        private void btn_gerar_classe_Click(object sender, EventArgs e)
        {
            GeradorClasseBLL.validaDados(gC);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
                return;
            }
            else
            {
                GeradorClasse.gerarClasse(gC.getNomeClasse(), lb_lista_propriedade);
                MessageBox.Show("Classe Gerada com Sucesso!");
                return;
            }
        }
    }
}
