-- Создание
--USE master;
--DROP DATABASE Fandom;
USE master;
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name=N'Fandom')
BEGIN
	CREATE DATABASE Fandom;
END
ELSE
BEGIN
	PRINT (N'БД Fandom уже есть');
END
USE Fandom;
	CREATE TABLE [Persons]
		([Id] INT PRIMARY KEY IDENTITY(1,1),
		[name] NVARCHAR(50)  );

-- Инициализация
USE Fandom;
INSERT INTO Persons
(Persons.name)
VALUES
(N'Doctor David Livesey'), 
(N'John Silver'),
(N'William "Billy" Bones');
USE Fandom;
SELECT * FROM Persons;