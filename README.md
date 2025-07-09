# 🖥️ Projeto Kurama - Sistema de Gestão de Periféricos

**Kurama** é um sistema de gerenciamento de aluguel de periféricos criado durante meu curso técnico em Desenvolvimento de Sistemas na Etec em 2019. Este projeto é um sistema desktop em C# com Windows Forms voltado para o gerenciamento de periféricos de informática, com funcionalidades de cadastro, alteração, remoção, aluguel e venda de itens. O sistema também possui controle de funcionários, login seguro e persistência de dados em banco MySQL, enquanto os usuários têm acesso restrito apenas para alugar os itens.

## 📁 Estrutura do Projeto

- `ProjetoJe/` – Aplicação principal Windows Forms
- `DAOMysql/` – Projeto de biblioteca de acesso a dados (DLL)
- `BancoPeriferico.sql` – Script de criação das tabelas no banco de dados

## 🔧 Tecnologias Utilizadas

- C# (.NET Framework)
- Windows Forms
- MySQL
- MySql.Data Connector (API)
- Docker (opcional, para rodar banco MySQL localmente)
- Programação Orientada a Objetos (POO)
- Arquitetura em camadas (Interface + DLL de acesso a dados)

## 📦 Funcionalidades Principais

### 🧑‍💼 Funcionalidades para Funcionário
- Login de funcionários com verificação no banco
- Cadastro de novos funcionários
- Edição e remoção de funcionários
- Listagem de usuários em DataGridView

### 🖱️ Periféricos
- Cadastro com nome, modelo, marca, ano, valores de venda/aluguel e garantia
- Alteração e remoção
- Atualização automática de status (disponível/indisponível)
- Visualização geral dos periféricos cadastrados

### 🛒 Vendas
- Realização de vendas com valor do periférico puxado do banco
- Armazenamento de dados do cliente e do periférico
- Histórico de vendas

### 📆 Aluguel
- Cálculo automático de valor total com base em dias alugados
- Exibição da data prevista para devolução
- Histórico de aluguéis
- Atualização automática do status do periférico

## 🗂️ DLL: `DAOMysql`

A DLL foi criada por mim com o objetivo de isolar a camada de acesso a dados da lógica da interface e fazer a conexao com a API do Mysql.

## 🗂️ API: `MySQL API OFICIAL`

Utilização da API oficial do MySQL para .NET (`MySql.Data.MySqlClient`).

Principais métodos:

- `InserirFuncionario(...)`
- `AlterarFuncionario(...)`
- `CadastrarPeriferico(...)`
- `AlterarPeriferico(...)`
- `AtualizarStatusPeriferico(...)`
- `AlugarPeriferico(...)`
- `VenderPeriferico(...)`
- `FazerLogin(...)`
- Métodos de remoção e seleção (`Select*` e `Remover*PorId`)

Todas as operações usam `MySqlCommand` com parâmetros para evitar SQL Injection.

## 🗃️ Banco de Dados

**Nome:** `BancoPeriferico`

Contém as seguintes tabelas:

- `funcionarios`
- `perifericos`
- `alugueis`
- `vendas`

Todas com chaves primárias e estrangeiras corretamente definidas. Campos de valor monetário utilizam `DECIMAL(10,2)` para evitar erros com formatação numérica.

## 🐳 Usando com Docker (Banco MySQL)

```bash
docker run -d --name mysql-dev -e MYSQL_ROOT_PASSWORD=1234 -p 3306:3306 mysql:8.0
```

Depois, use o script SQL disponível no projeto para criar as tabelas:

```bash
docker exec -i mysql-dev mysql -u root -p1234 < BancoPeriferico.sql
```

## 📌 Observações

- O sistema usa `decimal.Parse` com `CultureInfo.InvariantCulture` para valores monetários.
- Foram criadas funções utilitárias para validação de campos e limpeza de formulário.
- O código foi modularizado para facilitar manutenção e reuso.

## Propostas Futuras

- Continuar a evoluir e melhorar o codigo.
- Mudar o layout e deixar mais bonito.
- Transformar a DLL local em uma verdadeira API REST para comunicação via rede, facilitando a expansão do sistema.  
- Implementar controle de acesso mais granular (separando funcionalidades de funcionário e usuário).  
- Melhorar a interface, adotando componentes modernos e responsivos.  
- Organizar o fluxo de navegação dos formulários para evitar janelas ocultas que consumam memória.  
- Refatorar o código para seguir boas práticas de engenharia de software, como SOLID, injeção de dependências e tratamento de exceções.  
- Adicionar testes unitários e de integração.

## Histórico

Este projeto foi originalmente desenvolvido como trabalho final de Lógica de Programação no meu curso de Tecnico de Desenvolvimento de Sistemas na ETEC. Na época, utilizei conceitos que aprendi durante as aulas e também busquei referências na internet para complementar o desenvolvimento. Por conta do prazo curto e da minha experiência limitada naquele momento, o código não seguiu uma estrutura muito limpa, algo que hoje consigo identificar com mais clareza.

Ao revisitar o projeto, percebi que seria necessário refatorá-lo para torná-lo mais organizado, legível e de fácil manutenção. Confesso que quebrei um pouco a cabeça para entender a lógica que eu mesmo havia feito, mas com paciência e os conhecimentos adquiridos ao longo da minha formação, consegui reestruturá-lo de forma mais sólida.

Hoje, o projeto está reformulado, com aplicação de boas práticas, o que facilita futuras melhorias e manutenções. Ainda vejo espaço para evolução e pretendo continuar aprimorando este código com o tempo conforme novas ideias e aprendizados forem surgindo.


## 📬 Contato

Feito com 💻 por Guilherme Mercedes.  
[LinkedIn](https://www.linkedin.com/in/guilhermemercedes/) • [GitHub](https://github.com/Guilherme-Mercedes)


