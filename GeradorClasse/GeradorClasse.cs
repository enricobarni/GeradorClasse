using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GeradorClasse
{
    class GeradorClasse
    {
        private string nomeClasse;
        private string propriedades;

        public void setNomeClasse(string _nomeClasse) { nomeClasse = _nomeClasse; }
        public void setPropriedades(string _propriedades) { propriedades = _propriedades; }

        public string getNomeClasse() { return nomeClasse; }
        public string getPropriedades() { return propriedades; }

        public static void gerarClasse(String nomeClasse, ListBox listaProp)
        {
            StringBuilder codigo = new StringBuilder();
            codigo.AppendLine("class " + nomeClasse.Substring(0, 1).ToUpper() + nomeClasse.Substring(1));
            codigo.AppendLine("{");

            foreach (string propriedades in listaProp.Items)
            {
                codigo.AppendLine("    private string " + propriedades + ";");
                codigo.AppendLine("    public void set" + propriedades.Substring(0,1).ToUpper() + propriedades.Substring(1) + "(string _" + propriedades + ") { " + propriedades + " = _" + propriedades + "; }");
                codigo.AppendLine("    public string get" + propriedades.Substring(0, 1).ToUpper() + propriedades.Substring(1) + "() { return " + propriedades + "; }");
                codigo.AppendLine(" ");
            }
            codigo.AppendLine("}");
            string downloads = Path.Combine(

    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
    "Downloads");
            string caminhoArquivo = Path.Combine(downloads, "Classe " + nomeClasse + ".txt");
            File.WriteAllText(caminhoArquivo, codigo.ToString());
        }
    }
}
