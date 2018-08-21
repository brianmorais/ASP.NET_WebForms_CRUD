CREATE DATABASE BDCrud;
GO
USE BDCrud;

CREATE TABLE Curso(    
Id INT IDENTITY,
Descricao VARCHAR(30) NOT NULL,
Periodo VARCHAR(10),
Constraint PK_Curso PRIMARY KEY(Id)
);

CREATE TABLE Coordenador(
Id INT IDENTITY,
Nome VARCHAR(30) NOT NULL,
Constraint PK_Coordenador PRIMARY KEY(Id)
);

ALTER TABLE Curso 
ADD IdCoordenador INT 
FOREIGN KEY REFERENCES Coordenador(Id);

CREATE TABLE Aluno(
RA INT IDENTITY,
Nome VARCHAR(30) NOT NULL,
CPF CHAR(11),
Constraint PK_Aluno PRIMARY KEY (Ra),
Constraint UQ_AlunoCPF UNIQUE (CPF)
);

CREATE TABLE TBLogin(
USUARIO VARCHAR(30) PRIMARY KEY,
SENHA VARCHAR(30) NOT NULL
);

GO

INSERT INTO Aluno(Nome, CPF)values('Fulano', '54892');
INSERT INTO Aluno(Nome, CPF)values('Ciclano', '58741');
INSERT INTO Aluno(Nome, CPF)values('Deutrano', '201489');
INSERT INTO Aluno(Nome, CPF)values('Joao', '954521');
INSERT INTO Aluno(Nome, CPF)values('Ana', '1478952');

INSERT INTO Coordenador(Nome)values('Rodrigo Saito');
INSERT INTO Coordenador(Nome)values('Anderson Spera');
INSERT INTO Coordenador(Nome)values('Edvaldo');
INSERT INTO Coordenador(Nome)values('Peter');

INSERT INTO Curso(Descricao, Periodo, IdCoordenador)values('ADS', 'Noturno', 1);
INSERT INTO Curso(Descricao, Periodo, IdCoordenador)values('CC', 'Tarde', 2 );
INSERT INTO Curso(Descricao, Periodo, IdCoordenador)values('SI', 'Noturno', 3 );
INSERT INTO Curso(Descricao, Periodo, IdCoordenador)values('Direito', 'Tarde', 4 );

