-- Sistema de Gestión de Citas Médicas 
-- Tablas según el documento del proyecto (3FN)

/* Validaciones en la capa de negocio (C#):
   - Un paciente o médico no puede tener más de un usuario
   - Un médico no puede tener dos citas activas a la misma FechaHora
     (se ignoran las citas canceladas). */

SET NOCOUNT ON;
GO

USE master;
GO
-- Si la base de datos existe, se cierran conexiones y se elimina
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'GestionCitasMedicas')
BEGIN
    -- Forzar cierre de conexiones existentes inmediatamente
    ALTER DATABASE GestionCitasMedicas SET SINGLE_USER WITH ROLLBACK IMMEDIATE;    
    -- Eliminar la base de datos permanentemente
    DROP DATABASE GestionCitasMedicas;
   END
GO


CREATE DATABASE GestionCitasMedicas
GO
USE GestionCitasMedicas
GO

CREATE TABLE Paciente
(ID_Paciente INT IDENTITY(1,1) PRIMARY KEY,
Nombre NVARCHAR(50) NOT NULL,
Apellido NVARCHAR(50) NOT NULL,
FechaNacimiento DATE NOT NULL,
Telefono VARCHAR(9) NOT NULL,
Correo NVARCHAR(100) NOT NULL,
CONSTRAINT U_Correo_paciente UNIQUE (Correo),
CONSTRAINT CK_FechaNacimiento CHECK (FechaNacimiento <= CAST(GETDATE() AS DATE) AND FechaNacimiento >= '1900-01-01'),
CONSTRAINT CK_Telefono_paciente CHECK (Telefono LIKE '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'
                                           OR Telefono LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
CONSTRAINT CK_Correo_paciente CHECK (Correo LIKE '%_@_%._%')
);
GO

CREATE TABLE Especialidad
(ID_Especialidad INT IDENTITY(1,1) PRIMARY KEY, 
NombreEspecialidad NVARCHAR(100) NOT NULL,
CONSTRAINT U_NombreEspecialidad UNIQUE (NombreEspecialidad),
CONSTRAINT CK_Especialidad_Nombre CHECK (LEN(LTRIM(RTRIM(NombreEspecialidad))) > 0) -- Quita espacios al inicio y al final
);
GO

CREATE TABLE Medico
(ID_Medico INT IDENTITY(1,1) PRIMARY KEY, 
Nombre NVARCHAR(50) NOT NULL,
Apellido NVARCHAR(50) NOT NULL,
Telefono VARCHAR(9) NOT NULL,
Correo NVARCHAR(100) NOT NULL,
ID_Especialidad INT NOT NULL,
CONSTRAINT FK_idEspecialidad_medico FOREIGN KEY (ID_Especialidad) REFERENCES Especialidad(ID_Especialidad), 
CONSTRAINT U_Correo_medico UNIQUE (Correo),
CONSTRAINT CK_Telefono_medico CHECK (Telefono LIKE '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'
                                           OR Telefono LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
CONSTRAINT CK_Correo_medico CHECK (Correo LIKE '%_@_%._%')
);
GO

CREATE TABLE Cita
(ID_Cita INT IDENTITY(1,1) PRIMARY KEY,
FechaHora DATETIME NOT NULL,
Estado NVARCHAR(15) NOT NULL,
ID_Paciente INT NOT NULL,
ID_Medico INT NOT NULL,
CONSTRAINT FK_idPaciente FOREIGN KEY (ID_Paciente) REFERENCES Paciente(ID_Paciente),
CONSTRAINT FK_idMedico FOREIGN KEY (ID_Medico) REFERENCES Medico(ID_Medico),
CONSTRAINT CK_Estado_cita CHECK (Estado IN ('Pendiente','Atendida','Cancelada'))
);
GO

ALTER TABLE Cita ADD CONSTRAINT DF_Estado_cita DEFAULT ('Pendiente') FOR Estado;
GO

CREATE TABLE Receta
(ID_Receta INT IDENTITY(1,1) PRIMARY KEY, 
Descripcion NVARCHAR(1000) NOT NULL,
ID_Cita INT NOT NULL,
CONSTRAINT FK_idCita FOREIGN KEY (ID_Cita) REFERENCES Cita(ID_Cita), 
CONSTRAINT U_idCita UNIQUE (ID_Cita),  -- una cita como máximo una receta
CONSTRAINT CK_Receta_Descripcion CHECK (LEN(LTRIM(RTRIM(Descripcion))) > 0)
);
GO

CREATE TABLE Usuario
(ID_Usuario INT IDENTITY(1,1) PRIMARY KEY,
Username NVARCHAR(50) NOT NULL,
Password NVARCHAR(250) NOT NULL, -- guardar hash y no la contraseña en texto plano
Rol NVARCHAR(20) NOT NULL,
ID_Paciente INT  NULL,
ID_Medico INT NULL,
CONSTRAINT FK_idPaciente_usuario FOREIGN KEY (ID_Paciente) REFERENCES Paciente(ID_Paciente),
CONSTRAINT FK_idMedico_usuario FOREIGN KEY (ID_Medico) REFERENCES Medico(ID_Medico),
CONSTRAINT U_Username UNIQUE (Username),
CONSTRAINT CK_Rol_usuario CHECK (Rol IN ('Paciente','Medico','Administrador')),
CONSTRAINT CK_Usuario_Username CHECK (LEN(Username) >= 4), -- LEN calcula el núm de caracteres de una cadena de texto
CONSTRAINT CK_Usuario_Rol_Relacion CHECK (
    (Rol = 'Paciente'      AND ID_Paciente IS NOT NULL AND ID_Medico IS NULL) OR
    (Rol = 'Medico'        AND ID_Medico IS NOT NULL   AND ID_Paciente IS NULL) OR
    (Rol = 'Administrador' AND ID_Paciente IS NULL     AND ID_Medico IS NULL))
);
GO