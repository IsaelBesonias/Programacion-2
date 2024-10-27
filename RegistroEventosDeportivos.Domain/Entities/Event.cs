using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Entidades/Event.cs
namespace RegistroEventosDeportivos.Domain.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }

        public List<Athlete> Athletes { get; set; } = new List<Athlete>();
    }
}

// Entidades/Athlete.cs
namespace RegistroEventosDeportivos.Domain.Entities
{
    public class Athlete
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sport { get; set; }
    }
}
