using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace GeradorClasse
{
    class GeradorClasse
    {
        private string nomeClasse;
        private string propriedades;
        private string caminhoProjeto;

        public void setNomeClasse(string _nomeClasse) { nomeClasse = _nomeClasse; }
        public void setPropriedades(string _propriedades) { propriedades = _propriedades; }
        public void setCaminhoProjeto(string _caminhoProjeto) { caminhoProjeto = _caminhoProjeto; }

        public string getNomeClasse() { return nomeClasse; }
        public string getPropriedades() { return propriedades; }
        public string getCaminhoProjeto() { return caminhoProjeto; }


        public void gerarClasse(ListBox listaProp)
        {
            StringBuilder codigo = new StringBuilder();
            codigo.AppendLine("using System;");
            codigo.AppendLine("using System.Collections.Generic;");
            codigo.AppendLine("using System.Linq;");
            codigo.AppendLine("using System.Text;");
            codigo.AppendLine("using System.Threading.Tasks;");
            codigo.AppendLine("");
            codigo.AppendLine("namespace " + Path.GetFileNameWithoutExtension(caminhoProjeto));
            codigo.AppendLine("{");
            codigo.AppendLine("class " + nomeClasse.Substring(0, 1).ToUpper() + nomeClasse.Substring(1));
            codigo.AppendLine("{");

            foreach (string propriedades in listaProp.Items)
            {
                codigo.AppendLine("    private string " + propriedades.Substring(0, 1).ToLower() + propriedades.Substring(1) + ";");
                codigo.AppendLine("    public void set" + propriedades.Substring(0,1).ToUpper() + propriedades.Substring(1) + "(string _" + propriedades + ") { " + propriedades + " = _" + propriedades + "; }");
                codigo.AppendLine("    public string get" + propriedades.Substring(0, 1).ToUpper() + propriedades.Substring(1) + "() { return " + propriedades.Substring(0, 1).ToLower() + propriedades.Substring(1) + "; }");
                codigo.AppendLine(" ");
            }
            codigo.AppendLine("}");
            codigo.AppendLine("}");
            string classe = codigo.ToString();
            string pastaProjeto = Path.GetDirectoryName(caminhoProjeto);
            string caminhoArquivo = Path.Combine(pastaProjeto, nomeClasse + ".cs");
            File.WriteAllText(caminhoArquivo, classe);
            AdicionarArquivo(caminhoProjeto, nomeClasse + ".cs");
        }
        private void AdicionarArquivo(string caminhoProjeto, string nomeArquivo)
        {   
            XDocument doc = XDocument.Load(caminhoProjeto);

            XNamespace ns = doc.Root.Name.Namespace;

            XElement itemGroup = doc.Descendants(ns + "ItemGroup").FirstOrDefault();

            if (itemGroup == null)
            {
                itemGroup = new XElement(ns + "ItemGroup");
                doc.Root.Add(itemGroup);
            }

            // Verifica se já existe
            bool existe = doc.Descendants(ns + "Compile")
                .Any(x => x.Attribute("Include")?.Value == nomeArquivo);

            if (!existe)
            {
                XElement novo = new XElement(ns + "Compile");
                novo.SetAttributeValue("Include", nomeArquivo);

                itemGroup.Add(novo);

                doc.Save(caminhoProjeto);

                MessageBox.Show("Classe gerada e arquivo adicionado!");
            }
            else
            {
                MessageBox.Show("Arquivo já existe no projeto!");
            }
        }
    }
}
