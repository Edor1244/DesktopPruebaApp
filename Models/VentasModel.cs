using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesktopPruebaApp.Models.ProductoModel;

namespace DesktopPruebaApp.Models
{
    public class VentasModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDVentas { get; set; }

        public int IDProductos { get; set; }

        public int CantidadVendida { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [ForeignKey("IDProductos")]
        public virtual ProductoModel Producto { get; set; }
    }
}
