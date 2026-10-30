# Sistema de Gestión de Citas Médicas

![El Salvador](https://img.shields.io/badge/Country-El%20Salvador-0047AB?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-.NET-239120?style=for-the-badge&logo=csharp&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)
![Git](https://img.shields.io/badge/Git-F05032?style=for-the-badge&logo=git&logoColor=white)

Aplicación de escritorio desarrollada en **C# con Windows Forms** y **arquitectura en capas**, diseñada para automatizar y optimizar la administración de una clínica u hospital. Permite gestionar de forma centralizada y segura pacientes, médicos, especialidades, citas médicas y la emisión de recetas electrónicas, con control de acceso basado en roles.

El sistema incluye:

- Inicio de sesión con validación de roles (Administrador, Médico y Paciente).
- Gestión de pacientes, médicos y especialidades.
- Agendamiento de citas con validación de disponibilidad.
- Emisión y modificación de recetas médicas.
- Panel estadístico con gráficos para el administrador.

---

# Características

- Arquitectura en capas: Presentación (UI), Lógica (Entidades) y Datos (DAL).
- Autenticación con roles de usuario y sesión activa mediante la clase `SesionUsuario`.
- Menú principal dinámico que muestra u oculta módulos según el rol.
- Prevención de cruce de horarios para médicos y pacientes.
- Bloqueo automático de citas en fechas u horas pasadas.
- Historial clínico de citas consultable por paciente.
- Módulo exclusivo para médicos para registrar o modificar recetas.
- Dashboard con contadores en tiempo real y gráficos nativos.
- Seguridad contra inyección SQL mediante comandos parametrizados.
- Manejo de transacciones SQL (`Commit` / `Rollback`).

---

# Tecnologías utilizadas

### Lenguaje y entorno

- C# (.NET Framework)
- Windows Forms (UI)

### Base de datos

- Microsoft SQL Server
- SQL Server Management Studio (SSMS)
- ADO.NET (comandos parametrizados y transacciones)

### Control de versiones

- Git y GitHub

---

# Arquitectura del software

El proyecto sigue una arquitectura en capas que favorece el desacoplamiento, el mantenimiento y la escalabilidad del código.

### Capa de Presentación (UI)

Formularios de Windows Forms que interactúan con el usuario y aplican validaciones visuales:

- `FrmLogin`
- `FrmMenuPrincipal`
- `FrmGestionPacientes`
- `FrmGestionMedicos`
- `FrmAgendarCitas`
- `FrmConsultarCitas`
- `FrmConsultarRecetas`
- `FrmResumen`

### Capa de Lógica (Entidades)

Clases que encapsulan las reglas de negocio y las propiedades de los objetos:

- `Cita`, `Receta`, `Paciente`, `Medico`, `Especialidad`, `Usuario`
- `SesionUsuario` (clase estática que guarda la sesión activa)

### Capa de Datos (DAL)

Clases de acceso a datos que se comunican con SQL Server mediante ADO.NET:

- `CitaDAL`, `PacienteDAL`, `MedicoDAL`, `EspecialidadDAL`, `RecetaDAL`, `UsuarioDAL`

---

# Roles y permisos

| Rol | Permisos |
|---|---|
| **Administrador** | Control total del sistema: gestión de médicos, pacientes, especialidades y usuarios; acceso exclusivo al panel de resumen estadístico con gráficos. |
| **Médico** | Consulta de su propia agenda, atención de citas y emisión o modificación de recetas médicas. |
| **Paciente** | Registro en la plataforma, agendamiento de citas por especialidad y médico disponible, y consulta de su historial personal. |

---

# Funcionalidades disponibles

### Autenticación

- Inicio de sesión con usuario y contraseña.
- Validación de credenciales y almacenamiento de la sesión activa.
- Permisos ajustados dinámicamente según el rol.

### Módulo de citas

- Agendamiento por especialidad y médico disponible.
- **Validación de fechas pasadas:** `CitaDAL.AgendarCita` rechaza fechas u horas anteriores a `DateTime.Now`.
- **Prevención de cruce de horarios (`ExisteChoqueHorario`):** evita sobreasignar a un médico y bloquea que un paciente reserve dos citas a la misma hora.
- Estados de cita: *Pendiente*, *Atendida* y *Cancelada*.

### Módulo de recetas

- Consulta de citas atendidas.
- Emisión y modificación de recetas mediante transacciones (`SqlTransaction`).
- Exportación a `.txt` con datos del paciente, médico tratante, especialidad, fecha e indicaciones.

### Dashboard estadístico (Administrador)

- Contadores en tiempo real: pacientes registrados, médicos, citas totales y recetas emitidas.
- Gráfico de barras nativo (`Chart`) con paleta corporativa.

---

# Diseño

La interfaz tiene una línea clínica y profesional, pensada para ser clara y adaptable:

- Paleta de tonos azules: `RGB(0, 52, 99)` y `RGB(41, 112, 190)`.
- Tablas responsivas con `AutoSizeColumnsMode = Fill` para evitar cortes visuales.
- Menús y módulos que cambian según el rol del usuario.

---

# Base de datos

El sistema se conecta a una base de datos relacional en SQL Server llamada `GestionCitasMedicas`, con llaves foráneas y restricciones de integridad (`CHECK`, `UNIQUE`).

| Tabla | Descripción |
|---|---|
| **Especialidad** | Catálogo de áreas médicas. |
| **Medico** | Personal de salud vinculado a una especialidad. |
| **Paciente** | Datos personales y demográficos de los pacientes. |
| **Usuario** | Credenciales de acceso, rol (Administrador, Medico, Paciente) y llaves hacia Paciente o Médico. |
| **Cita** | Fecha, hora, estado (*Pendiente*, *Atendida*, *Cancelada*) y relaciones con paciente y médico. |
| **Receta** | Indicaciones médicas vinculadas de forma única a una cita atendida (`CONSTRAINT U_idCita UNIQUE`). |

---

# Buenas prácticas aplicadas

- **Seguridad contra inyección SQL:** uso de parámetros en todos los comandos (`cmd.Parameters.AddWithValue`).
- **Transacciones:** `SqlTransaction` en operaciones complejas, como crear un Paciente junto con su cuenta de Usuario, para garantizar consistencia.
- **Encapsulamiento:** entidades con propiedades y comportamiento bien definidos.
- **Separación de responsabilidades:** UI, lógica y acceso a datos independientes.

---

# Ejecutar el proyecto

### Requisitos previos

- Visual Studio (con soporte para desarrollo de escritorio en C# / .NET).
- Microsoft SQL Server.
- SQL Server Management Studio (SSMS).

### Pasos

1. Clonar el repositorio:
2. Abrir SQL Server Management Studio.
3. Ejecutar el script `GestionCitasMedicas.sql` y luego el script de datos de prueba incluido en el proyecto.
4. Verificar la cadena de conexión en la clase de configuración de la base de datos para que apunte a tu servidor local.
5. Abrir la solución (`.sln`) en Visual Studio.
6. Compilar la solución con `Ctrl + Shift + B` para restaurar dependencias.
7. Ejecutar la aplicación con `F5` (Iniciar / Start).

---


# Aviso

Este proyecto fue desarrollado con fines académicos. Los datos incluidos son de prueba y no deben usarse con información médica real.
