using DesktopPruebaApp.DataBaseConfig;

namespace DesktopPruebaApp
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;


        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridProductos = new System.Windows.Forms.DataGridView();
            this.comboBoxVista = new System.Windows.Forms.ComboBox();
            this.txtTituloBusqueda = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTituloArribaComboBX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProductos
            // 
            this.dataGridProductos.AllowUserToAddRows = false;
            this.dataGridProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductos.Location = new System.Drawing.Point(13, 87);
            this.dataGridProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridProductos.Name = "dataGridProductos";
            this.dataGridProductos.RowHeadersWidth = 51;
            this.dataGridProductos.Size = new System.Drawing.Size(831, 339);
            this.dataGridProductos.TabIndex = 0;
            this.dataGridProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBoxVista
            // 
            this.comboBoxVista.FormattingEnabled = true;
            this.comboBoxVista.Location = new System.Drawing.Point(851, 87);
            this.comboBoxVista.Name = "comboBoxVista";
            this.comboBoxVista.Size = new System.Drawing.Size(204, 24);
            this.comboBoxVista.TabIndex = 1;
            this.comboBoxVista.SelectedIndexChanged += new System.EventHandler(this.comboBoxVista_SelectedIndexChanged);
            // 
            // txtTituloBusqueda
            // 
            this.txtTituloBusqueda.AutoSize = true;
            this.txtTituloBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloBusqueda.Location = new System.Drawing.Point(12, 14);
            this.txtTituloBusqueda.Name = "txtTituloBusqueda";
            this.txtTituloBusqueda.Size = new System.Drawing.Size(308, 69);
            this.txtTituloBusqueda.TabIndex = 2;
            this.txtTituloBusqueda.Text = "Productos";
            this.txtTituloBusqueda.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 73);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTituloArribaComboBX
            // 
            this.txtTituloArribaComboBX.AutoSize = true;
            this.txtTituloArribaComboBX.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloArribaComboBX.Location = new System.Drawing.Point(824, 60);
            this.txtTituloArribaComboBX.Name = "txtTituloArribaComboBX";
            this.txtTituloArribaComboBX.Size = new System.Drawing.Size(247, 23);
            this.txtTituloArribaComboBX.TabIndex = 4;
            this.txtTituloArribaComboBX.Text = "Selecciona tipo de busqueda";
            this.txtTituloArribaComboBX.Click += new System.EventHandler(this.txtTituloArribaComboBX_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtTituloArribaComboBX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTituloBusqueda);
            this.Controls.Add(this.comboBoxVista);
            this.Controls.Add(this.dataGridProductos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.DataGridView dataGridProductos;
        private System.Windows.Forms.ComboBox comboBoxVista;
        private System.Windows.Forms.Label txtTituloBusqueda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtTituloArribaComboBX;
    }
}

