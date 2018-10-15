using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaWindowsForms.Models
{
    public class VentaDetalle
    {
        public int VentaId { get; set; }
        public int ProductoId { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public double Precio { get; set; }
    }
}
