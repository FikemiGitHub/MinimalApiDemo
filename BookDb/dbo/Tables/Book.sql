CREATE TABLE [dbo].[Book]
(
	[Id] INT NOT NULL PRIMARY KEY Identity, 
    [Title] VARCHAR(50) NOT NULL, 
    [Author] VARCHAR(50) NOT NULL, 
    [Description] VARCHAR(MAX) NOT NULL
)
