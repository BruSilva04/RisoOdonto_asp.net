USE RisoOdonto

 

SELECT * FROM Paciente;

 

 

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

Email VARCHAR (20) NOT NULL,

Telefone INT NOT NULL,

DataNasciemento DATE NOT NULL,

CPF VARCHAR (14) NOT NULL,

Estado VARCHAR (20) NOT NULL,

Endereço VARCHAR (20) NOT NULL,

Senha VARCHAR (20) NOT NULL,

TpUsuario INT NOT NULL,

 

	

   FOREIGN KEY (TpUsuario) REFERENCES TipoUsuario(IdTipoUsuario)

 

)

 

 

INSERT INTO Paciente (Nome, Email,Telefone, DataNasciemento, CPF, Estado, Endereço, Senha, TpUsuario)

VALUES ('Kelvin','k.bryan924@gmail.com', 1198531-1185, '1999-07-19', '47572436854', 'São Paulo', 'Rua Alvarens',  '021819',  2)

