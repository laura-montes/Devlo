USE db_devlo
GO

/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DE LA VISTA:		V_XXX
	FECHA DE CREACI�N: 		--/--/----
	AUTOR:				------
	VSS:				RUTA VISUAL SOURCESAFE EJ: BP\CODIGO_SQL\02. VISTAS\WEB_SCL\AVISOS_RECEPCION
	USO:				##WEB##|##VISUAL##

	DESCRIPCION DE LA VISTA:	DESCRIPCION

-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACI�N:
--	AUTOR:
--	EXPLICACI�N:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/

CREATE VIEW V_XXX
AS	
	SELECT CONCAT(NAME, ' ', SURNAMES) full_name FROM CONTACTS;