CREATE TABLE Movies(
	Id INT IDENTITY (1, 1) PRIMARY KEY,
	Title NVARCHAR(200) NOT NULL,
	Director NVARCHAR(50)NOT NULL,
	DateReleased DATETIME NOT NULL
);

INSERT INTO Movies (Title, Director, DateReleased)
VALUES 
	('StarWars', 'Lucas', 1994-11-30),
	('King Kong', 'Jackson', 1990-08-12);

