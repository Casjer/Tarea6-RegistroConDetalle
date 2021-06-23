using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.Models
{
    public class OrdenesDetalle
    {
        [Key]
        public int Id { get; set; } 
        public int OrdenId { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Costo { get; set; }

        public int ProductoId { get; set; }
        public Productos Productos { get; set; }

    }
}
