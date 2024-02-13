using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopPruebaApp.Services
{
    internal class ProductosServices
    {
        public string tituloPaginaPrincipal(string tituloDeVista) 
        {
            switch (tituloDeVista)
            {
                case "productos":
                    return "Productos";
                case "ventasPorArtículo":
                    return "Ventas por articulo";
                case "ventasGlobales":
                    return "Ventas globales";
                case "artículosMasVendidos":
                    return "Articulos más vendidos";
                case "cantidadDeProductosExistentes":
                    return "Cantidad de productos existentes";
                case "ventas":
                    return "Ventas";
            }
            return "Productos";
        }
    }
}
