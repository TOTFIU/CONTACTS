CREATE TABLE [dbo].[Contacts] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NULL,
    [MobilePhone] NVARCHAR (MAX) NULL,
    [JobTitle]    NVARCHAR (MAX) NULL,
    [BirthDate]   DATETIME2 (7)  NULL,
    CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED ([Id] ASC)
);

