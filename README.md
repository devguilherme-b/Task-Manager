# API para gerenciamento de tarefas

Resolução do Desafio 3 do módulo de Arquitetura em Camadas do curso de Formação em C# (CSharp) pela [Rocketseat](https://github.com/rocketseat-education).

## 📌 Sumário

- [Sobre](#sobre)
- [Tecnologias Utilizadas](#tecnologias-utilizadas)
- [Como Utilizar](#como-utilizar)
- [Contato](#contato)

## Sobre

Este projeto é uma API para gerenciamento de tarefas, construída durante o módulo de **Arquitetura em Camadas no .NET** da trilha de C# da Rocketseat.

Neste desafio, iniciei a prática de princípios do S.O.L.I.D., com foco no **S - Single Responsibility Principle** (Princípio da Responsabilidade Única), aplicando boas práticas como:

- Criação de camadas bem definidas:
  - **TaskManager.API** – Responsável pela inicialização da aplicação e exposição dos endpoints.
  - **TaskManager.Communication** – Camada de contratos e modelos de requisição/resposta (DTOs) e Enums utilizados pela API.
  - **TaskManager.Application** – Camada de regras de negócio, onde a lógica é aplicada. Esta é organizada em pastas por operação, cada uma contendo apenas a classe responsável por um único endpoint (exemplo: POST → pasta com uma classe para registrar tarefas).
  
- Retorno de **Status Codes apropriados**, conforme o tipo de operação e resposta.
- Organização e modularização que tornam a aplicação mais escalável, testável e fácil de manter.

Este é apenas o início da aplicação dos conceitos de arquitetura limpa, focando em estruturação e separação de responsabilidades dentro de um sistema real.

## Tecnologias Utilizadas

- C# (CSharp)
- .NET 8
- ASP.NET Core
- Visual Studio 2022+

## Como Utilizar

Para rodar os desafios localmente, siga os passos abaixo:

1. Clone este repositório:
   ```bash
   git clone https://github.com/devguilherme-b/Task-Manager.git
   ```
2. Acesse o diretório do projeto:
   ```bash
   cd Task-Manager
   ```
3. Abra o projeto no Visual Studio ou outro editor de sua preferência.
4. Execute os desafios conforme a necessidade.


## Contato

Caso tenha dúvidas, sugestões ou queira se conectar, entre em contato através das redes abaixo:

- 📧 Email: [dev.guilhermebarbos@gmail.com](mailto:dev.guilhermebarbos@gmail.com)
- 📸 Instagram: [@dev.guilhermee](https://www.instagram.com/dev.guilhermee)
- 💼 LinkedIn: [Guilherme Barbosa](https://www.linkedin.com/in/devguilhermebarbosa/)

---

⚡ _Feito com dedicação por Guilherme Barbosa. 🚀_
