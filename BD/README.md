# 📊 Modelagem Conceitual do Banco de Dados

## 📌 Descrição
Este projeto tem como objetivo realizar a modelagem conceitual de um banco de dados, representando as principais entidades do sistema e seus relacionamentos por meio de um Diagrama Entidade-Relacionamento (DER).

A modelagem permite visualizar a estrutura do sistema antes da implementação, facilitando o entendimento, organização e manutenção do banco de dados.

---

## 🎯 Objetivo
- Identificar as entidades do sistema  
- Definir seus atributos  
- Estabelecer os relacionamentos entre elas  
- Representar tudo de forma visual utilizando DER  

---

## 🧱 Entidades Identificadas
Com base no diagrama elaborado:

- Escola  
- Usuário  
- Relatório Escola  
- Relatório Mensal  
- Compras  
- Pacotes  
- Jogos  

---

## 🔗 Relacionamentos

- **Escola → Usuário**  
  Uma escola possui usuários  

- **Escola → Relatório Escola**  
  A escola gera relatórios gerais  

- **Escola → Relatório Mensal**  
  A escola gera relatórios mensais  

- **Escola → Compras**  
  A escola realiza compras  

- **Compras → Pacotes**  
  Compras adquirem pacotes  

- **Pacotes → Jogos**  
  Pacotes incluem jogos  

---

## 🧾 Principais Atributos

### Escola
- nome  
- cnpj  
- email  
- acessos totais  
- acessos restantes  

### Usuário
- nome  
- RA  
- senha  

### Relatório Escola
- créditos restantes  
- total de acessos  
- porcentagem de utilização  
- pontuações  

### Relatório Mensal
- data  
- acessos adquiridos  
- acessos utilizados  
- créditos restantes  

### Compras
- data da compra  
- créditos comprados  
- créditos restantes  

### Pacotes
- nome do pacote  
- jogos inclusos  
- preço  

### Jogos
- nome  
- tipo  
- faixa etária  
- descrição  

---

## 📐 Diagrama Entidade-Relacionamento (DER)

O DER representa graficamente:
- entidades (retângulos)  
- atributos (ovais)  
- relacionamentos (losangos)  

Ele mostra como os dados estão conectados e como o sistema funciona logicamente.

---

## 💡 Importância da Modelagem

A modelagem conceitual é essencial porque:
- evita erros na criação do banco  
- melhora a organização dos dados  
- facilita futuras alterações  
- serve como documentação do sistema  

---

## 📎 Conclusão

Através do DER, foi possível estruturar o banco de dados de forma clara e organizada, garantindo uma base sólida para o desenvolvimento do sistema.