using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda_de_Ropa.Clases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Tienda_de_Ropa.Vistas
{
    public partial class FrmProductos : Form
    {
        MetodosProductos metodosProductos;
        DataTable datos;

        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            this.MostrarProductos();
            this.MostrarProveedores(CbxAddIdProvider);
            this.MostrarProveedores(CbxEditIdProvider);
        }

        public void MostrarProductos()
        {
            metodosProductos = new MetodosProductos();
            datos = metodosProductos.ObtenerProductos();
            FormatoTablaProductos(datos);
        }

        public void FormatoTablaProductos(DataTable datos)
        {
            try
            {
                datos.Columns["idTProducto"].ColumnName = "ID";
                datos.Columns["NomProducto"].ColumnName = "PRODUCTO";
                datos.Columns["TProveedor_idTProveedor"].ColumnName = "ID PROVEEDOR";
                datos.Columns["NomProveedor"].ColumnName = "PROVEEDOR";
                datos.Columns["Descripcion"].ColumnName = "DESCRIPCION";
                datos.Columns["Stock"].ColumnName = "STOCK";
                datos.Columns["Precio"].ColumnName = "PRECIO";

                DvgProducts.DataSource = datos;
                DvgProducts.Columns["ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DvgProducts.Columns["PRODUCTO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DvgProducts.Columns["ID PROVEEDOR"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DvgProducts.Columns["PROVEEDOR"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DvgProducts.Columns["DESCRIPCION"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DvgProducts.Columns["STOCK"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DvgProducts.Columns["PRECIO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //lblTotalProducts.Text = "Total de productos: " + datos.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MostrarProveedores(ComboBox CbxAddIdProvider)
        {
            List<Proveedor> datos = metodosProductos.ObtenerProveedores();
            CbxAddIdProvider.Items.Add("Selecciona una opción");
            foreach (Proveedor dato in datos)
            {
                CbxAddIdProvider.Items.Add(dato.idTProveedor + "," + dato.NomProveedor);
            }
            CbxAddIdProvider.SelectedIndex = 0;
        }

        private void BtnAddProducts_Click(object sender, EventArgs e)
        {
            string idTProducto = TbxAddIdProducts.Text.Trim();
            string NomProducto = TbxAddNameProducts.Text.Trim();
            string Stock = TbxAddStockProducts.Text.Trim();
            string Precio = TbxAddPriceProducts.Text.Trim();
            string Descripcion = RtbAddDescriptionProducts.Text.Trim();

            string cadena = CbxAddIdProvider.SelectedItem.ToString();

            if (CbxAddIdProvider.SelectedIndex == 0)
            {
                MessageBox.Show("TIENES QUE SELECCIONAR UN PROVEEDOR");
            }
            else
            {
                string[] valores = cadena.Split(',');
                string TProveedor_idTProveedor = valores[0].Trim();

                Producto nuevoProducto = new Producto(idTProducto, NomProducto, Stock, Precio, Descripcion, TProveedor_idTProveedor);

                string resultado = metodosProductos.ValidarProducto(nuevoProducto);

                if (resultado.Equals("OK"))
                {
                    resultado = metodosProductos.AgregarProducto(nuevoProducto);
                }

                MessageBox.Show(resultado);
                LimpiarCampos();
                this.datos.Reset();
                this.MostrarProductos();
                nuevoProducto = null;
            }
        }

        private void BtnEditProducts_Click(object sender, EventArgs e)
        {
            string idTProducto = TbxEditIdProducts.Text.Trim();
            string NomProducto = TbxEditNameProducts.Text.Trim();
            string Stock = TbxEditStockProducts.Text.Trim();
            string Precio = TbxEditPriceProducts.Text.Trim();
            string Descripcion = RtbEditDescriptionProducts.Text.Trim();
            string cadena = CbxEditIdProvider.SelectedItem.ToString();

            if (CbxEditIdProvider.SelectedIndex == 0)
            {
                MessageBox.Show("TIENES QUE SELECCIONAR UN PROVEEDOR");
            }
            else
            {
                string[] valores = cadena.Split(',');
                string TProveedor_idTProveedor = valores[0].Trim();

                Producto actualizarProducto = new Producto(idTProducto, NomProducto, Stock, Precio, Descripcion, TProveedor_idTProveedor);
                string resultado = metodosProductos.ValidarProducto(actualizarProducto);
                if (resultado.Equals("OK"))
                {
                    resultado = metodosProductos.ActualizarProducto(actualizarProducto);
                }

                MessageBox.Show(resultado);
                LimpiarCampos();
                this.datos.Reset();
                this.MostrarProductos();
                actualizarProducto = null;
            }
        }

        private void BtnSearchProducts_Click(object sender, EventArgs e)
        {
            this.datos.Reset();
            metodosProductos = new MetodosProductos();
            datos = metodosProductos.BuscarProductos(TbxSearchProducts.Text.Trim());
            FormatoTablaProductos(datos);
            LimpiarCampos();
        }

        private void BtnMostrarAll_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
            this.datos.Reset();
            this.MostrarProductos();
        }

        private void LimpiarCampos()
        {
            TbxAddIdProducts.Text = "";
            TbxAddNameProducts.Text = "";
            TbxAddStockProducts.Text = "";
            TbxAddPriceProducts.Text = "";
            RtbAddDescriptionProducts.Text = "";
            CbxAddIdProvider.SelectedIndex = 0;

            TbxEditIdProducts.Text = "";
            TbxEditNameProducts.Text = "";
            TbxEditStockProducts.Text = "";
            TbxEditPriceProducts.Text = "";
            RtbEditDescriptionProducts.Text = "";
            CbxEditIdProvider.SelectedIndex = 0;
        }

        private void NumValidate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void DvgProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                LimpiarCampos();
            }
            else
            {
                TbxEditIdProducts.Text = DvgProducts.Rows[e.RowIndex].Cells["ID"].Value.ToString().Trim();
                TbxEditNameProducts.Text = DvgProducts.Rows[e.RowIndex].Cells["PRODUCTO"].Value.ToString().Trim();
                TbxEditStockProducts.Text = DvgProducts.Rows[e.RowIndex].Cells["STOCK"].Value.ToString().Trim();
                TbxEditPriceProducts.Text = DvgProducts.Rows[e.RowIndex].Cells["PRECIO"].Value.ToString().Trim();
                RtbEditDescriptionProducts.Text = DvgProducts.Rows[e.RowIndex].Cells["DESCRIPCION"].Value.ToString().Trim();
                CbxEditIdProvider.SelectedIndex = Convert.ToInt32(DvgProducts.Rows[e.RowIndex].Cells["ID PROVEEDOR"].Value.ToString().Trim());

            }
        }
    }
}
