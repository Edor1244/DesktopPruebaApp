using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopPruebaApp.Models
{
    public class ProductoModel
    {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int IDProductos { get; set; }

            public string Titulo { get; set; }
            public string Descripcion { get; set; }
            public decimal PrecioUnitario { get; set; }
            public int Existencias { get; set; }

            // Relación con la tabla "Ventas"
            public virtual ICollection<VentasModel> Ventas { get; set; }
    }
}
