using ErroLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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
            if (string.IsNullOrEmpty(cb_path.SelectedItem?.ToString()))
            {
                MessageBox.Show("Selecione um projeto para gerar a classe!");
                return;
            }
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
                return;
            }
            else
            {
                gC.gerarClasse(lb_lista_propriedade);
                return;
            }
        }

        private void btn_path_Click(object sender, EventArgs e)
        {
            string ProjetoSelecionado;
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Selecione a pasta";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string pasta = dialog.SelectedPath;

                    tb_path.Text = pasta;

                    //Busca todos os .csproj (incluindo subpastas)
                    string[] projetos = Directory.GetFiles(
                        pasta,
                        "*.csproj",
                        SearchOption.AllDirectories
                    );

                    //Limpa o ComboBox
                    cb_path.Items.Clear();

                    //Verifica se encontrou algo
                    if (projetos.Length == 0)
                    {
                        MessageBox.Show("Nenhum projeto encontrado!");
                        return;
                    }

                    //Adiciona no ComboBox
                    foreach (string proj in projetos)
                    {
                        cb_path.Items.Add(proj);
                    }

                    AjustarLarguraComboBox(); //Ajusta a largura do dropdown automaticamente para mostrar o caminho completo

                    //Seleciona o primeiro automaticamente
                    cb_path.SelectedIndex = 0;
                    if (cb_path.SelectedItem != null)
                    {
                        ProjetoSelecionado = cb_path.SelectedItem.ToString();
                        gC.setCaminhoProjeto(ProjetoSelecionado);
                    }
                }
            }
        }

        private void tb_path_TextChanged(object sender, EventArgs e)
        {
            tb_path.ReadOnly = true;
        }

        private void cb_path_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_path.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cb_path_MouseHover(object sender, EventArgs e)
        {
            if (cb_path.SelectedItem != null)
            {
                toolTip1.SetToolTip(cb_path, cb_path.SelectedItem.ToString());
            }
        }
        private void AjustarLarguraComboBox()
        {
            int largura = cb_path.DropDownWidth;

            using (Graphics g = cb_path.CreateGraphics())
            {
                foreach (var item in cb_path.Items)
                {
                    int larguraItem = (int)g.MeasureString(item.ToString(), cb_path.Font).Width;

                    if (larguraItem > largura)
                        largura = larguraItem;
                }
            }

            cb_path.DropDownWidth = largura;
        }
    }
}
