namespace Tienda_de_Ropa.Vistas
{
    partial class FrmProveedores
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DbgProviderTable = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnMostarAllProvider = new System.Windows.Forms.Button();
            this.BtnSearchProvider = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.TbxSearchProvider = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnEditProvider = new System.Windows.Forms.Button();
            this.TbxEditProviderTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RtbEditProviderDirection = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TbxEditProviderName = new System.Windows.Forms.TextBox();
            this.TbxEditProviderEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAddProvider = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxAddProviderEmail = new System.Windows.Forms.TextBox();
            this.TbxAddProviderTel = new System.Windows.Forms.TextBox();
            this.TbxAddProviderName = new System.Windows.Forms.TextBox();
            this.RtbAddProviderDirecctio = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DbgProviderTable)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.DbgProviderTable);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 533);
            this.panel1.TabIndex = 0;
            // 
            // DbgProviderTable
            // 
            this.DbgProviderTable.AllowUserToAddRows = false;
            this.DbgProviderTable.AllowUserToDeleteRows = false;
            this.DbgProviderTable.AllowUserToOrderColumns = true;
            this.DbgProviderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DbgProviderTable.Location = new System.Drawing.Point(368, 69);
            this.DbgProviderTable.Name = "DbgProviderTable";
            this.DbgProviderTable.ReadOnly = true;
            this.DbgProviderTable.Size = new System.Drawing.Size(602, 452);
            this.DbgProviderTable.TabIndex = 15;
            this.DbgProviderTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DbgProviderTable_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnMostarAllProvider);
            this.groupBox3.Controls.Add(this.BtnSearchProvider);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.TbxSearchProvider);
            this.groupBox3.Location = new System.Drawing.Point(368, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(602, 48);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // BtnMostarAllProvider
            // 
            this.BtnMostarAllProvider.Location = new System.Drawing.Point(468, 14);
            this.BtnMostarAllProvider.Name = "BtnMostarAllProvider";
            this.BtnMostarAllProvider.Size = new System.Drawing.Size(112, 26);
            this.BtnMostarAllProvider.TabIndex = 11;
            this.BtnMostarAllProvider.Text = "MOSTRAR TODOS";
            this.BtnMostarAllProvider.UseVisualStyleBackColor = true;
            this.BtnMostarAllProvider.Click += new System.EventHandler(this.BtnMostarAllProvider_Click);
            // 
            // BtnSearchProvider
            // 
            this.BtnSearchProvider.Location = new System.Drawing.Point(390, 14);
            this.BtnSearchProvider.Name = "BtnSearchProvider";
            this.BtnSearchProvider.Size = new System.Drawing.Size(69, 26);
            this.BtnSearchProvider.TabIndex = 10;
            this.BtnSearchProvider.Text = "BUSCAR";
            this.BtnSearchProvider.UseVisualStyleBackColor = true;
            this.BtnSearchProvider.Click += new System.EventHandler(this.BtnSearchProvider_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "BUSCAR PROVEEDOR:";
            // 
            // TbxSearchProvider
            // 
            this.TbxSearchProvider.Location = new System.Drawing.Point(147, 17);
            this.TbxSearchProvider.Name = "TbxSearchProvider";
            this.TbxSearchProvider.Size = new System.Drawing.Size(229, 20);
            this.TbxSearchProvider.TabIndex = 1;
            this.TbxSearchProvider.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnEditProvider);
            this.groupBox2.Controls.Add(this.TbxEditProviderTel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.RtbEditProviderDirection);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TbxEditProviderName);
            this.groupBox2.Controls.Add(this.TbxEditProviderEmail);
            this.groupBox2.Location = new System.Drawing.Point(12, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 252);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar";
            // 
            // BtnEditProvider
            // 
            this.BtnEditProvider.Location = new System.Drawing.Point(246, 210);
            this.BtnEditProvider.Name = "BtnEditProvider";
            this.BtnEditProvider.Size = new System.Drawing.Size(75, 23);
            this.BtnEditProvider.TabIndex = 17;
            this.BtnEditProvider.Text = "Editar";
            this.BtnEditProvider.UseVisualStyleBackColor = true;
            this.BtnEditProvider.Click += new System.EventHandler(this.BtnEditProvider_Click);
            // 
            // TbxEditProviderTel
            // 
            this.TbxEditProviderTel.Location = new System.Drawing.Point(133, 55);
            this.TbxEditProviderTel.Name = "TbxEditProviderTel";
            this.TbxEditProviderTel.Size = new System.Drawing.Size(188, 20);
            this.TbxEditProviderTel.TabIndex = 12;
            this.TbxEditProviderTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxProviderTel_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "EMAIL:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "PROVEEDOR:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "DIRECCION:";
            // 
            // RtbEditProviderDirection
            // 
            this.RtbEditProviderDirection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbEditProviderDirection.Location = new System.Drawing.Point(133, 81);
            this.RtbEditProviderDirection.Name = "RtbEditProviderDirection";
            this.RtbEditProviderDirection.Size = new System.Drawing.Size(188, 96);
            this.RtbEditProviderDirection.TabIndex = 10;
            this.RtbEditProviderDirection.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "TELEFONO:";
            // 
            // TbxEditProviderName
            // 
            this.TbxEditProviderName.Location = new System.Drawing.Point(133, 29);
            this.TbxEditProviderName.Name = "TbxEditProviderName";
            this.TbxEditProviderName.Size = new System.Drawing.Size(188, 20);
            this.TbxEditProviderName.TabIndex = 11;
            // 
            // TbxEditProviderEmail
            // 
            this.TbxEditProviderEmail.Location = new System.Drawing.Point(133, 183);
            this.TbxEditProviderEmail.Name = "TbxEditProviderEmail";
            this.TbxEditProviderEmail.Size = new System.Drawing.Size(188, 20);
            this.TbxEditProviderEmail.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAddProvider);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbxAddProviderEmail);
            this.groupBox1.Controls.Add(this.TbxAddProviderTel);
            this.groupBox1.Controls.Add(this.TbxAddProviderName);
            this.groupBox1.Controls.Add(this.RtbAddProviderDirecctio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar";
            // 
            // BtnAddProvider
            // 
            this.BtnAddProvider.Location = new System.Drawing.Point(246, 216);
            this.BtnAddProvider.Name = "BtnAddProvider";
            this.BtnAddProvider.Size = new System.Drawing.Size(75, 23);
            this.BtnAddProvider.TabIndex = 8;
            this.BtnAddProvider.Text = "Agregar";
            this.BtnAddProvider.UseVisualStyleBackColor = true;
            this.BtnAddProvider.Click += new System.EventHandler(this.BtnAddProvider_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "EMAIL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DIRECCION:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "TELEFONO:";
            // 
            // TbxAddProviderEmail
            // 
            this.TbxAddProviderEmail.Location = new System.Drawing.Point(133, 189);
            this.TbxAddProviderEmail.Name = "TbxAddProviderEmail";
            this.TbxAddProviderEmail.Size = new System.Drawing.Size(188, 20);
            this.TbxAddProviderEmail.TabIndex = 4;
            // 
            // TbxAddProviderTel
            // 
            this.TbxAddProviderTel.Location = new System.Drawing.Point(133, 61);
            this.TbxAddProviderTel.Name = "TbxAddProviderTel";
            this.TbxAddProviderTel.Size = new System.Drawing.Size(188, 20);
            this.TbxAddProviderTel.TabIndex = 3;
            this.TbxAddProviderTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxProviderTel_KeyPress);
            // 
            // TbxAddProviderName
            // 
            this.TbxAddProviderName.Location = new System.Drawing.Point(133, 35);
            this.TbxAddProviderName.Name = "TbxAddProviderName";
            this.TbxAddProviderName.Size = new System.Drawing.Size(188, 20);
            this.TbxAddProviderName.TabIndex = 2;
            // 
            // RtbAddProviderDirecctio
            // 
            this.RtbAddProviderDirecctio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbAddProviderDirecctio.Location = new System.Drawing.Point(133, 87);
            this.RtbAddProviderDirecctio.Name = "RtbAddProviderDirecctio";
            this.RtbAddProviderDirecctio.Size = new System.Drawing.Size(188, 96);
            this.RtbAddProviderDirecctio.TabIndex = 1;
            this.RtbAddProviderDirecctio.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROVEEDOR:";
            // 
            // FrmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 533);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProveedores";
            this.Text = "FrmProveedores";
            this.Load += new System.EventHandler(this.FrmProveedores_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DbgProviderTable)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxAddProviderEmail;
        private System.Windows.Forms.TextBox TbxAddProviderTel;
        private System.Windows.Forms.TextBox TbxAddProviderName;
        private System.Windows.Forms.RichTextBox RtbAddProviderDirecctio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEditProvider;
        private System.Windows.Forms.TextBox TbxEditProviderTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox RtbEditProviderDirection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbxEditProviderName;
        private System.Windows.Forms.TextBox TbxEditProviderEmail;
        private System.Windows.Forms.Button BtnAddProvider;
        private System.Windows.Forms.DataGridView DbgProviderTable;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnMostarAllProvider;
        private System.Windows.Forms.Button BtnSearchProvider;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TbxSearchProvider;
    }
}