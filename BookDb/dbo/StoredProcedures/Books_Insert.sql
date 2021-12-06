CREATE PROCEDURE [dbo].[Books_Insert]
	@Title varchar(50),
	@Author varchar(50),
	@Description varchar(50)
AS
BEGIN
	Insert into dbo.Book
	(
	Title, 
	Author, 
	Description
	)
	Values 
	(
	@Title,
	@Author,
	@Description
	)
END
