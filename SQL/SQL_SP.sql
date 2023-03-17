CREATE PROCEDURE sp_CrearPaciente 
(
	@IdTipoDocumento int, 
	@NumeroDocumento varchar(20), 
	@Nombres varchar(20), 
	@Apellidos varchar(20), 
	@Correo varchar(50), 
	@Telefono varchar(10), 
	@FechaNacimiento date, 
	@EstadoAfiliacion bit
)
AS BEGIN
	INSERT INTO tb_pacientes 
	(
		IdTipoDocumento,
		NumeroDocumento,
		Nombres,
		Apellidos,
		Correo,
		Telefono, 
		FechaNacimiento,
		EstadoAfiliacion
	)
	VALUES
	(
		@IdTipoDocumento, 
		@NumeroDocumento, 
		@Nombres, 
		@Apellidos, 
		@Correo, 
		@Telefono, 
		@FechaNacimiento, 
		@EstadoAfiliacion
	)
END

GO
CREATE PROCEDURE sp_ActualizarPaciente 
(
	@id int,
	@IdTipoDocumento int, 
	@NumeroDocumento varchar(20), 
	@Nombres varchar(20), 
	@Apellidos varchar(20), 
	@Correo varchar(50), 
	@Telefono varchar(10), 
	@FechaNacimiento date, 
	@EstadoAfiliacion bit
)
AS BEGIN
	UPDATE tb_pacientes 
	SET
		IdTipoDocumento = @IdTipoDocumento, 
		NumeroDocumento = @NumeroDocumento, 
		Nombres = @Nombres, 
		Apellidos = @Apellidos, 
		Correo = @Correo, 
		Telefono = @Telefono, 
		FechaNacimiento = @FechaNacimiento, 
		EstadoAfiliacion = @EstadoAfiliacion
	WHERE
		id = @id
END

GO
CREATE PROCEDURE sp_EliminarPaciente (@id int)
AS BEGIN
	DELETE FROM tb_pacientes 
	WHERE id = @id
END

GO
CREATE PROCEDURE sp_ListarTipoDocumento
AS BEGIN
	SELECT * FROM tb_tipoDocumento
END