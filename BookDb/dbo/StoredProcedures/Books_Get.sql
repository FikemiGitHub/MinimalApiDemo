CREATE PROCEDURE [dbo].[Books_Get]
	@Id int
AS
BEGIN
	Select Id, Title, Author, Description
	From dbo.Book
	Where Id = @Id
END
