namespace Tienda_de_Ropa.Vistas
{
    partial class FrmUsuarios
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
            this.TbxTotalUsers = new System.Windows.Forms.Label();
            this.DbgUsersTable = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnMostarAll = new System.Windows.Forms.Button();
            this.BtnSearchUser = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.TbxSearchUser = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CbxEditUserRol = new System.Windows.Forms.ComboBox();
            this.CbxEditUserState = new System.Windows.Forms.ComboBox();
            this.BtnEditUser = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TbxEditUserPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TbxEditUserUser = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TbxEditUserName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbxAddUserState = new System.Windows.Forms.ComboBox();
            this.CbxAddUserRoll = new System.Windows.Forms.ComboBox();
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbxAddUserPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxAddUserUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxAddUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DbgUsersTable)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TbxTotalUsers);
            this.panel1.Controls.Add(this.DbgUsersTable);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 450);
            this.panel1.TabIndex = 0;
            // 
            // TbxTotalUsers
            // 
            this.TbxTotalUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxTotalUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxTotalUsers.Location = new System.Drawing.Point(708, 418);
            this.TbxTotalUsers.Name = "TbxTotalUsers";
            this.TbxTotalUsers.Size = new System.Drawing.Size(157, 23);
            this.TbxTotalUsers.TabIndex = 14;
            this.TbxTotalUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DbgUsersTable
            // 
            this.DbgUsersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DbgUsersTable.Location = new System.Drawing.Point(285, 68);
            this.DbgUsersTable.Name = "DbgUsersTable";
            this.DbgUsersTable.Size = new System.Drawing.Size(586, 338);
            this.DbgUsersTable.TabIndex = 13;
            this.DbgUsersTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DbgUsersTable_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnMostarAll);
            this.groupBox3.Controls.Add(this.BtnSearchUser);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.TbxSearchUser);
            this.groupBox3.Location = new System.Drawing.Point(285, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(586, 48);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // BtnMostarAll
            // 
            this.BtnMostarAll.Location = new System.Drawing.Point(468, 14);
            this.BtnMostarAll.Name = "BtnMostarAll";
            this.BtnMostarAll.Size = new System.Drawing.Size(112, 26);
            this.BtnMostarAll.TabIndex = 11;
            this.BtnMostarAll.Text = "MOSTRAR TODOS";
            this.BtnMostarAll.UseVisualStyleBackColor = true;
            this.BtnMostarAll.Click += new System.EventHandler(this.BtnMostarAll_Click);
            // 
            // BtnSearchUser
            // 
            this.BtnSearchUser.Location = new System.Drawing.Point(390, 14);
            this.BtnSearchUser.Name = "BtnSearchUser";
            this.BtnSearchUser.Size = new System.Drawing.Size(69, 26);
            this.BtnSearchUser.TabIndex = 10;
            this.BtnSearchUser.Text = "BUSCAR";
            this.BtnSearchUser.UseVisualStyleBackColor = true;
            this.BtnSearchUser.Click += new System.EventHandler(this.BtnSearchUser_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "BUSCAR USUARIO :";
            // 
            // TbxSearchUser
            // 
            this.TbxSearchUser.Location = new System.Drawing.Point(131, 17);
            this.TbxSearchUser.Name = "TbxSearchUser";
            this.TbxSearchUser.Size = new System.Drawing.Size(245, 20);
            this.TbxSearchUser.TabIndex = 1;
            this.TbxSearchUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CbxEditUserRol);
            this.groupBox2.Controls.Add(this.CbxEditUserState);
            this.groupBox2.Controls.Add(this.BtnEditUser);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TbxEditUserPassword);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TbxEditUserUser);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TbxEditUserName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 190);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EDITAR USUARIO";
            // 
            // CbxEditUserRol
            // 
            this.CbxEditUserRol.FormattingEnabled = true;
            this.CbxEditUserRol.Location = new System.Drawing.Point(96, 99);
            this.CbxEditUserRol.Name = "CbxEditUserRol";
            this.CbxEditUserRol.Size = new System.Drawing.Size(100, 21);
            this.CbxEditUserRol.TabIndex = 13;
            // 
            // CbxEditUserState
            // 
            this.CbxEditUserState.FormattingEnabled = true;
            this.CbxEditUserState.Location = new System.Drawing.Point(96, 125);
            this.CbxEditUserState.Name = "CbxEditUserState";
            this.CbxEditUserState.Size = new System.Drawing.Size(100, 21);
            this.CbxEditUserState.TabIndex = 12;
            // 
            // BtnEditUser
            // 
            this.BtnEditUser.Location = new System.Drawing.Point(96, 151);
            this.BtnEditUser.Name = "BtnEditUser";
            this.BtnEditUser.Size = new System.Drawing.Size(114, 26);
            this.BtnEditUser.TabIndex = 10;
            this.BtnEditUser.Text = "Editar usuario";
            this.BtnEditUser.UseVisualStyleBackColor = true;
            this.BtnEditUser.Click += new System.EventHandler(this.BtnEditUser_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rol :";
            // 
            // TbxEditUserPassword
            // 
            this.TbxEditUserPassword.Location = new System.Drawing.Point(96, 73);
            this.TbxEditUserPassword.Name = "TbxEditUserPassword";
            this.TbxEditUserPassword.Size = new System.Drawing.Size(100, 20);
            this.TbxEditUserPassword.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Contraseña :";
            // 
            // TbxEditUserUser
            // 
            this.TbxEditUserUser.Location = new System.Drawing.Point(96, 47);
            this.TbxEditUserUser.Name = "TbxEditUserUser";
            this.TbxEditUserUser.Size = new System.Drawing.Size(100, 20);
            this.TbxEditUserUser.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nombre :";
            // 
            // TbxEditUserName
            // 
            this.TbxEditUserName.Location = new System.Drawing.Point(96, 21);
            this.TbxEditUserName.Name = "TbxEditUserName";
            this.TbxEditUserName.Size = new System.Drawing.Size(100, 20);
            this.TbxEditUserName.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Usuario :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbxAddUserState);
            this.groupBox1.Controls.Add(this.CbxAddUserRoll);
            this.groupBox1.Controls.Add(this.BtnAddUser);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TbxAddUserPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TbxAddUserUser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbxAddUserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AGREGAR USUARIO";
            // 
            // CbxAddUserState
            // 
            this.CbxAddUserState.FormattingEnabled = true;
            this.CbxAddUserState.Location = new System.Drawing.Point(96, 125);
            this.CbxAddUserState.Name = "CbxAddUserState";
            this.CbxAddUserState.Size = new System.Drawing.Size(100, 21);
            this.CbxAddUserState.TabIndex = 11;
            // 
            // CbxAddUserRoll
            // 
            this.CbxAddUserRoll.FormattingEnabled = true;
            this.CbxAddUserRoll.Location = new System.Drawing.Point(96, 99);
            this.CbxAddUserRoll.Name = "CbxAddUserRoll";
            this.CbxAddUserRoll.Size = new System.Drawing.Size(100, 21);
            this.CbxAddUserRoll.TabIndex = 0;
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.Location = new System.Drawing.Point(96, 151);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(114, 26);
            this.BtnAddUser.TabIndex = 10;
            this.BtnAddUser.Text = "Agregar usuario";
            this.BtnAddUser.UseVisualStyleBackColor = true;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rol :";
            // 
            // TbxAddUserPassword
            // 
            this.TbxAddUserPassword.Location = new System.Drawing.Point(96, 73);
            this.TbxAddUserPassword.Name = "TbxAddUserPassword";
            this.TbxAddUserPassword.Size = new System.Drawing.Size(100, 20);
            this.TbxAddUserPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña :";
            // 
            // TbxAddUserUser
            // 
            this.TbxAddUserUser.Location = new System.Drawing.Point(96, 47);
            this.TbxAddUserUser.Name = "TbxAddUserUser";
            this.TbxAddUserUser.Size = new System.Drawing.Size(100, 20);
            this.TbxAddUserUser.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre :";
            // 
            // TbxAddUserName
            // 
            this.TbxAddUserName.Location = new System.Drawing.Point(96, 21);
            this.TbxAddUserName.Name = "TbxAddUserName";
            this.TbxAddUserName.Size = new System.Drawing.Size(100, 20);
            this.TbxAddUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario :";
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmUsuarios";
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DbgUsersTable)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxAddUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbxAddUserPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbxAddUserUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAddUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnEditUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbxEditUserPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TbxEditUserUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbxEditUserName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnSearchUser;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TbxSearchUser;
        private System.Windows.Forms.Button BtnMostarAll;
        private System.Windows.Forms.ComboBox CbxEditUserRol;
        private System.Windows.Forms.ComboBox CbxEditUserState;
        private System.Windows.Forms.ComboBox CbxAddUserState;
        private System.Windows.Forms.ComboBox CbxAddUserRoll;
        private System.Windows.Forms.DataGridView DbgUsersTable;
        private System.Windows.Forms.Label TbxTotalUsers;
    }
}