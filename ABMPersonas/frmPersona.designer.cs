namespace ABMPersonas
{
    partial class frmPersona
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.cboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.chkFallecio = new System.Windows.Forms.CheckBox();
            this.lstPersonas = new System.Windows.Forms.ListBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(76, 30);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(71, 67);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombres";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(34, 104);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(86, 13);
            this.lblTipoDocumento.TabIndex = 2;
            this.lblTipoDocumento.Text = "Tipo Documento";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(58, 141);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(62, 13);
            this.lblDocumento.TabIndex = 3;
            this.lblDocumento.Text = "Documento";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(58, 178);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(62, 13);
            this.lblEstadoCivil.TabIndex = 4;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(89, 215);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 5;
            this.lblSexo.Text = "Sexo";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(157, 26);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(177, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(157, 62);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(177, 20);
            this.txtNombres.TabIndex = 7;
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(157, 98);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(177, 21);
            this.cboTipoDocumento.TabIndex = 8;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(157, 135);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(177, 20);
            this.txtDocumento.TabIndex = 9;
            // 
            // cboEstadoCivil
            // 
            this.cboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Location = new System.Drawing.Point(157, 171);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(177, 21);
            this.cboEstadoCivil.TabIndex = 10;
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Location = new System.Drawing.Point(157, 208);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbtFemenino.TabIndex = 11;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(157, 241);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtMasculino.TabIndex = 12;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // chkFallecio
            // 
            this.chkFallecio.AutoSize = true;
            this.chkFallecio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFallecio.Location = new System.Drawing.Point(74, 286);
            this.chkFallecio.Name = "chkFallecio";
            this.chkFallecio.Size = new System.Drawing.Size(98, 17);
            this.chkFallecio.TabIndex = 13;
            this.chkFallecio.Text = "Fallecido          ";
            this.chkFallecio.UseVisualStyleBackColor = true;
            // 
            // lstPersonas
            // 
            this.lstPersonas.FormattingEnabled = true;
            this.lstPersonas.Location = new System.Drawing.Point(352, 26);
            this.lstPersonas.Name = "lstPersonas";
            this.lstPersonas.Size = new System.Drawing.Size(199, 277);
            this.lstPersonas.TabIndex = 14;
            this.lstPersonas.SelectedIndexChanged += new System.EventHandler(this.lstPersonas_SelectedIndexChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(21, 330);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(112, 330);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(203, 330);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 17;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(294, 330);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 18;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(385, 330);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(476, 330);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 369);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lstPersonas);
            this.Controls.Add(this.chkFallecio);
            this.Controls.Add(this.rbtMasculino);
            this.Controls.Add(this.rbtFemenino);
            this.Controls.Add(this.cboEstadoCivil);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.cboTipoDocumento);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblApellido);
            this.Name = "frmPersona";
            this.Text = "A B M Personas";
            this.Load += new System.EventHandler(this.frmPersona_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.ComboBox cboEstadoCivil;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.CheckBox chkFallecio;
        private System.Windows.Forms.ListBox lstPersonas;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
    }
}

