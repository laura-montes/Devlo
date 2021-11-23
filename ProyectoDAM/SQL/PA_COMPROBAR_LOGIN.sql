USE [db_devlo]
GO

/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DEL PROCEDIMIENTO:	PA_XXX
	FECHA DE CREACIÓN: 		--/--/----
	AUTOR:				------
	VSS:				RUTA VISUAL SOURCESAFE EJ: BP\CODIGO_SQL\01. PROCEDIMIENTOS ALMACENADOS\70. I2C\1003 - Maestro referencias\ARISTOCRAZY
	USO:				##WEB##|##VISUAL##

	FUNCIONAMIENTO:			FUNCIONAMIENTO

	PARAMETROS:			(OPCIONAL)
		PARAMETRO1 		INPUT	EXPLICACION
		PARAMETRO2 		OUTPUT	EXPLICACION

-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACIÓN:
--	AUTOR:
--	EXPLICACIÓN:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/

CREATE PROCEDURE PA_COMPROBAR_LOGIN
	
	@EMAIL	VARCHAR(100),	
	@PASSWORD	VARCHAR(10),

	@INVOKER	INT,		-- ESTE PARÁMETRO LO DEBEN TENER TODOS LOS PAS
	@USUARIO	VARCHAR(12),	-- ESTE PARÁMETRO LO DEBEN TENER TODOS LOS PAS
	@CULTURA	VARCHAR(5),

	@RETCODE	INT OUTPUT, --DEFINICIÓN OBLIGATORIA
	@MENSAJE	VARCHAR(1000)	OUTPUT	--DEFINICIÓN OBLIGATORIA

AS

BEGIN TRY

	DECLARE @N_TRANS		INT = 0	 --NUMERO DE TRANSACCIONES ACTIVAS	(@@TRANCOUNT)
	SET @N_TRANS = @@TRANCOUNT

	
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacción por encima no hacemos nada
	BEGIN
		BEGIN TRANSACTION TR_NOMBRE_TRANSACTION
	END
	----------------------------------------------------------------------------------------------------------------------------------------------

	IF ((SELECT COUNT(*) FROM USER_DEVLO WHERE EMAIL=@EMAIL AND PASSWORD=@PASSWORD)>0)
	BEGIN

		SET @MENSAJE = 'CONEXION ESTABLECIDA.'
		SET @RETCODE = 0
		RETURN @RETCODE

	END
	ELSE
	BEGIN 

		SET  @MENSAJE = 'ERROR DE CREDENCIALES'
		SET @RETCODE = -1
		RETURN @RETCODE

	END

	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacción por encima no hacemos nada
	BEGIN
		COMMIT TRANSACTION TR_NOMBRE_TRANSACTION
	END
	----------------------------------------------------------------------------------------------------------------------------------------------


	SET @MENSAJE = 'El proceso se ha realizado correctamente.'
	SET @RETCODE = 0
	RETURN @RETCODE
END TRY
BEGIN CATCH
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0 AND @@TRANCOUNT > 0				-- Si hay una transacción por encima no hacemos nada
	BEGIN
		ROLLBACK TRANSACTION TR_NOMBRE_TRANSACTION
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @MENSAJE = '' 
	BEGIN
		SET  @MENSAJE = ERROR_MESSAGE()
	END
	
	SET @RETCODE = -1
		
	RETURN @RETCODE
END CATCH

	SET @RETCODE = -1		
	RETURN @RETCODE






/*----------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------
------------------------------               PRUEBAS              ------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------


DECLARE @RETCODE	INT
DECLARE @PARAMETRO1	VARCHAR(10)
DECLARE @PARAMETRO2	INT
DECLARE @PARAMETRO3	VARCHAR(20)
DECLARE @MENSAJE	VARCHAR(1000)

SET @MENSAJE 		= ''

EXEC @RETCODE = PA_XXXX @PARAMETRO1, @PARAMETRO2, @PARAMETRO3 OUTPUT, @MENSAJE OUTPUT

PRINT 'RETCODE:	' 	+ ISNULL(CAST(@RETCODE AS VARCHAR(10)), 'NULO')
PRINT 'MENSAJE:	' 	+ ISNULL(@MENSAJE, 'NULO')
PRINT 'PARAMETRO3''	+ ISNULL(@PARAMETRO3, 'NULO')



------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------
------------------------------             FIN PRUEBAS            ------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------*/
