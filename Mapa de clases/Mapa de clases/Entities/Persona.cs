using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Mapa_de_clases.Entities;

namespace Mapa_de_clases.Entities
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Ocupacion { get; set; }

        public Persona(string nombre, string apellido, string ocupacion) {
            Nombre = nombre;
            Apellido = apellido;
            Ocupacion = ocupacion;
        }
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre} {Apellido}, Ocupación: {Ocupacion}");
        }

    }
}

public class MiembroComunidad : Persona
{
    public MiembroComunidad(string nombre, string apellido, string ocupacion) : base(nombre, apellido, ocupacion)
    {

    }
}

public class Empleado : Persona
{
    public Empleado(string nombre, string apellido, string ocupacion) : base(nombre, apellido, ocupacion)
    {
    }
}

public class Estudiante : Persona
{
    public Estudiante(string nombre, string apellido, string ocupacion) : base(nombre, apellido, ocupacion)
    {
    }
}

public class ExAlumno : Persona
{
    public ExAlumno(string nombre, string apellido, string ocupacion) : base(nombre, apellido, ocupacion)
    {
    }
}

public class Docente : Persona
{
    public Docente(string nombre, string apellido, string ocupacion) : base(nombre, apellido, ocupacion)
    {
    }
}

public class Administrativo : Persona
{
    public Administrativo(string nombre, string apellido, string ocupacion) : base(nombre, apellido, ocupacion)
    {
    }
}

public class Administrador : Persona
{
    public Administrador(string nombre, string apellido, string ocupacion) : base(nombre, apellido, ocupacion)
    {
    }
}

public class Maestro : Persona
{
    public Maestro(string nombre, string apellido, string ocupacion) : base(nombre, apellido, ocupacion)
    {
    }
}
