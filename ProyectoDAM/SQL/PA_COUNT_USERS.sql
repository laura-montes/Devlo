/****** Object:  StoredProcedure [dbo].[PA_COUNT_USERS]    Script Date: 13/12/2021 19:28:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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

ALTER PROCEDURE [dbo].[PA_COUNT_USERS]

	@DATE DATETIME,
	
	@INVOKER	INT,		-- ALL THE PAS HAS TO HAD THIS PARAMETER
	@USUARIO	VARCHAR(12),	-- ALL THE PAS HAS TO HAD THIS PARAMETER
	@CULTURA	VARCHAR(5),

	@RETCODE	INT OUTPUT, --OLBIGATORY DEFINITION
	@MENSAJE	VARCHAR(1000)	OUTPUT,	--OLBIGATORY DEFINITION
	@CANTIDAD	INT OUTPUT

AS

BEGIN TRY

	DECLARE @N_TRANS		INT = 0	 --NUMBER OF ACTIVE TRANSACTIONS	(@@TRANCOUNT)
	SET @N_TRANS = @@TRANCOUNT

	
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- IF THERE IS A TRANSACTION ABOVE WE DONT DO NOTHING
	BEGIN
		BEGIN TRANSACTION TR_NOMBRE_TRANSACTION
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @INVOKER = 0
	BEGIN
		SELECT @CANTIDAD = isnull(COUNT(*),0) FROM CONTACTS WHERE ADDED_DATE like '%'+CONVERT(varchar,@DATE)+'%'
	END
	IF @INVOKER = 1
	BEGIN
		SELECT @CANTIDAD = isnull(COUNT(*),0) FROM CONTACTS
	END

	SET @MENSAJE = 'CANTIDAD '
	SET @RETCODE = 0
	RETURN @RETCODE

	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- IF THERE IS A TRANSACTION ABOVE WE DONT DO NOTHING
	BEGIN
		COMMIT TRANSACTION TR_NOMBRE_TRANSACTION
	END
	----------------------------------------------------------------------------------------------------------------------------------------------


	SET @MENSAJE = 'The process was successful.'
	SET @RETCODE = 0
	RETURN @RETCODE
END TRY
BEGIN CATCH
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0 AND @@TRANCOUNT > 0				-- IF THERE IS A TRANSACTION ABOVE WE DONT DO NOTHING
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
