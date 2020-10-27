CREATE TABLE [dbo].[Employees] (
    [EmployeeId]  INT           IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50) NOT NULL,
    [DateOfBirth] DATETIME      NOT NULL,
    [Married]     BIT           NOT NULL,
    [Phone]       NVARCHAR (50) NOT NULL,
    [Salary]      MONEY         NOT NULL,
    CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED ([EmployeeId] ASC)
);

