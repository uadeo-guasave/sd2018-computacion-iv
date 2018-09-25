using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaUADEO.Entidades
{
    public class Usuario
    {
        public string Id { get; private set; }
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Contraseña { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string NombreCompleto {
            get => $"{Nombres} {Apellidos}";
            // get { return $"{Nombres} {Apellidos}"; }
        }

        public Usuario()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
