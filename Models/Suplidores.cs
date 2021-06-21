using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.Models
{
    public class Suplidores
    {
        [Key]
        public int SuplidorId { get; set; }
        [Required]
        public string Nombres { get; set; } 
    }
}
