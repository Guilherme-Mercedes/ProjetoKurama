# README do Projeto Kurama

---

## Sobre o Projeto

**Kurama** é um sistema de gerenciamento de aluguel de periféricos criado durante meu curso técnico em Desenvolvimento de Sistemas na Etec.  
O projeto foi desenvolvido em C# com banco de dados MySQL e tem como objetivo permitir que funcionários façam o cadastro, gerenciamento e aluguel de periféricos, enquanto os usuários têm acesso restrito apenas para alugar os itens.

---

## Contexto e Funcionalidades

- Funcionários podem cadastrar novos usuários, cadastrar periféricos, realizar vendas e aluguéis.  
- Usuários comuns podem acessar o sistema para realizar o aluguel dos periféricos disponíveis.  
- Autenticação por usuário e senha para controlar acessos.  
- Interface desktop construída com Windows Forms (WinForms).  
- Banco de dados MySQL para armazenamento dos dados.  

---

## Estrutura do Projeto

- **Kurama (Projeto Principal):**  
  Código principal do sistema com formulários WinForms para interação do usuário.

- **DAOMysql.dll (DLL criada por mim):**  
  Biblioteca que encapsula toda a conexão com o banco de dados MySQL, abstraindo os comandos SQL e facilitando as operações CRUD.

- Utilização da API oficial do MySQL para .NET (`MySql.Data.MySqlClient`).

---

## Tecnologias Utilizadas

- Linguagem: C#  
- Banco de Dados: MySQL  
- Interface: Windows Forms (WinForms)  
- Biblioteca de acesso a dados: DLL própria usando API MySQL oficial

---

## Estrutura da DLL DAOMysql

- A DLL contém uma classe `DAOMysql` que gerencia:  
  - A conexão com o banco via `MySqlConnection`.  
  - Métodos para executar queries de seleção (`SelectLogin`, `SelectPeriferico`, etc.).  
  - Tratamento básico de exceções.

- Essa DLL não é uma API web, mas sim uma biblioteca local para ser usada dentro do projeto.

---

## Considerações Técnicas e de Evolução

- Atualmente, o sistema abre formulários usando `Show()` e oculta (`Hide()`) o formulário atual.  
- Para melhorar a gestão de janelas e consumo de memória, a estratégia será migrar para usar `Show()` seguido de `Close()` para fechar janelas antigas que não são mais necessárias.  
- A nomenclatura dos controles foi alinhada ao padrão da comunidade: prefixo em minúsculo (`btnAdicionar`, `txtNome`, etc.) e métodos em PascalCase (`BtnAdicionar_Click`).  
- A arquitetura será aprimorada para separar camadas e modularizar o código, por exemplo, transferindo funções de negócio para classes específicas.  
- Planejo criar documentação e comentários mais detalhados para facilitar manutenção e expansão do sistema.

---

## Propostas Futuras

- Continuar a evoluir e melhorar o codigo.
- Mudar o layout e deixar mais bonito.
- Transformar a DLL local em uma verdadeira API REST para comunicação via rede, facilitando a expansão do sistema.  
- Implementar controle de acesso mais granular (separando funcionalidades de funcionário e usuário).  
- Melhorar a interface, adotando componentes modernos e responsivos.  
- Organizar o fluxo de navegação dos formulários para evitar janelas ocultas que consumam memória.  
- Refatorar o código para seguir boas práticas de engenharia de software, como SOLID, injeção de dependências e tratamento de exceções.  
- Adicionar testes unitários e de integração.

---

## Histórico

- Projeto originalmente desenvolvido em 2019 para o curso técnico na Etec.  
- Baseado no uso de DLL para abstração do banco e WinForms para interface.  
- Projeto está em fase de reestruturação e melhoria contínua.

---

## Como Rodar

1. Configurar banco MySQL local ou via container Docker.  
2. Atualizar string de conexão na DLL DAOMysql conforme ambiente (exemplo: localhost, usuário e senha).  
3. Abrir solução no Visual Studio e compilar os projetos.  
4. Executar o projeto Kurama, que referencia a DLL para manipular os dados.

---

## Contato

Desenvolvido por Guilherme Souza Mercedes — buscando sempre evolução e aprendizado constante.

