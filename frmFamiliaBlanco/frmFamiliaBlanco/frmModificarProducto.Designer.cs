namespace frmFamiliaBlanco
{
    partial class frmModificarProducto
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.btnCategNueva = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.gbProveedores = new System.Windows.Forms.GroupBox();
            this.btnProvEliminar = new System.Windows.Forms.Button();
            this.lblProvNuevo = new System.Windows.Forms.Label();
            this.btnProvNuevo = new System.Windows.Forms.Button();
            this.btnProvAgregar = new System.Windows.Forms.Button();
            this.lblProvProductos = new System.Windows.Forms.Label();
            this.lblProveedores = new System.Windows.Forms.Label();
            this.ltsProvAgregados = new System.Windows.Forms.ListBox();
            this.LblFiltro = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.ltsProveedores = new System.Windows.Forms.ListBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.gbDetalle.SuspendLayout();
            this.gbCategoria.SuspendLayout();
            this.gbProveedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(528, 492);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 61;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(418, 492);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 60;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // gbDetalle
            // 
            this.gbDetalle.Controls.Add(this.gbCategoria);
            this.gbDetalle.Controls.Add(this.gbProveedores);
            this.gbDetalle.Controls.Add(this.lblNombre);
            this.gbDetalle.Controls.Add(this.txtNombre);
            this.gbDetalle.Controls.Add(this.txtDescripcion);
            this.gbDetalle.Controls.Add(this.lblDescripcion);
            this.gbDetalle.Location = new System.Drawing.Point(23, 14);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(563, 472);
            this.gbDetalle.TabIndex = 59;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Agregar ";
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.btnCategNueva);
            this.gbCategoria.Controls.Add(this.label5);
            this.gbCategoria.Controls.Add(this.txtBuscar);
            this.gbCategoria.Controls.Add(this.lblCategoria);
            this.gbCategoria.Controls.Add(this.cmbCategoria);
            this.gbCategoria.Location = new System.Drawing.Point(249, 38);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(280, 128);
            this.gbCategoria.TabIndex = 59;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Modificar Categoria";
            // 
            // btnCategNueva
            // 
            this.btnCategNueva.Location = new System.Drawing.Point(239, 79);
            this.btnCategNueva.Name = "btnCategNueva";
            this.btnCategNueva.Size = new System.Drawing.Size(30, 23);
            this.btnCategNueva.TabIndex = 59;
            this.btnCategNueva.Text = "+";
            this.btnCategNueva.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(76, 30);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(157, 20);
            this.txtBuscar.TabIndex = 56;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(20, 84);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 54;
            this.lblCategoria.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(76, 81);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(157, 21);
            this.cmbCategoria.TabIndex = 55;
            // 
            // gbProveedores
            // 
            this.gbProveedores.Controls.Add(this.btnProvEliminar);
            this.gbProveedores.Controls.Add(this.lblProvNuevo);
            this.gbProveedores.Controls.Add(this.btnProvNuevo);
            this.gbProveedores.Controls.Add(this.btnProvAgregar);
            this.gbProveedores.Controls.Add(this.lblProvProductos);
            this.gbProveedores.Controls.Add(this.lblProveedores);
            this.gbProveedores.Controls.Add(this.ltsProvAgregados);
            this.gbProveedores.Controls.Add(this.LblFiltro);
            this.gbProveedores.Controls.Add(this.cmbFiltro);
            this.gbProveedores.Controls.Add(this.txtFiltro);
            this.gbProveedores.Controls.Add(this.ltsProveedores);
            this.gbProveedores.Location = new System.Drawing.Point(10, 186);
            this.gbProveedores.Name = "gbProveedores";
            this.gbProveedores.Size = new System.Drawing.Size(519, 261);
            this.gbProveedores.TabIndex = 58;
            this.gbProveedores.TabStop = false;
            this.gbProveedores.Text = "Modificar proveedores";
            // 
            // btnProvEliminar
            // 
            this.btnProvEliminar.Location = new System.Drawing.Point(239, 165);
            this.btnProvEliminar.Name = "btnProvEliminar";
            this.btnProvEliminar.Size = new System.Drawing.Size(29, 23);
            this.btnProvEliminar.TabIndex = 60;
            this.btnProvEliminar.Text = "<-";
            this.btnProvEliminar.UseVisualStyleBackColor = true;
            // 
            // lblProvNuevo
            // 
            this.lblProvNuevo.AutoSize = true;
            this.lblProvNuevo.Location = new System.Drawing.Point(44, 227);
            this.lblProvNuevo.Name = "lblProvNuevo";
            this.lblProvNuevo.Size = new System.Drawing.Size(88, 13);
            this.lblProvNuevo.TabIndex = 59;
            this.lblProvNuevo.Text = "nuevo proveedor";
            // 
            // btnProvNuevo
            // 
            this.btnProvNuevo.Location = new System.Drawing.Point(148, 222);
            this.btnProvNuevo.Name = "btnProvNuevo";
            this.btnProvNuevo.Size = new System.Drawing.Size(32, 23);
            this.btnProvNuevo.TabIndex = 58;
            this.btnProvNuevo.Text = "+";
            this.btnProvNuevo.UseVisualStyleBackColor = true;
            // 
            // btnProvAgregar
            // 
            this.btnProvAgregar.Location = new System.Drawing.Point(239, 126);
            this.btnProvAgregar.Name = "btnProvAgregar";
            this.btnProvAgregar.Size = new System.Drawing.Size(29, 23);
            this.btnProvAgregar.TabIndex = 57;
            this.btnProvAgregar.Text = "->";
            this.btnProvAgregar.UseVisualStyleBackColor = true;
            // 
            // lblProvProductos
            // 
            this.lblProvProductos.AutoSize = true;
            this.lblProvProductos.Location = new System.Drawing.Point(300, 79);
            this.lblProvProductos.Name = "lblProvProductos";
            this.lblProvProductos.Size = new System.Drawing.Size(129, 13);
            this.lblProvProductos.TabIndex = 56;
            this.lblProvProductos.Text = "Proveedores del producto";
            // 
            // lblProveedores
            // 
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.Location = new System.Drawing.Point(44, 79);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(67, 13);
            this.lblProveedores.TabIndex = 55;
            this.lblProveedores.Text = "Proveedores";
            // 
            // ltsProvAgregados
            // 
            this.ltsProvAgregados.FormattingEnabled = true;
            this.ltsProvAgregados.Location = new System.Drawing.Point(303, 95);
            this.ltsProvAgregados.Name = "ltsProvAgregados";
            this.ltsProvAgregados.Size = new System.Drawing.Size(157, 121);
            this.ltsProvAgregados.TabIndex = 54;
            // 
            // LblFiltro
            // 
            this.LblFiltro.AutoSize = true;
            this.LblFiltro.Location = new System.Drawing.Point(40, 46);
            this.LblFiltro.Name = "LblFiltro";
            this.LblFiltro.Size = new System.Drawing.Size(50, 13);
            this.LblFiltro.TabIndex = 53;
            this.LblFiltro.Text = "Filtrar por";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(109, 42);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(159, 21);
            this.cmbFiltro.TabIndex = 52;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(302, 43);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(157, 20);
            this.txtFiltro.TabIndex = 51;
            // 
            // ltsProveedores
            // 
            this.ltsProveedores.FormattingEnabled = true;
            this.ltsProveedores.Location = new System.Drawing.Point(47, 95);
            this.ltsProveedores.Name = "ltsProveedores";
            this.ltsProveedores.Size = new System.Drawing.Size(163, 121);
            this.ltsProveedores.TabIndex = 50;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 57;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(76, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(152, 20);
            this.txtNombre.TabIndex = 56;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(76, 75);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(152, 93);
            this.txtDescripcion.TabIndex = 52;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(7, 75);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 53;
            this.lblDescripcion.Text = "Descripción";
            // 
            // frmModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 528);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbDetalle);
            this.Name = "frmModificarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModificarProducto";
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            this.gbCategoria.ResumeLayout(false);
            this.gbCategoria.PerformLayout();
            this.gbProveedores.ResumeLayout(false);
            this.gbProveedores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.Button btnCategNueva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.GroupBox gbProveedores;
        private System.Windows.Forms.Button btnProvEliminar;
        private System.Windows.Forms.Label lblProvNuevo;
        private System.Windows.Forms.Button btnProvNuevo;
        private System.Windows.Forms.Button btnProvAgregar;
        private System.Windows.Forms.Label lblProvProductos;
        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.ListBox ltsProvAgregados;
        private System.Windows.Forms.Label LblFiltro;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ListBox ltsProveedores;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
    }
}