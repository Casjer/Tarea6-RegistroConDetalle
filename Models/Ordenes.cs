using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.Models
{
    public class Ordenes
    {

        [Key]
        public int OrdenId { get; set; } 
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "Debe debe agreglar un suplidor obligatorio.")]
        public int SuplidorId { get; set; }
        public Suplidores Suplidores { get; set; }

        public decimal Monto { get; set; }

        [ForeignKey("OrdenId")]
        public virtual List<OrdenesDetalle> OrdenesDetalle { get; set; }

        public Ordenes()
        {
            Fecha = DateTime.Now;
            OrdenesDetalle = new List<OrdenesDetalle>();
        }
    }
}
