CREATE DATABASE DBCursos;
USE DBCursos;

CREATE TABLE Profesor(
	id INT NOT NULL PRIMARY KEY,
	nombre NCHAR(45) NOT NULL DEFAULT 'Sin nombre'
);

CREATE TABLE Curso(
	id INT NOT NULL PRIMARY KEY,
	idProfesor INT NOT NULL,
	nombre NCHAR(45) NOT NULL DEFAULT 'Sin nombre',
	FOREIGN KEY (idProfesor) REFERENCES Profesor(id)
);

CREATE TABLE Alumno(
	id INT NOT NULL PRIMARY KEY,
	nombre NCHAR(45) NOT NULL DEFAULT 'Sin nombre',
	idCurso INT NOT NULL,
	nacimiento BIGINT NOT NULL DEFAULT 0,
	creacion DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
	FOREIGN KEY (idCurso) REFERENCES Curso(id)
);

INSERT INTO Profesor VALUES(18641747, 'Sebastián Ignacio López Muñoz');
INSERT INTO Curso VALUES(0,18641747,'Programación .NET');
INSERT INTO Alumno(id, nombre, idCurso, nacimiento) VALUES(23647838, 'AlumnoPrueba', 0, 988761600);
INSERT INTO Alumno(id, nombre, idCurso, nacimiento) VALUES(45645667, 'AlumnoPrueba1', 0, 988761600);
INSERT INTO Alumno(id, nombre, idCurso, nacimiento) VALUES(34567673, 'AlumnoPrueba2', 0, 988761600);
INSERT INTO Alumno(id, nombre, idCurso, nacimiento) VALUES(78956766, 'AlumnoPrueba3', 0, 988761600);
INSERT INTO Alumno(id, nombre, idCurso, nacimiento) VALUES(23423456, 'AlumnoPrueba4', 0, 988761600);
SELECT * FROM Profesor, Curso, Alumno ORDER BY Alumno.id;