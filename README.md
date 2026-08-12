# TelaLoginCrud

Sistema desenvolvido em ASP.NET Core MVC utilizando a linguagem C# e o padrão arquitetural Model-View-Controller (MVC).

O projeto consiste em um sistema de gerenciamento de **Vendas** integrado ao **ASP.NET Core Identity**, fornecendo controle de autenticação, autorização de usuários, telas de login/registro e gerenciamento de conta, com interface moderna e responsiva em Dark Mode.

## Tecnologias Utilizadas

- C#
- .NET
- ASP.NET Core MVC
- ASP.NET Core Identity
- SQL Server
- Entity Framework Core
- Bootstrap 5
- jQuery

## Pacotes Utilizados

O projeto utiliza os seguintes pacotes NuGet:
- `Microsoft.VisualStudio.Web.CodeGeneration.Design`

## Banco de Dados

O banco de dados foi desenvolvido utilizando o SQL Server.
A criação da estrutura do banco — incluindo as tabelas de dados do sistema e as tabelas de autenticação do Identity — foi realizada através da abordagem **Code First**, utilizando Migrations do Entity Framework Core.

## Funcionalidades

- **Autenticação e Autorização:**
  - Login e Logout de usuários
  - Registro de novos usuários
  - Gerenciamento de perfil e dados da conta (Identity)
  - Controle de acesso a rotas do sistema
- **Gerenciamento de Vendas (CRUD):**
  - Cadastro de novas vendas
  - Listagem de vendas registradas (Produto, Quantidade, Preço e Data)
  - Edição de registros
  - Exclusão de registros
  - Detalhamento de vendas
- **Interface:**
  - Layout totalmente adaptado para Dark Mode
  - Design responsivo e amigável

## Interface

A interface foi desenvolvida utilizando:
- Bootstrap 5
- Razor Views / Razor Pages (Identity)
- CSS3 Personalizado (Dark Mode)
- jQuery

### Telas do Sistema

#### Tela Inicial (Welcome)
![Tela Inicial](TelaLoginCrud/TelaLoginCrud/imagem/Captura de tela 2026-08-12 101526.png)

#### Listagem de Vendas
![Lista de Vendas](TelaLoginCrud/TelaLoginCrud/imagem/Captura de tela 2026-08-12 101532.png)

#### Gerenciamento de Perfil (Identity)
![Gerenciamento de perfis](TelaLoginCrud/TelaLoginCrud/imagem/Captura de tela 2026-08-12 102428.png)

## Como Executar o Projeto

1. **Clone o repositório**
   ```bash
   git clone https://github.com/00BielSilva/TelaLoginCrud.git
   ## Abra a solução

Abra o projeto utilizando o **Visual Studio 2022**.

## Configure a conexão

Edite o arquivo:

```
appsettings.json
```

Configurando a string de conexão para o seu SQL Server.

## Execute as Migrations

No Console do Gerenciador de Pacotes execute:

```powershell
Update-Database
```

Ou utilize o .NET CLI:

```bash
dotnet ef database update
```

## Execute o projeto

Pressione **F5** ou clique em **Iniciar** no Visual Studio.

---
# Estrutura do Projeto
TelaLoginCrud
 ├── Areas
 │   └── Identity
 ├── Controllers
 ├── Models
 ├── Views
 ├── Data
 ├── Migrations
 ├── wwwroot
 └── Program.cs
 
# Desenvolvido com

- ASP.NET Core MVC
- ASP.NET Core Identity
- C#
- SQL Server
- Entity Framework Core
- Bootstrap
- jQuery

---

# Autores

### Desenvolvedor

**Gabriel Silva de Almeida Ferreira**

### Professor

**Wallace Oliveira dos Santos**
