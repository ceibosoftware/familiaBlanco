namespace frmFamiliaBlanco
{
    partial class frmProveedores
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
            this.LblFiltro = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.gbProveedores = new System.Windows.Forms.GroupBox();
            this.ltsProveedores = new System.Windows.Forms.ListBox();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.dgvContacto = new System.Windows.Forms.DataGridView();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbProveedores.SuspendLayout();
            this.gbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacto)).BeginInit();
            this.SuspendLayout();
            // 
            // LblFiltro
            // 
            this.LblFiltro.AutoSize = true;
            this.LblFiltro.Location = new System.Drawing.Point(134, 39);
            this.LblFiltro.Name = "LblFiltro";
            this.LblFiltro.Size = new System.Drawing.Size(50, 13);
            this.LblFiltro.TabIndex = 44;
            this.LblFiltro.Text = "Filtrar por";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(216, 36);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(152, 21);
            this.cmbFiltro.TabIndex = 43;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(410, 36);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(152, 20);
            this.txtFiltro.TabIndex = 42;
            // 
            // gbProveedores
            // 
            this.gbProveedores.Controls.Add(this.ltsProveedores);
            this.gbProveedores.Location = new System.Drawing.Point(12, 87);
            this.gbProveedores.Name = "gbProveedores";
            this.gbProveedores.Size = new System.Drawing.Size(260, 412);
            this.gbProveedores.TabIndex = 51;
            this.gbProveedores.TabStop = false;
            this.gbProveedores.Text = "Proveedores";
            // 
            // ltsProveedores
            // 
            this.ltsProveedores.FormattingEnabled = true;
            this.ltsProveedores.Location = new System.Drawing.Point(22, 24);
            this.ltsProveedores.Name = "ltsProveedores";
            this.ltsProveedores.Size = new System.Drawing.Size(214, 368);
            this.ltsProveedores.TabIndex = 38;
            this.ltsProveedores.SelectedValueChanged += new System.EventHandler(this.ltsProveedores_SelectedValueChanged);
            // 
            // gbDetalle
            // 
            this.gbDetalle.Controls.Add(this.txtCategoria);
            this.gbDetalle.Controls.Add(this.lblCategoria);
            this.gbDetalle.Controls.Add(this.txtLocalidad);
            this.gbDetalle.Controls.Add(this.dgvContacto);
            this.gbDetalle.Controls.Add(this.txtDireccion);
            this.gbDetalle.Controls.Add(this.txtCP);
            this.gbDetalle.Controls.Add(this.txtRazonSocial);
            this.gbDetalle.Controls.Add(this.txtCuit);
            this.gbDetalle.Controls.Add(this.lblContacto);
            this.gbDetalle.Controls.Add(this.lblLocalidad);
            this.gbDetalle.Controls.Add(this.lblDireccion);
            this.gbDetalle.Controls.Add(this.lblCP);
            this.gbDetalle.Controls.Add(this.lblRazonSocial);
            this.gbDetalle.Controls.Add(this.lblCuit);
            this.gbDetalle.Location = new System.Drawing.Point(298, 87);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(491, 412);
            this.gbDetalle.TabIndex = 52;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Detalle";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(324, 55);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(156, 20);
            this.txtCategoria.TabIndex = 57;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(265, 58);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 56;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(91, 181);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.ReadOnly = true;
            this.txtLocalidad.Size = new System.Drawing.Size(156, 20);
            this.txtLocalidad.TabIndex = 12;
            // 
            // dgvContacto
            // 
            this.dgvContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacto.Location = new System.Drawing.Point(20, 244);
            this.dgvContacto.Name = "dgvContacto";
            this.dgvContacto.Size = new System.Drawing.Size(462, 159);
            this.dgvContacto.TabIndex = 11;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(91, 144);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(156, 20);
            this.txtDireccion.TabIndex = 9;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(91, 113);
            this.txtCP.Name = "txtCP";
            this.txtCP.ReadOnly = true;
            this.txtCP.Size = new System.Drawing.Size(156, 20);
            this.txtCP.TabIndex = 8;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(91, 84);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.ReadOnly = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(156, 20);
            this.txtRazonSocial.TabIndex = 7;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(91, 55);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.ReadOnly = true;
            this.txtCuit.Size = new System.Drawing.Size(156, 20);
            this.txtCuit.TabIndex = 6;
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(33, 228);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(50, 13);
            this.lblContacto.TabIndex = 5;
            this.lblContacto.Text = "Contacto";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(32, 184);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 4;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(33, 151);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(27, 120);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(58, 13);
            this.lblCP.TabIndex = 2;
            this.lblCP.Text = "Cod Postal";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(17, 91);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(68, 13);
            this.lblRazonSocial.TabIndex = 1;
            this.lblRazonSocial.Text = "Razon social";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(51, 55);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(25, 13);
            this.lblCuit.TabIndex = 0;
            this.lblCuit.Text = "Cuit";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(703, 505);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 57;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(606, 505);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 56;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(506, 505);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 55;
            this.btnAceptar.Text = "Agregar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 540);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbDetalle);
            this.Controls.Add(this.gbProveedores);
            this.Controls.Add(this.LblFiltro);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Name = "frmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            this.gbProveedores.ResumeLayout(false);
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFiltro;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.GroupBox gbProveedores;
        private System.Windows.Forms.ListBox ltsProveedores;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.DataGridView dgvContacto;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblCategoria;
    }
}