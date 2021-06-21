using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        [Required]
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        [Range(minimum: 1, maximum: 10000000)]
        public decimal Inventario { get; set; } 
    }
}
