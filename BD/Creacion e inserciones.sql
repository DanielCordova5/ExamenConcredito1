--CREATE DATABASE Escuela
USE Escuela
CREATE TABLE Alumno(
	ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nombre Varchar(30),
	ApellidoPaterno Varchar(30),
	ApellidoMaterno Varchar(30),
	Salon Varchar(2),
	Calificacion float,
);

INSERT INTO Alumno (Nombre, ApellidoPaterno, ApellidoMaterno, Salon, Calificacion)
VALUES ('Daniel', 'Cordova', 'Garcia', '6A', 10),
('Jesus', 'Barajas', 'Villegas', '6B', 9.9),
('Fabiola', 'Sicairos', 'Barraza', '6A', 10),
('Alberto', 'Cordova', 'Garcia', '6B', 10),
('Jared', 'Dominguez', 'Herrera', '6A', 7.8),
('Hugo', 'Reyna', 'Flores', '6A', 9.3),
('Alejandro', 'Rodriguez', 'Herrera', '6B', 8.9),
('Jhonatan', 'Alvarez', 'Diaz', '6B', 8.4),
('Rodrigo', 'Hernandez', 'Valencia', '6A', 6.0),
('David', 'Torres', 'Lopez', '6A', 6.8),
('Fernando', 'Ibarria', 'Lopez', '6B', 7.8),
('Daniel', 'Cordova', 'Sicairos','6A', 9.9),
('Jesus', 'Gaxiola', 'Vega', '6C', 8.3),
('Alondra', 'Cazares', 'Diaz', '6A', 7.9),
('Maria', 'Alvarez', 'Garcia', '6A', 5.9)

