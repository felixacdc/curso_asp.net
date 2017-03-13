-- ********** Procedimientos Almacenados **************
CREATE PROCEDURE spAccesoSistema
(@prmUser varchar(50),
@prmPass varchar(50)
)
AS
	BEGIN
		SELECT E.idEmpleado,E.usuario,E.clave
		FROM Empleado E
		WHERE E.usuario = @prmUser AND E.clave = @prmPass
	END