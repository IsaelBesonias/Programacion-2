using Mapa_de_clases.Entities;

var miembrocomunidad = new MiembroComunidad("Carlos", "Ramírez", "Servidor Publico");
miembrocomunidad.MostrarInformacion();

var empleado = new Empleado("Luis","Perez", "Abogado" );
empleado.MostrarInformacion();

var estudiante = new Estudiante("Juan", "Lopez", "Desarrollo de software");
estudiante.MostrarInformacion();

var exalumno = new ExAlumno("Manuel", "Pereira", "Taxista");
exalumno.MostrarInformacion();

var docente = new Docente("Rafael", "Santana", "Profesor de sociales");
docente.MostrarInformacion();

var administrativo = new Administrativo("Brander", "Baez", "Funcionario");
administrativo.MostrarInformacion();

var administrador = new Administrador("David", "Baez", "Administrador de edesur");
administrador.MostrarInformacion();

var maestro = new Maestro("Bruce", "Lee", "Maestro en las artes marciales");
maestro.MostrarInformacion();