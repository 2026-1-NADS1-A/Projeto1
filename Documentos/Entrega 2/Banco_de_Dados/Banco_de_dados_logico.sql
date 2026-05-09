/* Banco_de_dados_logico: */

CREATE TABLE ESCOLA (
    nome VARCHAR2(100),
    cnpj VARCHAR2(14) PRIMARY KEY,
    email VARCHAR2(100),
    acessos_totais INT,
    acessos_restantes INT,
    FK_USUARIO_RA VARCHAR2(20)
);

CREATE TABLE USUARIO (
    nome VARCHAR2(100),
    RA VARCHAR2(20) PRIMARY KEY,
    senha VARCHAR2(100)
);

CREATE TABLE PACOTES (
    nome_pacote VARCHAR2(100) PRIMARY KEY,
    descricao_pacote VARCHAR2(150),
    qtde_acessos INT,
    preco DECIMAL(10,2),
    jogos_inclusos VARCHAR2(150)
);

CREATE TABLE COMPRAS (
    id_escola INT PRIMARY KEY,
    id_pacote INT,
    data_compra DATE,
    creditos_comprados INT,
    creditos_restantes INT,
    FK_ESCOLA_cnpj VARCHAR2(14)
);

CREATE TABLE JOGOS (
    nome VARCHAR2(100),
    descrica VARCHAR2(150),
    tipo VARCHAR2(100),
    faixa_etaria VARCHAR2(50),
    ID VARCHAR2(100) PRIMARY KEY
);

CREATE TABLE RELATORIO_MESSIER (
    total_creditos_escola INT,
    creditos_utilizados INT,
    pacotes_adquiridos INT,
    data_atualizacao DATE,
    creditos_restantes INT,
    ID VARCHAR2(100) PRIMARY KEY,
    FK_ESCOLA_cnpj VARCHAR2(14)
);

CREATE TABLE RELATORIO_ESCOLA (
    creditos_restantes INT,
    total_de_acessos INT,
    porcentagem_utilizacao DECIMAL(5,2),
    pontuacoes_turma INT,
    pontuacoes_aluno INT,
    lista_usuarios VARCHAR2(150),
    ID VARCHAR2(100) PRIMARY KEY,
    FK_ESCOLA_cnpj VARCHAR2(14)
);

CREATE TABLE adquiri (
    fk_COMPRAS_id_escola INT,
    fk_PACOTES_nome_pacote VARCHAR2(100)
);

CREATE TABLE inclui (
    fk_PACOTES_nome_pacote VARCHAR2(100),
    fk_JOGOS_ID VARCHAR2(100)
);
 
ALTER TABLE ESCOLA ADD CONSTRAINT FK_ESCOLA_2
    FOREIGN KEY (FK_USUARIO_RA)
    REFERENCES USUARIO (RA)
    ON DELETE RESTRICT;
 
ALTER TABLE COMPRAS ADD CONSTRAINT FK_COMPRAS_2
    FOREIGN KEY (FK_ESCOLA_cnpj)
    REFERENCES ESCOLA (cnpj)
    ON DELETE CASCADE;
 
ALTER TABLE RELATORIO_MESSIER ADD CONSTRAINT FK_RELATORIO_MESSIER_2
    FOREIGN KEY (FK_ESCOLA_cnpj)
    REFERENCES ESCOLA (cnpj)
    ON DELETE CASCADE;
 
ALTER TABLE RELATORIO_ESCOLA ADD CONSTRAINT FK_RELATORIO_ESCOLA_2
    FOREIGN KEY (FK_ESCOLA_cnpj)
    REFERENCES ESCOLA (cnpj)
    ON DELETE CASCADE;
 
ALTER TABLE adquiri ADD CONSTRAINT FK_adquiri_1
    FOREIGN KEY (fk_COMPRAS_id_escola)
    REFERENCES COMPRAS (id_escola)
    ON DELETE RESTRICT;
 
ALTER TABLE adquiri ADD CONSTRAINT FK_adquiri_2
    FOREIGN KEY (fk_PACOTES_nome_pacote)
    REFERENCES PACOTES (nome_pacote)
    ON DELETE SET NULL;
 
ALTER TABLE inclui ADD CONSTRAINT FK_inclui_1
    FOREIGN KEY (fk_PACOTES_nome_pacote)
    REFERENCES PACOTES (nome_pacote)
    ON DELETE RESTRICT;
 
ALTER TABLE inclui ADD CONSTRAINT FK_inclui_2
    FOREIGN KEY (fk_JOGOS_ID)
    REFERENCES JOGOS (ID)
    ON DELETE SET NULL;
