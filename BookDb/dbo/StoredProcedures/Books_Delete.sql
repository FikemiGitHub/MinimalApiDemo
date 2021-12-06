CREATE PROCEDURE [dbo].[Books_Delete]
	@Id int
AS
BEGIN
	Delete
	From dbo.Book
	Where Id = @Id
END

