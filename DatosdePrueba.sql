-- DATOS DE PRUEBA - Sistema de Gestión de Citas Médicas
-- Ejecutar DESPUÉS de GestionCitasMedicas.sql 
-- Las fechas de las citas se calculan a partir de HOY, así siempre
-- hay citas de hoy, pasadas (atendidas) y futuras (pendientes).


USE GestionCitasMedicas;
GO
SET NOCOUNT ON;


-- ---------------------------------------------------------------------
-- 1. Especialidades (ID 1 a 5)
-- ---------------------------------------------------------------------
INSERT INTO Especialidad (NombreEspecialidad) VALUES
('Medicina General'),   -- 1
('Pediatría'),          -- 2
('Cardiología'),        -- 3
('Dermatología'),       -- 4
('Ginecología');        -- 5

-- ---------------------------------------------------------------------
-- 2. Médicos (ID 1 a 6)
-- ---------------------------------------------------------------------
INSERT INTO Medico (Nombre, Apellido, Telefono, Correo, ID_Especialidad) VALUES
('Carlos',   'López',     '2222-1001', 'carlos.lopez@clinica.com',     1), -- 1
('Ana',      'Martínez',  '2222-1002', 'ana.martinez@clinica.com',     2), -- 2
('Roberto',  'Hernández', '2222-1003', 'roberto.hernandez@clinica.com',3), -- 3
('Lucía',    'Ramírez',   '2222-1004', 'lucia.ramirez@clinica.com',    4), -- 4
('Fernando', 'Castillo',  '2222-1005', 'fernando.castillo@clinica.com',5), -- 5
('Sofía',    'Mejía',     '2222-1006', 'sofia.mejia@clinica.com',      1); -- 6

-- ---------------------------------------------------------------------
-- 3. Pacientes (ID 1 a 8)
-- ---------------------------------------------------------------------
INSERT INTO Paciente (Nombre, Apellido, FechaNacimiento, Telefono, Correo) VALUES
('María',    'González', '1995-04-12', '7012-3456', 'maria.gonzalez@gmail.com'),  -- 1
('José',     'Pérez',    '1988-09-30', '7123-4567', 'jose.perez@gmail.com'),      -- 2
('Daniela',  'Flores',   '2001-01-22', '7234-5678', 'daniela.flores@gmail.com'),  -- 3
('Luis',     'Romero',   '1970-06-05', '7345-6789', 'luis.romero@gmail.com'),     -- 4
('Camila',   'Rivas',    '2018-11-15', '7456-7890', 'camila.rivas@gmail.com'),    -- 5 (niña, para Pediatría)
('Andrés',   'Morales',  '1999-03-08', '7567-8901', 'andres.morales@gmail.com'),  -- 6
('Gabriela', 'Ortiz',    '1992-12-01', '7678-9012', 'gabriela.ortiz@gmail.com'),  -- 7
('Ricardo',  'Vásquez',  '1965-07-19', '7789-0123', 'ricardo.vasquez@gmail.com'); -- 8

-- ---------------------------------------------------------------------
-- 4. Usuarios
--    Contraseñas en texto plano porque el login actual compara así.
--    Todos usan la contraseña: 1234
-- ---------------------------------------------------------------------
INSERT INTO Usuario (Username, Password, Rol, ID_Paciente, ID_Medico) VALUES
('admin',       '1234', 'Administrador', NULL, NULL),
-- Médicos
('dr.lopez',    '1234', 'Medico', NULL, 1),
('dra.martinez','1234', 'Medico', NULL, 2),
('dr.hernandez','1234', 'Medico', NULL, 3),
('dra.ramirez', '1234', 'Medico', NULL, 4),
('dr.castillo', '1234', 'Medico', NULL, 5),
('dra.mejia',   '1234', 'Medico', NULL, 6),
-- Pacientes
('maria.g',     '1234', 'Paciente', 1, NULL),
('jose.p',      '1234', 'Paciente', 2, NULL),
('daniela.f',   '1234', 'Paciente', 3, NULL),
('luis.r',      '1234', 'Paciente', 4, NULL),
('camila.r',    '1234', 'Paciente', 5, NULL),
('andres.m',    '1234', 'Paciente', 6, NULL),
('gabriela.o',  '1234', 'Paciente', 7, NULL),
('ricardo.v',   '1234', 'Paciente', 8, NULL);

