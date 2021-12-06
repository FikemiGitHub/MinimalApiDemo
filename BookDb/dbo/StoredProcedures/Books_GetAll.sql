CREATE PROCEDURE [dbo].[Books_GetAll]
AS
BEGIN
	Select Id, Title, Author, Description
	from dbo.Book
END
