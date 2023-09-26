CREATE DATABASE RisoOdonto

 

USE RisoOdonto

--TipoUSuario
CREATE TABLE TipoUsuario
(
    [IdTipoUsuario] INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
    [DescricaoTipoUsuario] NVARCHAR(150) NOT NULL 

);

INSERT INTO TipoUsuario VALUES ('Administrador'),('Outros');
SELECT * FROM Paciente;


 

CREATE TABLE Paciente
(
IdPaciente INTEGER IDENTITY PRIMARY KEY,
Nome VARCHAR (50) NOT NULL,
DataNasciemento DATE NOT NULL,
Email VARCHAR (20) NOT NULL,
Senha VARCHAR (20) NOT NULL,
Telefone INT NOT NULL,
CPF VARCHAR (14) NOT NULL,
Estado VARCHAR (20) NOT NULL,
Endereço VARCHAR (20) NOT NULL,
TpUsuario INT NOT NULL,

	
   FOREIGN KEY (TpUsuario) REFERENCES TipoUsuario(IdTipoUsuario)

)


INSERT INTO Paciente (Nome, DataNasciemento, Email, Senha, Telefone, CPF, Estado, Endereço, TpUsuario)
VALUES ('Kelvin', '1999-07-19', 'k.bryan924@gmail.com', '021819', 1198531-1185, '47572436854', 'São Paulo', 'Rua Alvarens', 2)
 

CREATE TABLE Dentista
(
IdDentista INTEGER IDENTITY PRIMARY KEY,
Nome VARCHAR (50) NOT NULL,
Cro INT NOT NULL,
Email VARCHAR (50) NOT NULL,
Login_Dentista VARCHAR (50) NOT NULL,
Senha VARCHAR (20) NOT NULL,
Especialidade VARCHAR (40) NOT NULL,
)

 

CREATE TABLE Agendamento
(
IdAgendamento INTEGER IDENTITY PRIMARY KEY,
IdPaciente INT NOT NULL
        FOREIGN KEY REFERENCES Paciente (IdPaciente),
IdDentista INT NOT NULL 
        FOREIGN KEY REFERENCES Dentista (IdDentista),
Data_Consulta DATE NOT NULL,
Horario DATE NOT NULL,
Primeira_Consulta BIT NOT NULL,
Status_Consulta VARCHAR NOT NULL,    
)

 CREATE TABLE Procedimentos
(
IdProcedimento INTEGER IDENTITY PRIMARY KEY,
Nome VARCHAR (50) NOT NULL,
Valor_Consulta FLOAT(8) NOT NULL
)



CREATE TABLE Tratamento
(
IdTratamento INTEGER IDENTITY PRIMARY KEY,
IdAgendamento INT NOT NULL
        FOREIGN KEY REFERENCES Agendamento (IdAgendamento),
IdProcedimento INT NOT NULL
        FOREIGN KEY REFERENCES Procedimentos (IdProcedimento),
Estado VARCHAR (20) NOT NULL
)

 

CREATE TABLE Prontuario
(
IdProntuario INTEGER IDENTITY PRIMARY KEY,
IdTratamento INT NOT NULL
        FOREIGN KEY REFERENCES Tratamento (IdTratamento),
Data_Hora_Entrada DATETIME NOT NULL,
Descricao VARCHAR (100) NOT NULL,
Data_Hora_Saida DATETIME NOT NULL
)





CREATE TABLE Funcionarios
(
IdFuncionario INTEGER IDENTITY PRIMARY KEY,
Nome VARCHAR (50) NOT NULL,
CPF VARCHAR (14) NOT NULL,
Cargo VARCHAR (50) NOT NULL,
Email VARCHAR (50) NOT NULL,
Login_Funcionario VARCHAR (50) NOT NULL,
Senha VARCHAR (20) NOT NULL,
Cidade VARCHAR (20) NOT NULL,
Bairro VARCHAR (15) NOT NULL,
Cep INT NOT NULL,
Logradouro VARCHAR (30)NOT NULL,
Nro INT NOT NULL,
TpUsuario BIT NOT NULL
)