-- ---------------------------------------------------------------------
-- 5. Citas (horas iguales a las del ComboBox: 8,9,10,11,13,14,15,16)
-- ---------------------------------------------------------------------
DECLARE @Hoy DATETIME = CAST(CAST(GETDATE() AS DATE) AS DATETIME);
INSERT INTO Cita (FechaHora, Estado, ID_Paciente, ID_Medico) VALUES
-- Pasadas y ATENDIDAS (tendrán receta)  -> ID 1 a 5
(DATEADD(HOUR,  8, DATEADD(DAY, -10, @Hoy)), 'Atendida', 1, 1),
(DATEADD(HOUR,  9, DATEADD(DAY, -8,  @Hoy)), 'Atendida', 5, 2),
(DATEADD(HOUR, 10, DATEADD(DAY, -7,  @Hoy)), 'Atendida', 4, 3),
(DATEADD(HOUR, 14, DATEADD(DAY, -5,  @Hoy)), 'Atendida', 3, 4),
(DATEADD(HOUR, 15, DATEADD(DAY, -3,  @Hoy)), 'Atendida', 7, 5),
-- Pasadas y CANCELADAS                  -> ID 6 a 7
(DATEADD(HOUR, 11, DATEADD(DAY, -6,  @Hoy)), 'Cancelada', 2, 1),
(DATEADD(HOUR, 13, DATEADD(DAY, -2,  @Hoy)), 'Cancelada', 6, 6),
-- HOY, pendientes (para demostrar "Atender" y "Emitir receta") -> ID 8 a 11
(DATEADD(HOUR,  8, @Hoy), 'Pendiente', 2, 1),
(DATEADD(HOUR,  9, @Hoy), 'Pendiente', 6, 1),
(DATEADD(HOUR, 10, @Hoy), 'Pendiente', 8, 3),
(DATEADD(HOUR, 14, @Hoy), 'Pendiente', 5, 2),
-- FUTURAS, pendientes                   -> ID 12 a 15
(DATEADD(HOUR,  9, DATEADD(DAY, 1, @Hoy)), 'Pendiente', 1, 6),
(DATEADD(HOUR, 11, DATEADD(DAY, 2, @Hoy)), 'Pendiente', 3, 4),
(DATEADD(HOUR, 15, DATEADD(DAY, 3, @Hoy)), 'Pendiente', 4, 3),
(DATEADD(HOUR, 16, DATEADD(DAY, 5, @Hoy)), 'Pendiente', 7, 5);

-- ---------------------------------------------------------------------
-- 6. Recetas (solo para citas ATENDIDAS, una por cita)
-- ---------------------------------------------------------------------
INSERT INTO Receta (Descripcion, ID_Cita) VALUES
('Acetaminofén 500 mg, 1 tableta cada 8 horas por 3 días. Abundantes líquidos.', 1),
('Suero oral pediátrico. Ibuprofeno jarabe 5 ml cada 8 horas si hay fiebre.', 2),
('Losartán 50 mg, 1 tableta diaria. Control de presión en 30 días.', 3),
('Crema de hidrocortisona 1% dos veces al día por 7 días.', 4),
('Ácido fólico 1 mg diario. Control en 4 semanas.', 5);
GO

-- ---------------------------------------------------------------------
-- Verificación rápida
-- ---------------------------------------------------------------------
SELECT 'Especialidad' AS Tabla, COUNT(*) AS Registros FROM Especialidad
UNION ALL SELECT 'Medico',   COUNT(*) FROM Medico
UNION ALL SELECT 'Paciente', COUNT(*) FROM Paciente
UNION ALL SELECT 'Usuario',  COUNT(*) FROM Usuario
UNION ALL SELECT 'Cita',     COUNT(*) FROM Cita
UNION ALL SELECT 'Receta',   COUNT(*) FROM Receta;
GO