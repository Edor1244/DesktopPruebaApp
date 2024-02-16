using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopPruebaApp.Models;
using MySql.Data.MySqlClient;

namespace DesktopPruebaApp.DataBaseConfig
{
    internal class DataBaseContext
    {
        public MySql.Data.MySqlClient.MySqlConnection ConexionBaseDatos() {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "server=127.0.0.1;uid=root;" + "database=iroxIT";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                return conn;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public void Close()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "server={PONERNOMBRESERVIDOR};uid=root;" + "database=iroxIT";
            conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
            conn.Close();
        }

        public DataTable ObtenerProductos(String vistaDataGrid)
        {
            string scriptSQL = obtenerScriptDeVista(vistaDataGrid);
            DataTable obtenerProductos = new DataTable();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = ConexionBaseDatos();
            cmd.CommandText = scriptSQL;
            using (var reader = cmd.ExecuteReader())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    obtenerProductos.Columns.Add(reader.GetName(i), reader.GetFieldType(i));
                }

                while (reader.Read())
                {
                    DataRow fila = obtenerProductos.NewRow();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        fila[i] = reader.GetValue(i);
                    }
                    obtenerProductos.Rows.Add(fila);
                }
            }

            return obtenerProductos;
        }

        private String obtenerScriptDeVista(string scriptSQL)
        {
            switch (scriptSQL)
            {
                case "productos":
                    return $"select * from Productos";
                case "ventasPorArtículo":
                    return "SELECT p.Titulo, COUNT(v.IDVentas) as TotalVentas " +
                                               "FROM Ventas v " +
                                               "JOIN Productos p ON v.IDProductos = p.IDProductos " +
                                               "GROUP BY p.Titulo;";
                case "ventasGlobales":
                    return "SELECT COUNT(IDVentas) as TotalVentas FROM Ventas;";
                case "artículosMasVendidos":
                    return "SELECT p.Titulo, SUM(v.CantidadVendida) as TotalVentas " +
                                               "FROM Ventas v " +
                                               "JOIN Productos p ON v.IDProductos = p.IDProductos " +
                                               "GROUP BY p.Titulo " +
                                               "ORDER BY TotalVentas DESC;";
                case "cantidadDeProductosExistentes":
                    return "SELECT Titulo FROM Productos;";
                case "ventas":
                    return $"select * from Ventas";
            }
            return $"select * from Productos";
        }
        public void NotificarCompraProveedor()
        {
            DataTable productosFaltantes = new DataTable();

            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Productos WHERE Existencias < 100;", ConexionBaseDatos()))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(productosFaltantes);
                }
            }

            if (productosFaltantes.Rows.Count > 0)
            {
                string productosFaltantesTitulos = String.Join("\n", productosFaltantes.AsEnumerable().Select(row => row["Titulo"].ToString()));
                string mensaje = $"Productos que necesitan reabastecimiento:\n\n{productosFaltantesTitulos}";
                MessageBox.Show(mensaje);
            }
        }



    }
}
