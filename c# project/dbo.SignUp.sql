CREATE TABLE [dbo].[SignUp] (
    [Password] NVARCHAR (50) NOT NULL,
    [Username] NVARCHAR (50) NOT NULL,
    [Email]    NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Password] ASC)
);

