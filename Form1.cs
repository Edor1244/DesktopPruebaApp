using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopPruebaApp.DataBaseConfig;
using MySql.Data.MySqlClient;
using DesktopPruebaApp.Models;
using DesktopPruebaApp.Services;

namespace DesktopPruebaApp
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            Form1_Load();
        }
 

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxVista_SelectedIndexChanged(object sender, EventArgs e)
        {
            //se mandan llamar las funciones para Obtener Productos dependiendo de la opcion seleccionada al igual que el Titulo.
            string vistaSeleccionada = comboBoxVista.SelectedItem.ToString();
            DataTable Productos = new DataBaseContext().ObtenerProductos(vistaSeleccionada);
            dataGridProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridProductos.DataSource = Productos;
            txtTituloBusqueda.Text = new ProductosServices().tituloPaginaPrincipal(vistaSeleccionada);

        }
        private void Form1_Load()
        {
            
            // Llenar el ComboBox con las opciones de vista
            comboBoxVista.Items.Add("productos");
            comboBoxVista.Items.Add("ventas");
            comboBoxVista.Items.Add("ventasPorArtículo");
            comboBoxVista.Items.Add("ventasGlobales");
            comboBoxVista.Items.Add("artículosMasVendidos");
            comboBoxVista.Items.Add("cantidadDeProductosExistentes");

            // Establecer la opción predeterminada
            comboBoxVista.SelectedIndex = 0;

            // Llamar a la función inicial para cargar datos
            comboBoxVista_SelectedIndexChanged( null, null);
            new DataBaseContext().NotificarCompraProveedor();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTituloArribaComboBX_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}
