CREATE DATABASE trabajo11092018
GO

USE trabajo11092018
GO

CREATE TABLE nacionalidad(
id INT IDENTITY,
nombreNacionalidad VARCHAR (20),
PRIMARY KEY (id)
)
GO

CREATE TABLE ciudad(
id INT IDENTITY,
fk_nacionalidad INT,
nombreCiudad VARCHAR (20),
PRIMARY KEY (id),
FOREIGN KEY (fk_nacionalidad) REFERENCES nacionalidad (id),
)
GO

CREATE TABLE cedula(
id INT IDENTITY,
apellidos VARCHAR (40),
nombres VARCHAR (40),
fk_nacionalidad INT,
sexo VARCHAR (20),
fechaDeNacimiento DATE,
numeroDeDocumento UNIQUEIDENTIFIER,
fechaDeEmision DATE,
fechaDeVencimiento DATE,
run VARCHAR (20),
fk_ciudadDeNacimiento INT,
profesion VARCHAR (40),
rutaFoto VARCHAR (80),
FOREIGN KEY (fk_nacionalidad) REFERENCES nacionalidad (id),
FOREIGN KEY (fk_ciudadDeNacimiento) REFERENCES ciudad (id),
PRIMARY KEY (id)
)
GO


INSERT INTO nacionalidad VALUES ('Chilena')
INSERT INTO nacionalidad VALUES ('Uruguaya')
INSERT INTO nacionalidad VALUES ('Argentina')
GO

INSERT INTO ciudad VALUES (1, 'Santiago')
INSERT INTO ciudad VALUES (2, 'Montevideo')
INSERT INTO ciudad VALUES (3, 'Buenos Aires')
GO

INSERT INTO cedula (apellidos, nombres,fk_nacionalidad, sexo, fechaDeNacimiento, numeroDeDocumento, 
fechaDeEmision, fechaDeVencimiento, run, fk_ciudadDeNacimiento, profesion, rutaFoto) VALUES('Del Solar Benavides', 'Sofia Cindy', 1, 'Femenino',' 180612', NEWID(),GETDATE(),'170522',
'20-455879-5',1, 'No informada','ruta'); --HOLY S**T just pure number actually works as DATE only format!
GO

INSERT INTO cedula (apellidos, nombres,fk_nacionalidad, sexo, fechaDeNacimiento, numeroDeDocumento, 
fechaDeEmision, fechaDeVencimiento, run, fk_ciudadDeNacimiento, profesion, rutaFoto) VALUES('De La Vega', 'Katya Volskaya', 1, 'Femenino',' 180612', NEWID(),GETDATE(),'170522',
'20-455879-5',1, 'No informada','ruta')
GO


SELECT * FROM nacionalidad;
SELECT * FROM ciudad;
SELECT nacionalidad.nombreNacionalidad AS 'Nacionalidad', ciudad.nombreCiudad AS 'Ciudad de nacimiento' FROM nacionalidad, ciudad WHERE nacionalidad.id=ciudad.fk_nacionalidad
GO

SELECT * FROM cedula;

CREATE VIEW verDatosDeCedula AS
SELECT cedula.id, cedula.apellidos, cedula.nombres, nacionalidad.nombreNacionalidad, cedula.sexo, cedula.fechaDeNacimiento, cedula.numeroDeDocumento, cedula.fechaDeEmision, cedula.fechaDeVencimiento, cedula.run, ciudad.nombreCiudad, cedula.profesion, cedula.rutaFoto
FROM cedula, nacionalidad, ciudad WHERE ciudad.fk_nacionalidad=nacionalidad.id AND cedula.fk_nacionalidad=nacionalidad.id AND cedula.fk_ciudadDeNacimiento=ciudad.id
GO

SELECT * FROM verDatosDeCedula
GO

/* 
USE master;
GO
ALTER DATABASE trabajo11092018 SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO
DROP DATABASE trabajo11092018;
*/