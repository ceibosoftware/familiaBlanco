namespace frmFamiliaBlanco
{
    partial class frmAgregarProveedor
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
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.gbProveedor = new System.Windows.Forms.GroupBox();
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.btnCategNueva = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbRazonSocial = new System.Windows.Forms.ComboBox();
            this.btnNuevoContacto = new System.Windows.Forms.Button();
            this.lblContacto = new System.Windows.Forms.Label();
            this.dgvContacto = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnEliminarContacto = new System.Windows.Forms.Button();
            this.gbProveedor.SuspendLayout();
            this.gbCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(85, 189);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(156, 20);
            this.txtLocalidad.TabIndex = 22;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(85, 163);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(156, 20);
            this.txtDireccion.TabIndex = 21;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(85, 137);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(156, 20);
            this.txtCP.TabIndex = 20;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(85, 79);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(156, 20);
            this.txtCuit.TabIndex = 18;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(26, 204);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 17;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(27, 166);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 16;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(21, 140);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(58, 13);
            this.lblCP.TabIndex = 15;
            this.lblCP.Text = "Cod Postal";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(11, 111);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(68, 13);
            this.lblRazonSocial.TabIndex = 14;
            this.lblRazonSocial.Text = "Razon social";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(45, 82);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(25, 13);
            this.lblCuit.TabIndex = 13;
            this.lblCuit.Text = "Cuit";
            // 
            // gbProveedor
            // 
            this.gbProveedor.Controls.Add(this.btnEliminarContacto);
            this.gbProveedor.Controls.Add(this.gbCategoria);
            this.gbProveedor.Controls.Add(this.cmbRazonSocial);
            this.gbProveedor.Controls.Add(this.btnNuevoContacto);
            this.gbProveedor.Controls.Add(this.lblContacto);
            this.gbProveedor.Controls.Add(this.dgvContacto);
            this.gbProveedor.Controls.Add(this.txtNombre);
            this.gbProveedor.Controls.Add(this.lblNombre);
            this.gbProveedor.Controls.Add(this.txtCuit);
            this.gbProveedor.Controls.Add(this.txtLocalidad);
            this.gbProveedor.Controls.Add(this.lblCuit);
            this.gbProveedor.Controls.Add(this.txtDireccion);
            this.gbProveedor.Controls.Add(this.lblRazonSocial);
            this.gbProveedor.Controls.Add(this.txtCP);
            this.gbProveedor.Controls.Add(this.lblCP);
            this.gbProveedor.Controls.Add(this.lblDireccion);
            this.gbProveedor.Controls.Add(this.lblLocalidad);
            this.gbProveedor.Location = new System.Drawing.Point(25, 12);
            this.gbProveedor.Name = "gbProveedor";
            this.gbProveedor.Size = new System.Drawing.Size(544, 448);
            this.gbProveedor.TabIndex = 23;
            this.gbProveedor.TabStop = false;
            this.gbProveedor.Text = "Datos Proveedor";
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.btnCategNueva);
            this.gbCategoria.Controls.Add(this.label5);
            this.gbCategoria.Controls.Add(this.txtBuscar);
            this.gbCategoria.Controls.Add(this.lblCategoria);
            this.gbCategoria.Controls.Add(this.cmbCategoria);
            this.gbCategoria.Location = new System.Drawing.Point(258, 51);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(280, 106);
            this.gbCategoria.TabIndex = 60;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Agregar Categoria";
            // 
            // btnCategNueva
            // 
            this.btnCategNueva.Location = new System.Drawing.Point(239, 60);
            this.btnCategNueva.Name = "btnCategNueva";
            this.btnCategNueva.Size = new System.Drawing.Size(30, 21);
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
            this.lblCategoria.Location = new System.Drawing.Point(20, 63);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 54;
            this.lblCategoria.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(76, 60);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(157, 21);
            this.cmbCategoria.TabIndex = 55;
            // 
            // cmbRazonSocial
            // 
            this.cmbRazonSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRazonSocial.FormattingEnabled = true;
            this.cmbRazonSocial.Location = new System.Drawing.Point(85, 108);
            this.cmbRazonSocial.Name = "cmbRazonSocial";
            this.cmbRazonSocial.Size = new System.Drawing.Size(156, 21);
            this.cmbRazonSocial.TabIndex = 28;
            // 
            // btnNuevoContacto
            // 
            this.btnNuevoContacto.Location = new System.Drawing.Point(480, 256);
            this.btnNuevoContacto.Name = "btnNuevoContacto";
            this.btnNuevoContacto.Size = new System.Drawing.Size(33, 30);
            this.btnNuevoContacto.TabIndex = 27;
            this.btnNuevoContacto.Text = "+";
            this.btnNuevoContacto.UseVisualStyleBackColor = true;
            this.btnNuevoContacto.Click += new System.EventHandler(this.btnNuevoContacto_Click);
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(29, 240);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(50, 13);
            this.lblContacto.TabIndex = 26;
            this.lblContacto.Text = "Contacto";
            // 
            // dgvContacto
            // 
            this.dgvContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacto.Location = new System.Drawing.Point(14, 256);
            this.dgvContacto.Name = "dgvContacto";
            this.dgvContacto.Size = new System.Drawing.Size(460, 159);
            this.dgvContacto.TabIndex = 25;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(85, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(156, 20);
            this.txtNombre.TabIndex = 24;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(35, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 23;
            this.lblNombre.Text = "Nombre";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(445, 469);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 60;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(335, 469);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 59;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarContacto
            // 
            this.btnEliminarContacto.Location = new System.Drawing.Point(480, 292);
            this.btnEliminarContacto.Name = "btnEliminarContacto";
            this.btnEliminarContacto.Size = new System.Drawing.Size(33, 30);
            this.btnEliminarContacto.TabIndex = 61;
            this.btnEliminarContacto.Text = "-";
            this.btnEliminarContacto.UseVisualStyleBackColor = true;
            // 
            // frmAgregarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 504);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbProveedor);
            this.Name = "frmAgregarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Proveedor";
            this.gbProveedor.ResumeLayout(false);
            this.gbProveedor.PerformLayout();
            this.gbCategoria.ResumeLayout(false);
            this.gbCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.GroupBox gbProveedor;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvContacto;
        private System.Windows.Forms.Button btnNuevoContacto;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.ComboBox cmbRazonSocial;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.Button btnCategNueva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnEliminarContacto;
    }
}