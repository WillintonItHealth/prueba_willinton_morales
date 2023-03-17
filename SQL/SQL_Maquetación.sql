CREATE DATABASE db_prueba_willinton_morales

USE db_prueba_willinton_morales

CREATE TABLE tb_pacientes 
(
	id int primary key identity (1,1),
	IdTipoDocumento int,
	NumeroDocumento varchar(20),
	Nombres varchar(20),
	Apellidos varchar(20),
	Correo varchar(50),
	Telefono varchar(10),
	FechaNacimiento date,
	EstadoAfiliacion bit
)

INSERT INTO tb_pacientes (IdTipoDocumento, NumeroDocumento, Nombres, Apellidos, Correo, Telefono, FechaNacimiento, EstadoAfiliacion)
VALUES (1, '26873498', 'Andrea Carolina', 'Perez Ramirez', 'acpr@correo.co', '3115648792', '2000-08-22', 1)

CREATE TABLE tb_tipoDocumento 
(
	id int primary key identity (1,1),
	AbreviaturaTipo varchar(2),
	TipoDocumento varchar(30)
)

SELECT * FROM tb_tipoDocumento

INSERT INTO tb_tipoDocumento (AbreviaturaTipo, TipoDocumento)
VALUES ('CC', 'Cédula de Ciudadania')
INSERT INTO tb_tipoDocumento (AbreviaturaTipo, TipoDocumento)
VALUES ('TI', 'Tarjeta de Identidad')
INSERT INTO tb_tipoDocumento (AbreviaturaTipo, TipoDocumento)
VALUES ('RC', 'Registro Civil')
INSERT INTO tb_tipoDocumento (AbreviaturaTipo, TipoDocumento)
VALUES ('PA', 'Pasaporte')