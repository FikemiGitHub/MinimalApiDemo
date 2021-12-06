CREATE PROCEDURE [dbo].[Books_Update]
	@Id int,
	@Title varchar(50),
	@Author varchar(50),
	@Description varchar(50)
AS
BEGIN
	Update dbo.Book
	Set 
	Title = @Title,
	Author = @Author,
	Description = @Description
	Where
	Id = @Id
END
