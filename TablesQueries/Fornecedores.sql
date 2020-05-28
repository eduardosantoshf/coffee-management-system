CREATE TABLE Fornecedores.Pessoa (
    NIF     INT             NOT NULL,
    nome    VARCHAR(30)     NOT NULL,

    PRIMARY KEY(NIF, nome),
);


CREATE TABLE Fornecedores.Fornecedor (
    NIF         INT             NOT NULL,
    telefone    INT             NOT NULL,
    nome        VARCHAR(30)     NOT NULL,
    email       VARCHAR(30),

    PRIMARY KEY(NIF),
    FOREIGN KEY(NIF,nome) REFERENCES Fornecedores.Pessoa(NIF,nome),
);


CREATE  TABLE Fornecedores.Armazem (
    morada              VARCHAR(30)     NOT NULL,
    telefone            INT             NOT NULL,
    Fnif                INT             NOT NULL,

    PRIMARY KEY(morada),
    FOREIGN KEY(Fnif) references Fornecedores.Fornecedor(NIF),
);


CREATE TABLE Fornecedores.Gerente (
    NIF     INT             NOT NULL,
    nome    VARCHAR(30)     NOT NULL,
    
    PRIMARY KEY(NIF),
    FOREIGN KEY(NIF,nome) REFERENCES Fornecedores.Pessoa(NIF,nome),
);


--DROP TABLE Fornecedores.Armazem;