create table Cafes.Cafe(
    NIF	int not null,
    nome	varchar(30) not null,
    morada	varchar(30) not null,
    primary key(NIF)
);

create table Cafes.Pessoa(
    NIF int not null,
    nome    varchar(30) not null,
    primary key(NIF,nome),
);

CREATE TABLE Cafes.Administrador(
	username	VARCHAR(30)			NOT NULL,
	pwd			VARBINARY(36)		NOT NULL,
	NIF			INT					NOT NULL,
	nome		VARCHAR(30)			NOT NULL,
	PRIMARY KEY(NIF, nome),
	FOREIGN KEY(NIF, nome) REFERENCES Cafes.Pessoa(NIF, nome)
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
    primary key(NIF),
    foreign key(NIF,nome) references Cafes.Pessoa(NIF,nome)
);

create table Cafes.Cafe_Restaurante (
    NIF	int not null,
    nome	varchar(30) not null,
    morada	varchar(30) not null,
    primary key(NIF),
    foreign key(NIF) references Cafes.Cafe(NIF)
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
    primary key(NIF),
    foreign key(NIF) references Cafes.Cafe(NIF)
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
    foreign key(NIF) references Cafes.Cafe(NIF)
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

create Table Cafes.Recibo(
    reciboID INT  not null	IDENTITY(1, 1),
    ClienteNIF  int not null,
    EmpNIF  int not null,
    data_recibo date,
    valor   float	not null,
    primary key(reciboID),
);

CREATE TABLE Cafes.Produto(
	nomeP	VARCHAR(20)		NOT NULL,
	ID_P	INT				NOT NULL IDENTITY(1,1),
	precoP	FLOAT			NOT NULL,
	tipoP	INT				NOT NULL,
	PRIMARY KEY(ID_P)
);

CREATE TABLE Cafes.Compra(
	Recibo_ID	INT		NOT NULL,
	Produto_ID	INT		NOT NULL,
	quantidade	INT,
	PRIMARY KEY(Recibo_ID, Produto_ID),
	FOREIGN KEY(Recibo_ID) REFERENCES Cafes.Recibo(reciboID),
	FOREIGN KEY(Produto_ID) REFERENCES Cafes.Produto(ID_P)
);

