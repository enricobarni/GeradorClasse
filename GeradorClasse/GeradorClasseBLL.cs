using ErroLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorClasse
{
    class GeradorClasseBLL
    {
        public static void validaDados(GeradorClasse classe)
        {
            Erro.setErro(false);
            if (string.IsNullOrEmpty(classe.getNomeClasse()) || string.IsNullOrEmpty(classe.getPropriedades()))
            {
                Erro.setErro("Todos os campos são obrigatórios!");
                return;
            }
            if (classe.getNomeClasse().Contains(" ") || classe.getPropriedades().Contains(" "))
            {
                Erro.setErro("O nome da classe e/ou propriedades não podem conter espaços!");
                return;
            }
            if (double.TryParse(classe.getNomeClasse(), out _) || double.TryParse(classe.getPropriedades(), out _))
            {
                Erro.setErro("O nome da classe e/ou propriedades não podem ser números!");
                return;
            }
        }
    }
}
