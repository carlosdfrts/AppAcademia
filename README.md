# App Academia

Este é um aplicativo para **gestão de academias de musculação**, desenvolvido em **C#** no **Visual Studio 2022** utilizando a plataforma **.NET** e banco de dados **SQLite**.  
O programa permite gerenciar alunos, professores, turmas e usuários de forma integrada, facilitando a organização e o controle da academia.

## Requisitos
   • Visual Studio 2022  
   • .NET 6.0 ou superior  
   • SQLite  

## Autenticação e Níveis de Acesso
Ao abrir o programa, será exibida uma tela de **Login**, onde o usuário deve informar suas credenciais.  
Dependendo do nível de acesso, diferentes funcionalidades ficam disponíveis no sistema:

- **0 = Visitante:** acesso limitado, apenas para visualização.  
- **1 = Usuário/Aluno:** pode consultar suas informações pessoais e turmas.  
- **2 = Gerente:** possui permissões para gerenciar turmas, alunos e professores.  
- **3 = Administrador:** acesso total ao sistema, incluindo funções de manutenção e gerenciamento de usuários.  

## Como Usar
1. Clonar o repositório

- git clone https://github.com/carlosdfrts/AppAcademia.git

2. Abra a solução no Visual Studio 2022 (ou superior).

3. Restaurar dependências
O projeto utiliza o SQLite via NuGet.
As dependências são restauradas automaticamente ao abrir o projeto, mas, se necessário:

- Vá em Tools > NuGet Package Manager > Manage NuGet Packages for Solution...

- Verifique se o pacote System.Data.SQLite.Core está instalado.

4. Banco de dados

- O arquivo bancoAcademia.db já está incluído no repositório, ele será copiado automaticamente para a pasta bin quando o projeto for compilado.
• Você não precisa configurar caminhos manuais, apenas garantir que o arquivo está no repositório.

5. Compilar e executar

- Certifique-se de que a plataforma de destino do projeto está configurada como x64 (em Project > Properties > Build > Platform target).

- Pressione F5 para compilar e rodar.

5. Funcionalidades principais

- Cadastrar alunos, professores, turmas e usuários.

- Vincular alunos a turmas e professores.

- Consultar, editar e excluir registros.

- Navegar pelas interfaces criadas com foco em usabilidade.

- Gerenciar de forma simples e prática as informações da academia.

## Funcionalidades

O sistema oferece diversas funcionalidades para auxiliar no gerenciamento da academia, incluindo:

• Cadastro e gerenciamento de alunos, professores, turmas e usuários.  

• Relacionamento entre entidades (ex.: vincular aluno a professor e turma).  

• Armazenamento de dados com **SQLite**.  

• Interfaces criadas com boas práticas de usabilidade.  

Essas funcionalidades tornam o sistema uma solução prática para academias de pequeno e médio porte.

## Contribuição

Contribuições são bem-vindas!  
Se você encontrar bugs, tiver ideias de melhorias ou quiser implementar novos recursos, sinta-se à vontade para abrir uma issue ou enviar um pull request.
