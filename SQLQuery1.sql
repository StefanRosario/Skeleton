USE [p2668852]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_OrderProcess_SelectAll]

SELECT	@return_value as 'Return Value'

GO
