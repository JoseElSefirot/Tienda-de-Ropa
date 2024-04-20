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

namespace Tienda_de_Ropa.Vistas
{
    public partial class FrmProveedores : Form
    {
        MetodosProveedores metodosProveedores;
        DataTable datos;
        int idTProveedor = 0;

        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            this.MostrarProveedores();
        }
        
        public void MostrarProveedores()
        {
            metodosProveedores = new MetodosProveedores();
            datos = metodosProveedores.ObtenerProveedores();
            FormatoTablaProveedores(datos);
        }

        private void BtnAddProvider_Click(object sender, EventArgs e)
        {
            string NomProveedor = TbxAddProviderName.Text;
            string NumContacto = TbxAddProviderTel.Text;
            string Direccion = RtbAddProviderDirecctio.Text;
            string Email = TbxAddProviderEmail.Text;

            Proveedor nuevoProveedor = new Proveedor(NomProveedor, NumContacto, Direccion, Email);
            
            string resultado = metodosProveedores.AgregarProveedor(nuevoProveedor);
            if (resultado.Equals("OK"))
            {
                resultado = metodosProveedores.AgregarProveedor(nuevoProveedor);
            }

            MessageBox.Show(resultado);
            LimpiarCampos();
            this.datos.Reset();
            this.MostrarProveedores();
            nuevoProveedor = null;

        }

        private void BtnSearchProvider_Click(object sender, EventArgs e)
        {
            this.datos.Reset();
            metodosProveedores = new MetodosProveedores();
            datos = metodosProveedores.BuscarProveedor(TbxSearchProvider.Text.Trim());
            FormatoTablaProveedores(datos);
            LimpiarCampos();
        }

        private void BtnMostarAllProvider_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
            this.datos.Reset();
            this.MostrarProveedores();
        }

        private void BtnEditProvider_Click(object sender, EventArgs e)
        {
            string NomProveedor = TbxEditProviderName.Text;
            string NumContacto = TbxEditProviderTel.Text;
            string Direccion = RtbEditProviderDirection.Text;
            string Email = TbxEditProviderEmail.Text;

            Proveedor actualizarProveedor = new Proveedor(NomProveedor, NumContacto, Direccion, Email);

            string resultado = metodosProveedores.ValidarProveedor(actualizarProveedor);

            if (resultado.Equals("OK"))
            {
                resultado = metodosProveedores.ActualizarProveedor(idTProveedor, actualizarProveedor);
            }

            MessageBox.Show(resultado);
            LimpiarCampos();
            this.datos.Reset();
            this.MostrarProveedores();
            actualizarProveedor = null;
        }
    
        public void FormatoTablaProveedores(DataTable datos)
        {

            try
            {
                datos.Columns["idTProveedor"].ColumnName = "ID";
                datos.Columns["NomProveedor"].ColumnName = "PROVEEDOR";
                datos.Columns["NumContacto"].ColumnName = "NUMERO CONTACTO";
                datos.Columns["Direccion"].ColumnName = "DIRECCION";
                datos.Columns["Email"].ColumnName = "EMAIL";

                DbgProviderTable.DataSource = datos;
                DbgProviderTable.Columns["ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DbgProviderTable.Columns["PROVEEDOR"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DbgProviderTable.Columns["NUMERO CONTACTO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DbgProviderTable.Columns["DIRECCION"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DbgProviderTable.Columns["EMAIL"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LimpiarCampos()
        {
            idTProveedor = 0;

            TbxAddProviderName.Text = "";
            TbxAddProviderTel.Text  = "";
            TbxAddProviderEmail.Text = "";
            RtbAddProviderDirecctio.Text = "";

            TbxEditProviderName.Text = "";
            TbxEditProviderTel.Text = "";
            TbxEditProviderEmail.Text = "";
            RtbEditProviderDirection.Text = "";
        }

        private void TbxProviderTel_KeyPress(object sender, KeyPressEventArgs e)
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

        private void DbgProviderTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                LimpiarCampos();
            }
            else
            {
                idTProveedor = Convert.ToInt32(DbgProviderTable.Rows[e.RowIndex].Cells["ID"].Value.ToString().Trim());
                TbxEditProviderName.Text = DbgProviderTable.Rows[e.RowIndex].Cells["PROVEEDOR"].Value.ToString().Trim();
                TbxEditProviderTel.Text = DbgProviderTable.Rows[e.RowIndex].Cells["NUMERO CONTACTO"].Value.ToString().Trim();
                RtbEditProviderDirection.Text = DbgProviderTable.Rows[e.RowIndex].Cells["DIRECCION"].Value.ToString().Trim();
                TbxEditProviderEmail.Text = DbgProviderTable.Rows[e.RowIndex].Cells["EMAIL"].Value.ToString().Trim();
            }
        }


    }
}
