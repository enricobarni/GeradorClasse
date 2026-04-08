## 🏗️ Gerador de Classes - Automação & Arquitetura .NET
Este projeto é uma ferramenta de produtividade robusta desenvolvida em C# / Windows Forms. O sistema automatiza a criação de arquivos de classe (.cs) com encapsulamento completo e realiza a integração automática em projetos externos via manipulação de arquivos XML.

## 🎯 Objetivos de Aprendizado
O projeto foi estruturado para aplicar conceitos avançados de engenharia de software e automação de tarefas repetitivas:

 - Arquitetura em Camadas (BLL): Separação da lógica de negócio da interface visual, garantindo um código modular e testável.

 - Manipulação de IO Avançada: Uso da biblioteca System.IO para criação dinâmica de arquivos de código e edição de metadados.

 - Encapsulamento Automático: Geração programática de campos privados e métodos Getters e Setters.

 - UX com Windows Forms: Implementação de diálogos de sistema (FolderBrowserDialog) para seleção dinâmica de diretórios.

## 🧠 Desafios de Desenvolvimento
1. *Automação de Nomenclatura e Clean Code*
Um dos destaques do projeto é o tratamento rigoroso de strings. O sistema força boas práticas automaticamente:

 - Classes: Converte a primeira letra para maiúscula independentemente da entrada do usuário.

 - Propriedades/Atributos: Garante a formatação correta dos campos privados e parâmetros.

2. *Integração via XML*
Além de gerar o arquivo .cs, o projeto possui uma lógica complexa que localiza e edita arquivos de configuração XML de outros projetos. Isso permite que a nova classe seja "reconhecida" ou registrada automaticamente em sistemas de terceiros, eliminando a configuração manual.

3. *Validação e Segurança (BLL)*
A camada GeradorClasseBLL foi desenvolvida para atuar como uma barreira de segurança, validando todos os inputs do usuário e tratando possíveis exceções antes que elas cheguem ao sistema de arquivos, evitando corrupção de dados ou erros de execução.

## 💻 Destaque Técnico
O motor de geração produz classes prontas para uso, seguindo o padrão clássico de encapsulamento:

C#
namespace ProjetoExemplo
{
    class Futebol
    {
        private string jogadores;
        public void setJogadores(string _jogadores) { jogadores = _jogadores; }
        public string getJogadores() { return jogadores; }
        
        // Atributos e métodos gerados automaticamente...
    }
}
## 🛠️ Estrutura do Projeto
A solução foi organizada seguindo padrões de mercado para separação de conceitos:

 - GeradorClasseHM.cs: Camada de interface (Windows Forms) e interação com o usuário.

 - GeradorClasseBLL.cs: Camada de Lógica de Negócio (Business Logic Layer), onde residem as validações.

 - GeradorClasse.cs: Modelo de dados e motor principal de geração de strings.

 - Program.cs: Ponto de entrada da aplicação.

## 🚀 Como Executar o Projeto
*Pré-requisitos*

 - Visual Studio (com carga de trabalho de desenvolvimento para desktop .NET).

 - .NET Framework compatível.

1. *Instalação e Uso*
1. **Clone o repositório:**

```
Bash
git clone https://github.com/enricobarni/GeradorClasse.git
```

2. **Abra o arquivo .sln no Visual Studio.**

3. **Execute o projeto (F5).**

4. **Na interface:**

 - Defina o nome da classe e seus atributos.

 - Utilize o botão de busca para selecionar o diretório de destino através do FolderBrowserDialog.

 - Clique em gerar para criar o arquivo .cs e atualizar os registros XML.

----------------------------------------------------------------------------

Desenvolvido por enricobarni como parte da jornada de aprendizado em arquitetura de sistemas e automação.
