IF EXISTS(SELECT * FROM SYS.DATABASES WHERE NAME='BD_TRAMITE_DOCUMENTARIO')
DROP DATABASE BD_TRAMITE
GO

CREATE DATABASE BD_TRAMITE
GO
USE BD_TRAMITE
GO

CREATE TABLE TLOGIN
(Usuario varchar(20) primary key,
Contraseña varchar(20),
Correo varchar(50),
)

GO
CREATE TABLE TSOLICITANTE
(NombreSolicitante varchar (80) primary key,
DNI char (8),
)

GO
CREATE TABLE TDOCUMENTO
(IdDocumento int identity(1,1) primary key,
NroDocumento char(11),
TipoDocumento varchar (80),
NombreDependencia text,
Asunto Text,
FechaInicio date,
FechaVencimiento date,
DocumentoDerivado text,
OrigenDocumento varchar(50),
NombreSolicitante varchar (80),
foreign key (NombreSolicitante) references TSOLICITANTE (NombreSolicitante)
)

GO
CREATE TABLE TDERIVADA
(Cod_Derivado int primary key,
Nom_Derivado varchar(80),
IdDocumento int,
foreign key (IdDocumento) references TDOCUMENTO (IdDocumento)
)
GO

--CONSULTAS DE PROCEDIDMIENTO ALMACENADO

create PROCEDURE ValidarCorreoElectrónico
@Correo varchar(50)
AS
SELECT * FROM TLOGIN WHERE Correo=@Correo
GO


CREATE PROCEDURE NuevaContraseña
@Correo varchar (50),
@Contraseña varchar(20)
AS
UPDATE TLOGIN SET Contraseña=@Contraseña
FROM TLOGIN 
WHERE Correo=@Correo
GO


CREATE PROC BuscarDocumentoRegistrado
@FechaRegistro DATE, @FechaVencimiento DATE
AS 
SELECT ts.NombreSolicitante, TipoDocumento, Fecha
FROM TDOCUMENTO td INNER JOIN TSOLICITANTE ts
ON td.NombreSolicitante = ts.NombreSolicitante 
WHERE Fecha Between @FechaRegistro and @FechaVencimiento 



SELECT * FROM TDOCUMENTO;
SELECT * FROM TSOLICITANTE;