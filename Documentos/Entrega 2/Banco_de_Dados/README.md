# 📊 Modelagem Lógica do Banco de Dados

## 📌 Descrição
Este projeto tem como objetivo realizar a modelagem lógica de um banco de dados para uma plataforma educacional gamificada, representando as entidades do sistema, seus atributos, chaves e relacionamentos.

A modelagem lógica permite estruturar como os dados serão organizados dentro do banco relacional, facilitando a implementação, manutenção e integridade das informações.

---

## 🎯 Objetivo
- Definir as tabelas do sistema  
- Estruturar atributos e chaves primárias  
- Estabelecer chaves estrangeiras  
- Representar os relacionamentos entre as entidades  
- Organizar o banco de forma lógica e relacional  

---

## 🧱 Entidades Identificadas
Com base no modelo lógico elaborado:

- Escola  
- Usuário  
- Relatório Escola  
- Relatório Messier  
- Compras  
- Pacotes  
- Jogos  
- adquiri  
- inclui  

---

## 🔗 Relacionamentos

- **Usuário → Escola**  
  Um usuário pode estar associado a uma ou mais escolas  

- **Escola → Relatório Escola**  
  Uma escola possui relatórios gerais  

- **Escola → Relatório Messier**  
  Uma escola possui relatórios administrativos  

- **Escola → Compras**  
  Uma escola pode realizar várias compras  

- **Compras → Pacotes**  
  Compras adquirem pacotes  

- **Pacotes → Jogos**  
  Pacotes incluem jogos  

- **Tabela adquiri**  
  Relaciona compras e pacotes  

- **Tabela inclui**  
  Relaciona pacotes e jogos  

---

## 🧾 Principais Atributos

### Escola
- nome  
- cnpj  
- email  
- acessos_totais  
- acessos_restantes  
- FK_USUARIO_RA  

### Usuário
- nome  
- RA  
- senha  

### Relatório Escola
- creditos_restantes  
- total_de_acessos  
- porcentagem_utilizacao  
- pontuacoes_turma  
- pontuacoes_aluno  
- lista_usuarios  

### Relatório Messier
- total_creditos_escola  
- creditos_utilizados  
- pacotes_adquiridos  
- data_atualizacao  
- creditos_restantes  

### Compras
- id_escola  
- id_pacote  
- data_compra  
- creditos_comprados  
- creditos_restantes  

### Pacotes
- nome_pacote  
- descricao_pacote  
- qtde_acessos  
- preco  
- jogos_inclusos  

### Jogos
- nome  
- descricao  
- tipo  
- faixa_etaria  

---

## 📐 Modelo Lógico

O modelo lógico representa:
- tabelas do banco de dados  
- atributos das entidades  
- chaves primárias (PK)  
- chaves estrangeiras (FK)  
- cardinalidades dos relacionamentos  

Ele mostra como os dados estão organizados dentro do sistema relacional.

---

## 💡 Importância da Modelagem

A modelagem lógica é essencial porque:
- organiza corretamente os dados  
- reduz redundâncias  
- garante integridade referencial  
- facilita consultas SQL  
- melhora manutenção e escalabilidade do sistema  
- serve como documentação técnica do banco de dados  
