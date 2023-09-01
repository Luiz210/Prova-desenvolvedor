# Prova-Desenvolvedor-Front-end
# Guia de Como abrir o Projeto 

## Requisitos

- Visual Studio 2022
- SQL Server
- Visual Studio Code (para o frontend)

## Configuração do Backend

1. Clone o repositório da API usando o Visual Studio 2022.

2. Certifique-se de ter o SQL Server instalado e crie um banco de dados.

3. No Visual Studio 2022, clique com o botão direito em "Connected Services" e escolha "Adicionar". Selecione "Banco de Dados do SQL Server".

4. Conecte-se ao servidor SQL fornecendo o nome do servidor e escolha a autenticação do Windows. Selecione o banco de dados criado anteriormente e confirme.

5. No arquivo `appsettings.json`, atualize a configuração `ServerConnection` com as informações do servidor SQL.

6. No Console de Gerenciador de Pacotes, execute os seguintes comandos: Add-Migration 'nomedamigration'
Update-Database

## Configuração do Frontend

## Link do Front-END:https://github.com/Luiz210/Prova-Desenvolvedor-Front-end

1. No Visual Studio Code, abra o projeto do frontend.

2. Instale a extensão "Live Server".

3. No arquivo `index.html`, clique com o botão direito e escolha "Open with Live Server" para visualizar o frontend.

