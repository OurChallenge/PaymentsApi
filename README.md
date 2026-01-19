💳 FIAP Cloud Games – Payment API

.NET 8 | Entity Framework Core | SQL Server | JWT | Swagger

📌 Sobre o Projeto

A Payment API é responsável pelo processamento e registro de pagamentos da plataforma FIAP Cloud Games (FCG).
Ela controla o fluxo de compra de jogos, garantindo que as transações sejam registradas corretamente e associadas aos usuários.

🎯 Funcionalidades

Criação de pagamentos

Simulação de pagamento aprovado ou recusado

Registro de transações

Consulta de histórico de pagamentos do usuário

Integração com Users API

Integração com Catalog API

Persistência com Entity Framework Core

🏗️ Arquitetura

Backend: .NET 8 (Web API)

Banco de Dados: SQL Server

ORM: Entity Framework Core

Autenticação: JWT

Documentação: Swagger

📂 Estrutura do Projeto
Payment.API
├── Controllers
├── Domain
│   ├── Entities
│   ├── Enums
│   └── Interfaces
├── Application
│   ├── DTOs
│   ├── Services
│   └── UseCases
├── Infrastructure
│   ├── Context
│   ├── Repositories
│   └── Integrations
├── Migrations
├── Program.cs
└── appsettings.json

🔄 Fluxo de Pagamento

Usuário autenticado solicita a compra

API valida o usuário

API consulta o jogo no Catalog API

Pagamento é processado (simulado)

Transação é registrada

Compra é confirmada

🐳 Docker – Banco de Dados
docker compose up -d

🗄️ Entity Framework
dotnet ef database update

🔑 JWT Authentication
dotnet user-secrets set "Jwt:Key" "sua-chave-256-bits"

▶️ Executando a API
dotnet run


Swagger:

https://localhost:{porta}/swagger

🔐 Segurança

Todas as rotas exigem autenticação

Usuário só pode acessar seus próprios pagamentos

Token JWT validado a cada requisição

🔗 Integrações

Users API: autenticação e identificação do usuário

Catalog API: validação do jogo adquirido