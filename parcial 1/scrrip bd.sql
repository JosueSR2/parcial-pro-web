USE Colegio;

CREATE TABLE EstudiantesTarde 
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	NombreCompleto NVARCHAR (150),
	Matricula NVARCHAR (50),
	Curso NVARCHAR (100),
	Motivo NVARCHAR (250)
);


