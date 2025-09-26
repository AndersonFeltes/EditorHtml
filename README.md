# 📝 Editor HTML em C#

Este é um projeto simples em **C#** de um editor de HTML para console.  
O objetivo é permitir que o usuário escreva textos, edite, salve em arquivo `.html` e visualize no terminal com formatação básica.

---

## 🚀 Funcionalidades

- Modo editor para escrever textos diretamente no console.
- Salvar arquivos em disco (`.html` ou `.txt`).
- Abrir arquivos já existentes.
- Exibir conteúdo formatado no terminal (com destaque para tags `<strong>`).
- Menu interativo para navegar entre as opções.

---

## 📂 Estrutura do Projeto

EditorHtml/
├── Program.cs
├── Menu.cs
├── Editor.cs
|── README.md

yaml
Copiar código

- **Program.cs** → Ponto de entrada da aplicação.
- **Menu.cs** → Exibe e gerencia o menu principal.
- **Editor.cs** → Contém a lógica de edição, salvamento e leitura de arquivos.

---

## 🖥️ Como usar

1. Clone este repositório ou baixe os arquivos.
2. Compile o projeto:
   ````bash
   dotnet build
   Execute a aplicação:
   ```bash
   dotnet run
   ````

[1] Abrir arquivo

[2] Novo arquivo

[0] Sair

💾 Salvando arquivos
Ao escolher salvar, será solicitado um caminho completo.

Exemplo válido:

Copiar código
C:\Users\SeuUsuario\Documents\meuarquivo.html
⚠️ Atenção: É obrigatório informar o nome do arquivo e a extensão (.html ou .txt).

🔧 Tecnologias
Linguagem: C#

SDK: .NET 6 ou superior

📜 Licença
Este projeto foi desenvolvido para fins de estudo e prática em C#.
Você pode utilizá-lo e modificá-lo livremente.
