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
using Tienda_de_Ropa.Clases.clases;

namespace Tienda_de_Ropa.Vistas
{
    public partial class FrmUsuarios : Form
    {
        MetodosUsuario metodosUsuarios;
        DataTable datos;
        int idTUsuarios = 0; 

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            this.MostrarUsuarios();
            this.MostrarPermisos(CbxAddUserRoll);
            this.MostrarPermisos(CbxEditUserRol);
            this.MostrarEstados(CbxAddUserState);
            this.MostrarEstados(CbxEditUserState);

        }

        private void MostrarPermisos(ComboBox CbxAddUserRoll)
        {
            List<Permiso> datos = metodosUsuarios.ObtenerPermisos();
            CbxAddUserRoll.Items.Add("Selecciona una opción");
            foreach (Permiso dato in datos)
            {
                CbxAddUserRoll.Items.Add(dato.permiso);
            }
            CbxAddUserRoll.SelectedIndex = 0;
        }

        private void MostrarEstados(ComboBox CbxAddUserState)
        {
            List<Estado> datos = metodosUsuarios.ObtenerEstados();
            CbxAddUserState.Items.Add("Selecciona una opción");
            foreach (Estado dato in datos)
            {
                CbxAddUserState.Items.Add(dato.estado + 1 + " - " + dato.Descripcion);
            }
            CbxAddUserState.SelectedIndex = 0;
        }

        public void MostrarUsuarios()
        {
            metodosUsuarios = new MetodosUsuario();
            datos = metodosUsuarios.ObtenerUsuarios();
            FormatoTablaUsuarios(datos);
        }

        private void BtnMostarAll_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
            this.datos.Reset();
            this.MostrarUsuarios();
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            string NomUsuario = TbxAddUserName.Text;
            string usuario = TbxAddUserUser.Text;
            string contrasena = TbxAddUserPassword.Text;
            int TPrmisos_idTPrmisos = CbxAddUserRoll.SelectedIndex;
            int TEstado_idTEstado = CbxAddUserState.SelectedIndex;

            Usuario nuevoUsuario = new Usuario(NomUsuario, usuario, contrasena, TPrmisos_idTPrmisos, TEstado_idTEstado);

            string resultado = metodosUsuarios.ValidarUsuario(nuevoUsuario);
            if (resultado.Equals("OK"))
            {
                resultado = metodosUsuarios.AgregarUsuarios(nuevoUsuario);
            }

            MessageBox.Show(resultado);
            LimpiarCampos();
            this.datos.Reset();
            this.MostrarUsuarios();
            nuevoUsuario = null;
        }

        private void BtnEditUser_Click(object sender, EventArgs e)
        {
            string NomUsuario = TbxEditUserName.Text;
            string usuario = TbxEditUserUser.Text;
            string contrasena = TbxEditUserPassword.Text;
            int TPrmisos_idTPrmisos = CbxEditUserRol.SelectedIndex;
            int TEstado_idTEstado = CbxEditUserState.SelectedIndex;

            Usuario actualizarUsuario = new Usuario(NomUsuario, usuario, contrasena, TPrmisos_idTPrmisos, TEstado_idTEstado);

            string resultado = metodosUsuarios.ValidarUsuario(actualizarUsuario);
            if (resultado.Equals("OK"))
            {
                resultado = metodosUsuarios.ActualizarUsuario(idTUsuarios, actualizarUsuario);
            }

            MessageBox.Show(resultado);
            LimpiarCampos();
            this.datos.Reset();
            this.MostrarUsuarios();
            actualizarUsuario = null;
        }

        private void BtnSearchUser_Click(object sender, EventArgs e)
        {
            this.datos.Reset();
            metodosUsuarios = new MetodosUsuario();
            datos = metodosUsuarios.BuscarUsuario(TbxSearchUser.Text.Trim());
            FormatoTablaUsuarios(datos);
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            idTUsuarios = 0;

            TbxAddUserName.Text = "";
            TbxAddUserUser.Text = "";
            TbxAddUserPassword.Text = "";
            TbxSearchUser.Text = "";
            CbxAddUserRoll.SelectedIndex = 0;
            CbxAddUserState.SelectedIndex = 0;

            TbxEditUserName.Text = "";
            TbxEditUserUser.Text = "";
            TbxEditUserPassword.Text = "";
            CbxEditUserRol.SelectedIndex = 0;
            CbxEditUserState.SelectedIndex = 0;
        }

        public void FormatoTablaUsuarios(DataTable datos)
        {
            try
            {
                datos.Columns["idTUsuarios"].ColumnName = "ID";
                datos.Columns["NomUsuario"].ColumnName = "NOMBRE";
                datos.Columns["usuario"].ColumnName = "USUARIO";
                datos.Columns["contrasena"].ColumnName = "CONTRASEÑA";
                datos.Columns["TPrmisos_idTPrmisos"].ColumnName = "PERMISO";
                datos.Columns["TEstado_idTEstado"].ColumnName = "ESTADO";

                DbgUsersTable.DataSource = datos;
                DbgUsersTable.Columns["ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DbgUsersTable.Columns["NOMBRE"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DbgUsersTable.Columns["USUARIO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DbgUsersTable.Columns["CONTRASEÑA"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DbgUsersTable.Columns["PERMISO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DbgUsersTable.Columns["ESTADO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                TbxTotalUsers.Text = "Total de usuarios: " + datos.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DbgUsersTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                LimpiarCampos();
            }
            else
            {
                idTUsuarios = Convert.ToInt32(DbgUsersTable.Rows[e.RowIndex].Cells["ID"].Value.ToString().Trim());
                TbxEditUserName.Text = DbgUsersTable.Rows[e.RowIndex].Cells["NOMBRE"].Value.ToString().Trim();
                TbxEditUserUser.Text = DbgUsersTable.Rows[e.RowIndex].Cells["USUARIO"].Value.ToString().Trim();
                TbxEditUserPassword.Text = DbgUsersTable.Rows[e.RowIndex].Cells["CONTRASEÑA"].Value.ToString().Trim();
                CbxEditUserRol.SelectedIndex = Convert.ToInt32(DbgUsersTable.Rows[e.RowIndex].Cells["PERMISO"].Value.ToString().Trim());
                CbxEditUserState.SelectedIndex = Convert.ToInt32(DbgUsersTable.Rows[e.RowIndex].Cells["ESTADO"].Value.ToString().Trim());
            }
        }
    }
}
