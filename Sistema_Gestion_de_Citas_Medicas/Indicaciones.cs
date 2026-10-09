/* 
==================================================================================
 Guia de uso (FrmLogin.cs)
==================================================================================
 Para autenticar al usuario al presionar "Iniciar Sesión":

    UsuarioDAL usuarioDAL = new UsuarioDAL();
    Usuario usuarioLogueado = usuarioDAL.ValidarLogin(txtUsuario.Text.Trim(), txtContraseña.Text.Trim());

    if (usuarioLogueado != null)
    {
        // 1. Guardar la sesión en la clase estática de Ana
        SesionUsuario.IdUsuario = usuarioLogueado.IdUsuario;
        SesionUsuario.Username = usuarioLogueado.Username;
        SesionUsuario.Rol = usuarioLogueado.Rol;

        if (usuarioLogueado is Paciente p)
            SesionUsuario.IdPaciente = p.IdPaciente;
        else if (usuarioLogueado is Medico m)
            SesionUsuario.IdMedico = m.IdMedico;

        // 2. Abrir Menú Principal
        FrmMenuPrincipal menu = new FrmMenuPrincipal();
        menu.Show();
        this.Hide();
    }
    else
    {
        MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
==================================================================================
*/



/* 
==================================================================================
 Guia para (FrmRegistro.cs y FrmGestionPacientes.cs)
==================================================================================
 A. Para registrar un nuevo Paciente desde FrmRegistro.cs:

    Paciente nuevoPaciente = new Paciente
    {
        Nombre = txtNombre.Text.Trim(),
        Apellido = txtApellido.Text.Trim(),
        FechaNacimiento = dtpFechaNacimiento.Value,
        Telefono = txtTelefono.Text.Trim(),
        Correo = txtCorreo.Text.Trim()
    };

    PacienteDAL dal = new PacienteDAL();
    bool registroExitoso = dal.RegistrarPaciente(nuevoPaciente, txtUsername.Text.Trim(), txtPassword.Text.Trim());

 B. Para cargar la lista de pacientes en un DataGridView (FrmGestionPacientes.cs):

    PacienteDAL dal = new PacienteDAL();
    dgvPacientes.DataSource = dal.ListarPacientes();
==================================================================================
*/

/* 
==================================================================================
 Guia para (FrmAgendarCitas.cs)
==================================================================================
 A. Para agendar una nueva cita (Valida automáticamente choque de horarios):

    try
    {
        Cita nuevaCita = new Cita
        {
            FechaHora = dtpFechaHora.Value,
            IdPaciente = Convert.ToInt32(cmbPaciente.SelectedValue),
            IdMedico = Convert.ToInt32(cmbMedico.SelectedValue)
        };

        CitaDAL dal = new CitaDAL();
        if (dal.AgendarCita(nuevaCita))
        {
            MessageBox.Show("Cita agendada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    catch (Exception ex)
    {
        // Muestra error de choque de horario o fallo en SQL Server
        MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

 B. Para consultar la lista de citas filtrada:

    CitaDAL dal = new CitaDAL();
    // Si eres Paciente pasa SesionUsuario.IdPaciente, si eres Medico pasa SesionUsuario.IdMedico:
    dgvCitas.DataSource = dal.ListarCitas(SesionUsuario.IdPaciente, null);
==================================================================================
*/

/* 
==================================================================================
 Guia para (FrmEmitirRecetas.cs)
==================================================================================
 Para emitir una receta y cambiar automáticamente la Cita a 'Atendida':

    try
    {
        Receta receta = new Receta
        {
            Descripcion = txtIndicaciones.Text.Trim(),
            IdCita = Convert.ToInt32(dgvCitasPendientes.CurrentRow.Cells["ID_Cita"].Value)
        };

        RecetaDAL dal = new RecetaDAL();
        if (dal.EmitirReceta(receta))
        {
            MessageBox.Show("Receta emitida y cita finalizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message, "Error al emitir receta", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
==================================================================================
*/