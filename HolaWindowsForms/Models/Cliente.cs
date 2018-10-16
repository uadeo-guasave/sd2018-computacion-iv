using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaWindowsForms.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Nombre { get; set; }

        [Required, MaxLength(50)]
        public string Apellidos { get; set; }

        [Required, MaxLength(500)]
        public string Domicilio { get; set; }

        public List<Venta> Ventas { get; set; }
    }
}
