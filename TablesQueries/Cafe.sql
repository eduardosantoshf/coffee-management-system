--create Schema Cafes;
/*
create table Cafes.Cafe(
    NIF	int not null,
    nome	varchar(30) not null,
    morada	varchar(30) not null,
    primary key(NIF,nome,morada)
);
create table Cafes.Pessoa(
    NIF int not null,
    nome    varchar(30) not null,
    primary key(NIF,nome),
);
create table Cafes.Empregado(
    NIF int not null,
    NIF_cafe    int not null,
    idade   int not null,
    nome    varchar(30) not null,
    data_inic_contrato  date not null,
    primary key(NIF),
    foreign key(NIF,nome) references Cafes.Pessoa(NIF,nome),
    foreign key(NIF_cafe) references Cafes.Cafe(NIF)
);
create table Cafes.Cliente(
    NIF int not null,
    nome    varchar(30) not null,
    no_mesa int,
    primary key(NIF),
    foreign key(NIF,nome) references Cafes.Pessoa(NIF,nome)
);
create table Cafes.Cafe_Restaurante (
    NIF	int not null,
    nome	varchar(30) not null,
    morada	varchar(30) not null,
    no_almocos  int,
    primary key(NIF),
    foreign key(NIF,nome,morada) references Cafes.Cafe(NIF,nome,morada)
);
create table Cafes.Cozinheiro(
    NIF int not null,
    NIF_cafeR    int not null,
    idade   int not null,
    nome    varchar(30) not null,
    data_inic_contrato  date not null,
    primary key(NIF),
    foreign key(NIF,nome) references Cafes.Pessoa(NIF,nome),
    foreign key(NIF_cafeR) references Cafes.Cafe_Restaurante(NIF)
);
create table Cafes.Cafe_Pastelaria (
    NIF	int not null,
    nome	varchar(30) not null,
    morada	varchar(30) not null,
    no_bolos  int,
    primary key(NIF),
    foreign key(NIF,nome,morada) references Cafes.Cafe(NIF,nome,morada)
);
create table Cafes.Pasteleiro(
    NIF int not null,
    NIF_cafeP    int not null,
    idade   int not null,
    nome    varchar(30) not null,
    data_inic_contrato  date not null,
    primary key(NIF),
    foreign key(NIF,nome) references Cafes.Pessoa(NIF,nome),
    foreign key(NIF_cafeP) references Cafes.Cafe_Pastelaria(NIF)
);
create table Cafes.Cafe_Bar (
    NIF	int not null,
    nome	varchar(30) not null,
    morada	varchar(30) not null,
    primary key(NIF),
    foreign key(NIF,nome,morada) references Cafes.Cafe(NIF,nome,morada)
);
create table Cafes.Bar(
    NIF_cafeB   int not null,
    bebidas int,
    primary key(NIF_CafeB),
    foreign key(NIF_CafeB) references Cafes.Cafe_Bar(NIF)
);
create table Cafes.Bartender(
    NIF int not null,
    NIF_cafeB    int not null,
    idade   int not null,
    nome    varchar(30) not null,
    data_inic_contrato  date not null,
    primary key(NIF),
    foreign key(NIF,nome) references Cafes.Pessoa(NIF,nome),
    foreign key(NIF_cafeB) references Cafes.Cafe_Bar(NIF)
);
*/
/*
create Table Recibo(
    reciboID int not null,
    ClienteNIF  int not null,
    EmpNIF  int not null,
    data_recibo date,
    valor   money,
    primary key(Nrecibo),
    foreign key(EmpNIF) references Cafes.Empregado(NIF),
    foreign key(ClienteNIF) references Cafes.Cliente(NIF)
);
*/
/*
create table Cafes.C_paga_E(
    Recibo_ID  int not null,
    Data_pagamento    date  not null,
    valor   int,
    NIF_E   int not null,
    NIF_C   int not null,
    primary key(Recibo_ID),
    foreign key(NIF_E) references Cafes.Empregado(NIF),
    foreign key(NIF_C) references Cafes.Cliente(NIF),
    foreign key(Recibo_ID) references Cafes.Recibo(reciboID)
);
*/

CREATE TABLE Cafe.Produto(
    nomeProduto         VARCHAR(15)     NOT NULL,
    precoProduto        INT           NOT NULL,
    tipoProduto         INT             NOT NULL,
    NIF_Fornecedor      INT             NOT NULL,
    NIF_Cafe            INT             NOT NULL,

    PRIMARY KEY(nomeProduto),


);


ALTER TABLE Cafe.Recibo DROP COLUMN valor;