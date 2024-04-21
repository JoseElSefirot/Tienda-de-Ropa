namespace Tienda_de_Ropa.Vistas
{
    partial class FrmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbActProducto = new System.Windows.Forms.GroupBox();
            this.TbxEditPriceProducts = new System.Windows.Forms.TextBox();
            this.txtActIdProveedor = new System.Windows.Forms.Label();
            this.RtbEditDescriptionProducts = new System.Windows.Forms.TextBox();
            this.TbxEditStockProducts = new System.Windows.Forms.TextBox();
            this.TbxEditNameProducts = new System.Windows.Forms.TextBox();
            this.BtnEditProducts = new System.Windows.Forms.Button();
            this.TbxEditIdProducts = new System.Windows.Forms.TextBox();
            this.CbxEditIdProvider = new System.Windows.Forms.ComboBox();
            this.txtActDescripcion = new System.Windows.Forms.Label();
            this.txtActPrecio = new System.Windows.Forms.Label();
            this.txtActIdProducto = new System.Windows.Forms.Label();
            this.txtActStock = new System.Windows.Forms.Label();
            this.txtActNomProducto = new System.Windows.Forms.Label();
            this.gbAddUsuario = new System.Windows.Forms.GroupBox();
            this.TbxAddPriceProducts = new System.Windows.Forms.TextBox();
            this.idProveedor = new System.Windows.Forms.Label();
            this.RtbAddDescriptionProducts = new System.Windows.Forms.TextBox();
            this.TbxAddStockProducts = new System.Windows.Forms.TextBox();
            this.TbxAddNameProducts = new System.Windows.Forms.TextBox();
            this.BtnAddProducts = new System.Windows.Forms.Button();
            this.TbxAddIdProducts = new System.Windows.Forms.TextBox();
            this.CbxAddIdProvider = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.Label();
            this.txtNomProducto = new System.Windows.Forms.Label();
            this.gbBuscarUsuario = new System.Windows.Forms.GroupBox();
            this.BtnMostrarAll = new System.Windows.Forms.Button();
            this.txtBuscarProducto = new System.Windows.Forms.Label();
            this.BtnSearchProducts = new System.Windows.Forms.Button();
            this.TbxSearchProducts = new System.Windows.Forms.TextBox();
            this.DvgProducts = new System.Windows.Forms.DataGridView();
            this.gbActProducto.SuspendLayout();
            this.gbAddUsuario.SuspendLayout();
            this.gbBuscarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // gbActProducto
            // 
            this.gbActProducto.Controls.Add(this.TbxEditPriceProducts);
            this.gbActProducto.Controls.Add(this.txtActIdProveedor);
            this.gbActProducto.Controls.Add(this.RtbEditDescriptionProducts);
            this.gbActProducto.Controls.Add(this.TbxEditStockProducts);
            this.gbActProducto.Controls.Add(this.TbxEditNameProducts);
            this.gbActProducto.Controls.Add(this.BtnEditProducts);
            this.gbActProducto.Controls.Add(this.TbxEditIdProducts);
            this.gbActProducto.Controls.Add(this.CbxEditIdProvider);
            this.gbActProducto.Controls.Add(this.txtActDescripcion);
            this.gbActProducto.Controls.Add(this.txtActPrecio);
            this.gbActProducto.Controls.Add(this.txtActIdProducto);
            this.gbActProducto.Controls.Add(this.txtActStock);
            this.gbActProducto.Controls.Add(this.txtActNomProducto);
            this.gbActProducto.Location = new System.Drawing.Point(9, 291);
            this.gbActProducto.Name = "gbActProducto";
            this.gbActProducto.Size = new System.Drawing.Size(335, 284);
            this.gbActProducto.TabIndex = 27;
            this.gbActProducto.TabStop = false;
            this.gbActProducto.Text = "EDITAR PRODUCTO";
            // 
            // TbxEditPriceProducts
            // 
            this.TbxEditPriceProducts.Location = new System.Drawing.Point(115, 101);
            this.TbxEditPriceProducts.Name = "TbxEditPriceProducts";
            this.TbxEditPriceProducts.Size = new System.Drawing.Size(202, 20);
            this.TbxEditPriceProducts.TabIndex = 22;
            this.TbxEditPriceProducts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumValidate_KeyPress);
            // 
            // txtActIdProveedor
            // 
            this.txtActIdProveedor.AutoSize = true;
            this.txtActIdProveedor.Location = new System.Drawing.Point(6, 214);
            this.txtActIdProveedor.Name = "txtActIdProveedor";
            this.txtActIdProveedor.Size = new System.Drawing.Size(92, 13);
            this.txtActIdProveedor.TabIndex = 21;
            this.txtActIdProveedor.Text = "ID PROVEEDOR:";
            // 
            // RtbEditDescriptionProducts
            // 
            this.RtbEditDescriptionProducts.Location = new System.Drawing.Point(115, 129);
            this.RtbEditDescriptionProducts.Multiline = true;
            this.RtbEditDescriptionProducts.Name = "RtbEditDescriptionProducts";
            this.RtbEditDescriptionProducts.Size = new System.Drawing.Size(202, 77);
            this.RtbEditDescriptionProducts.TabIndex = 20;
            // 
            // TbxEditStockProducts
            // 
            this.TbxEditStockProducts.Location = new System.Drawing.Point(115, 76);
            this.TbxEditStockProducts.Name = "TbxEditStockProducts";
            this.TbxEditStockProducts.Size = new System.Drawing.Size(202, 20);
            this.TbxEditStockProducts.TabIndex = 12;
            this.TbxEditStockProducts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumValidate_KeyPress);
            // 
            // TbxEditNameProducts
            // 
            this.TbxEditNameProducts.Location = new System.Drawing.Point(115, 51);
            this.TbxEditNameProducts.Name = "TbxEditNameProducts";
            this.TbxEditNameProducts.Size = new System.Drawing.Size(202, 20);
            this.TbxEditNameProducts.TabIndex = 11;
            // 
            // BtnEditProducts
            // 
            this.BtnEditProducts.Location = new System.Drawing.Point(221, 248);
            this.BtnEditProducts.Name = "BtnEditProducts";
            this.BtnEditProducts.Size = new System.Drawing.Size(94, 23);
            this.BtnEditProducts.TabIndex = 19;
            this.BtnEditProducts.Text = "ACTUALIZAR";
            this.BtnEditProducts.UseVisualStyleBackColor = true;
            this.BtnEditProducts.Click += new System.EventHandler(this.BtnEditProducts_Click);
            // 
            // TbxEditIdProducts
            // 
            this.TbxEditIdProducts.Enabled = false;
            this.TbxEditIdProducts.Location = new System.Drawing.Point(115, 24);
            this.TbxEditIdProducts.Name = "TbxEditIdProducts";
            this.TbxEditIdProducts.Size = new System.Drawing.Size(202, 20);
            this.TbxEditIdProducts.TabIndex = 10;
            // 
            // CbxEditIdProvider
            // 
            this.CbxEditIdProvider.FormattingEnabled = true;
            this.CbxEditIdProvider.Location = new System.Drawing.Point(115, 212);
            this.CbxEditIdProvider.Name = "CbxEditIdProvider";
            this.CbxEditIdProvider.Size = new System.Drawing.Size(202, 21);
            this.CbxEditIdProvider.TabIndex = 8;
            // 
            // txtActDescripcion
            // 
            this.txtActDescripcion.AutoSize = true;
            this.txtActDescripcion.Location = new System.Drawing.Point(6, 132);
            this.txtActDescripcion.Name = "txtActDescripcion";
            this.txtActDescripcion.Size = new System.Drawing.Size(83, 13);
            this.txtActDescripcion.TabIndex = 7;
            this.txtActDescripcion.Text = "DESCRIPCION:";
            // 
            // txtActPrecio
            // 
            this.txtActPrecio.AutoSize = true;
            this.txtActPrecio.Location = new System.Drawing.Point(6, 107);
            this.txtActPrecio.Name = "txtActPrecio";
            this.txtActPrecio.Size = new System.Drawing.Size(50, 13);
            this.txtActPrecio.TabIndex = 5;
            this.txtActPrecio.Text = "PRECIO:";
            // 
            // txtActIdProducto
            // 
            this.txtActIdProducto.AutoSize = true;
            this.txtActIdProducto.Location = new System.Drawing.Point(6, 27);
            this.txtActIdProducto.Name = "txtActIdProducto";
            this.txtActIdProducto.Size = new System.Drawing.Size(21, 13);
            this.txtActIdProducto.TabIndex = 2;
            this.txtActIdProducto.Text = "ID:";
            // 
            // txtActStock
            // 
            this.txtActStock.AutoSize = true;
            this.txtActStock.Location = new System.Drawing.Point(6, 79);
            this.txtActStock.Name = "txtActStock";
            this.txtActStock.Size = new System.Drawing.Size(46, 13);
            this.txtActStock.TabIndex = 4;
            this.txtActStock.Text = "STOCK:";
            this.txtActStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtActNomProducto
            // 
            this.txtActNomProducto.AutoSize = true;
            this.txtActNomProducto.Location = new System.Drawing.Point(6, 54);
            this.txtActNomProducto.Name = "txtActNomProducto";
            this.txtActNomProducto.Size = new System.Drawing.Size(71, 13);
            this.txtActNomProducto.TabIndex = 3;
            this.txtActNomProducto.Text = "PRODUCTO:";
            // 
            // gbAddUsuario
            // 
            this.gbAddUsuario.Controls.Add(this.TbxAddPriceProducts);
            this.gbAddUsuario.Controls.Add(this.idProveedor);
            this.gbAddUsuario.Controls.Add(this.RtbAddDescriptionProducts);
            this.gbAddUsuario.Controls.Add(this.TbxAddStockProducts);
            this.gbAddUsuario.Controls.Add(this.TbxAddNameProducts);
            this.gbAddUsuario.Controls.Add(this.BtnAddProducts);
            this.gbAddUsuario.Controls.Add(this.TbxAddIdProducts);
            this.gbAddUsuario.Controls.Add(this.CbxAddIdProvider);
            this.gbAddUsuario.Controls.Add(this.txtDescripcion);
            this.gbAddUsuario.Controls.Add(this.txtPrecio);
            this.gbAddUsuario.Controls.Add(this.txtIdProducto);
            this.gbAddUsuario.Controls.Add(this.txtStock);
            this.gbAddUsuario.Controls.Add(this.txtNomProducto);
            this.gbAddUsuario.Location = new System.Drawing.Point(9, 12);
            this.gbAddUsuario.Name = "gbAddUsuario";
            this.gbAddUsuario.Size = new System.Drawing.Size(335, 273);
            this.gbAddUsuario.TabIndex = 26;
            this.gbAddUsuario.TabStop = false;
            this.gbAddUsuario.Text = "AGREGAR PRODUCTO";
            // 
            // TbxAddPriceProducts
            // 
            this.TbxAddPriceProducts.Location = new System.Drawing.Point(115, 101);
            this.TbxAddPriceProducts.Name = "TbxAddPriceProducts";
            this.TbxAddPriceProducts.Size = new System.Drawing.Size(202, 20);
            this.TbxAddPriceProducts.TabIndex = 22;
            this.TbxAddPriceProducts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumValidate_KeyPress);
            // 
            // idProveedor
            // 
            this.idProveedor.AutoSize = true;
            this.idProveedor.Location = new System.Drawing.Point(6, 214);
            this.idProveedor.Name = "idProveedor";
            this.idProveedor.Size = new System.Drawing.Size(92, 13);
            this.idProveedor.TabIndex = 21;
            this.idProveedor.Text = "ID PROVEEDOR:";
            // 
            // RtbAddDescriptionProducts
            // 
            this.RtbAddDescriptionProducts.Location = new System.Drawing.Point(115, 129);
            this.RtbAddDescriptionProducts.Multiline = true;
            this.RtbAddDescriptionProducts.Name = "RtbAddDescriptionProducts";
            this.RtbAddDescriptionProducts.Size = new System.Drawing.Size(202, 77);
            this.RtbAddDescriptionProducts.TabIndex = 20;
            // 
            // TbxAddStockProducts
            // 
            this.TbxAddStockProducts.Location = new System.Drawing.Point(115, 76);
            this.TbxAddStockProducts.Name = "TbxAddStockProducts";
            this.TbxAddStockProducts.Size = new System.Drawing.Size(202, 20);
            this.TbxAddStockProducts.TabIndex = 12;
            this.TbxAddStockProducts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumValidate_KeyPress);
            // 
            // TbxAddNameProducts
            // 
            this.TbxAddNameProducts.Location = new System.Drawing.Point(115, 51);
            this.TbxAddNameProducts.Name = "TbxAddNameProducts";
            this.TbxAddNameProducts.Size = new System.Drawing.Size(202, 20);
            this.TbxAddNameProducts.TabIndex = 11;
            // 
            // BtnAddProducts
            // 
            this.BtnAddProducts.Location = new System.Drawing.Point(242, 241);
            this.BtnAddProducts.Name = "BtnAddProducts";
            this.BtnAddProducts.Size = new System.Drawing.Size(74, 23);
            this.BtnAddProducts.TabIndex = 19;
            this.BtnAddProducts.Text = "AGREGAR";
            this.BtnAddProducts.UseVisualStyleBackColor = true;
            this.BtnAddProducts.Click += new System.EventHandler(this.BtnAddProducts_Click);
            // 
            // TbxAddIdProducts
            // 
            this.TbxAddIdProducts.Location = new System.Drawing.Point(115, 24);
            this.TbxAddIdProducts.Name = "TbxAddIdProducts";
            this.TbxAddIdProducts.Size = new System.Drawing.Size(202, 20);
            this.TbxAddIdProducts.TabIndex = 10;
            // 
            // CbxAddIdProvider
            // 
            this.CbxAddIdProvider.FormattingEnabled = true;
            this.CbxAddIdProvider.Location = new System.Drawing.Point(115, 212);
            this.CbxAddIdProvider.Name = "CbxAddIdProvider";
            this.CbxAddIdProvider.Size = new System.Drawing.Size(202, 21);
            this.CbxAddIdProvider.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AutoSize = true;
            this.txtDescripcion.Location = new System.Drawing.Point(6, 132);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(83, 13);
            this.txtDescripcion.TabIndex = 7;
            this.txtDescripcion.Text = "DESCRIPCION:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.AutoSize = true;
            this.txtPrecio.Location = new System.Drawing.Point(6, 107);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(50, 13);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.Text = "PRECIO:";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.AutoSize = true;
            this.txtIdProducto.Location = new System.Drawing.Point(6, 27);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(21, 13);
            this.txtIdProducto.TabIndex = 2;
            this.txtIdProducto.Text = "ID:";
            // 
            // txtStock
            // 
            this.txtStock.AutoSize = true;
            this.txtStock.Location = new System.Drawing.Point(6, 79);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(46, 13);
            this.txtStock.TabIndex = 4;
            this.txtStock.Text = "STOCK:";
            this.txtStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNomProducto
            // 
            this.txtNomProducto.AutoSize = true;
            this.txtNomProducto.Location = new System.Drawing.Point(6, 54);
            this.txtNomProducto.Name = "txtNomProducto";
            this.txtNomProducto.Size = new System.Drawing.Size(71, 13);
            this.txtNomProducto.TabIndex = 3;
            this.txtNomProducto.Text = "PRODUCTO:";
            // 
            // gbBuscarUsuario
            // 
            this.gbBuscarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBuscarUsuario.Controls.Add(this.BtnMostrarAll);
            this.gbBuscarUsuario.Controls.Add(this.txtBuscarProducto);
            this.gbBuscarUsuario.Controls.Add(this.BtnSearchProducts);
            this.gbBuscarUsuario.Controls.Add(this.TbxSearchProducts);
            this.gbBuscarUsuario.Location = new System.Drawing.Point(350, 12);
            this.gbBuscarUsuario.Name = "gbBuscarUsuario";
            this.gbBuscarUsuario.Size = new System.Drawing.Size(595, 40);
            this.gbBuscarUsuario.TabIndex = 25;
            this.gbBuscarUsuario.TabStop = false;
            // 
            // BtnMostrarAll
            // 
            this.BtnMostrarAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMostrarAll.Location = new System.Drawing.Point(465, 11);
            this.BtnMostrarAll.Name = "BtnMostrarAll";
            this.BtnMostrarAll.Size = new System.Drawing.Size(124, 23);
            this.BtnMostrarAll.TabIndex = 9;
            this.BtnMostrarAll.Text = "MOSTRAR TODOS";
            this.BtnMostrarAll.UseVisualStyleBackColor = true;
            this.BtnMostrarAll.Click += new System.EventHandler(this.BtnMostrarAll_Click);
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBuscarProducto.AutoSize = true;
            this.txtBuscarProducto.Location = new System.Drawing.Point(6, 15);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(121, 13);
            this.txtBuscarProducto.TabIndex = 6;
            this.txtBuscarProducto.Text = "BUSCAR PRODUCTO: ";
            // 
            // BtnSearchProducts
            // 
            this.BtnSearchProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearchProducts.Location = new System.Drawing.Point(384, 10);
            this.BtnSearchProducts.Name = "BtnSearchProducts";
            this.BtnSearchProducts.Size = new System.Drawing.Size(75, 23);
            this.BtnSearchProducts.TabIndex = 8;
            this.BtnSearchProducts.Text = "BUSCAR";
            this.BtnSearchProducts.UseVisualStyleBackColor = true;
            this.BtnSearchProducts.Click += new System.EventHandler(this.BtnSearchProducts_Click);
            // 
            // TbxSearchProducts
            // 
            this.TbxSearchProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxSearchProducts.Location = new System.Drawing.Point(128, 12);
            this.TbxSearchProducts.Name = "TbxSearchProducts";
            this.TbxSearchProducts.Size = new System.Drawing.Size(250, 20);
            this.TbxSearchProducts.TabIndex = 7;
            // 
            // DvgProducts
            // 
            this.DvgProducts.AllowUserToAddRows = false;
            this.DvgProducts.AllowUserToDeleteRows = false;
            this.DvgProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DvgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DvgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgProducts.Location = new System.Drawing.Point(350, 58);
            this.DvgProducts.Name = "DvgProducts";
            this.DvgProducts.ReadOnly = true;
            this.DvgProducts.RowHeadersWidth = 51;
            this.DvgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DvgProducts.Size = new System.Drawing.Size(595, 522);
            this.DvgProducts.TabIndex = 24;
            this.DvgProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DvgProducts_CellClick);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 587);
            this.Controls.Add(this.gbActProducto);
            this.Controls.Add(this.gbAddUsuario);
            this.Controls.Add(this.gbBuscarUsuario);
            this.Controls.Add(this.DvgProducts);
            this.Name = "FrmProductos";
            this.Text = "FrmProductos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.gbActProducto.ResumeLayout(false);
            this.gbActProducto.PerformLayout();
            this.gbAddUsuario.ResumeLayout(false);
            this.gbAddUsuario.PerformLayout();
            this.gbBuscarUsuario.ResumeLayout(false);
            this.gbBuscarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvgProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbActProducto;
        private System.Windows.Forms.TextBox TbxEditPriceProducts;
        private System.Windows.Forms.Label txtActIdProveedor;
        private System.Windows.Forms.TextBox RtbEditDescriptionProducts;
        private System.Windows.Forms.TextBox TbxEditStockProducts;
        private System.Windows.Forms.TextBox TbxEditNameProducts;
        private System.Windows.Forms.Button BtnEditProducts;
        private System.Windows.Forms.TextBox TbxEditIdProducts;
        private System.Windows.Forms.ComboBox CbxEditIdProvider;
        private System.Windows.Forms.Label txtActDescripcion;
        private System.Windows.Forms.Label txtActPrecio;
        private System.Windows.Forms.Label txtActIdProducto;
        private System.Windows.Forms.Label txtActStock;
        private System.Windows.Forms.Label txtActNomProducto;
        private System.Windows.Forms.GroupBox gbAddUsuario;
        private System.Windows.Forms.TextBox TbxAddPriceProducts;
        private System.Windows.Forms.Label idProveedor;
        private System.Windows.Forms.TextBox RtbAddDescriptionProducts;
        private System.Windows.Forms.TextBox TbxAddStockProducts;
        private System.Windows.Forms.TextBox TbxAddNameProducts;
        private System.Windows.Forms.Button BtnAddProducts;
        private System.Windows.Forms.TextBox TbxAddIdProducts;
        private System.Windows.Forms.ComboBox CbxAddIdProvider;
        private System.Windows.Forms.Label txtDescripcion;
        private System.Windows.Forms.Label txtPrecio;
        private System.Windows.Forms.Label txtIdProducto;
        private System.Windows.Forms.Label txtStock;
        private System.Windows.Forms.Label txtNomProducto;
        private System.Windows.Forms.GroupBox gbBuscarUsuario;
        private System.Windows.Forms.Button BtnMostrarAll;
        private System.Windows.Forms.Label txtBuscarProducto;
        private System.Windows.Forms.Button BtnSearchProducts;
        private System.Windows.Forms.TextBox TbxSearchProducts;
        private System.Windows.Forms.DataGridView DvgProducts;
    }
}