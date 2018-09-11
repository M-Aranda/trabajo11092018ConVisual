namespace Trabajo9112018
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblFechaDeNacimiento = new System.Windows.Forms.Label();
            this.lblNumeroDeDocumento = new System.Windows.Forms.Label();
            this.lblFechaDeEmision = new System.Windows.Forms.Label();
            this.lblFechaDeVencimiento = new System.Windows.Forms.Label();
            this.lblRun = new System.Windows.Forms.Label();
            this.lblCiudadDeNacimiento = new System.Windows.Forms.Label();
            this.lblProfesion = new System.Windows.Forms.Label();
            this.lblFotografia = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtFechaDeNacimiento = new System.Windows.Forms.TextBox();
            this.txtProfesion = new System.Windows.Forms.TextBox();
            this.txtFechaDeVencimiento = new System.Windows.Forms.TextBox();
            this.txtFechaDeEmision = new System.Windows.Forms.TextBox();
            this.txtNumeroDeDocumento = new System.Windows.Forms.TextBox();
            this.txtRun = new System.Windows.Forms.TextBox();
            this.cboNacionalidad = new System.Windows.Forms.ComboBox();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.cboCiudadDeNacimiento = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dataGridCedulas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCedulas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(12, 24);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(52, 13);
            this.lblApellidos.TabIndex = 0;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(12, 53);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(52, 13);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombres:";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(12, 80);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(72, 13);
            this.lblNacionalidad.TabIndex = 2;
            this.lblNacionalidad.Text = "Nacionalidad:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(12, 109);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 3;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblFechaDeNacimiento
            // 
            this.lblFechaDeNacimiento.AutoSize = true;
            this.lblFechaDeNacimiento.Location = new System.Drawing.Point(12, 143);
            this.lblFechaDeNacimiento.Name = "lblFechaDeNacimiento";
            this.lblFechaDeNacimiento.Size = new System.Drawing.Size(109, 13);
            this.lblFechaDeNacimiento.TabIndex = 4;
            this.lblFechaDeNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lblNumeroDeDocumento
            // 
            this.lblNumeroDeDocumento.AutoSize = true;
            this.lblNumeroDeDocumento.Location = new System.Drawing.Point(12, 175);
            this.lblNumeroDeDocumento.Name = "lblNumeroDeDocumento";
            this.lblNumeroDeDocumento.Size = new System.Drawing.Size(118, 13);
            this.lblNumeroDeDocumento.TabIndex = 5;
            this.lblNumeroDeDocumento.Text = "Número de documento:";
            // 
            // lblFechaDeEmision
            // 
            this.lblFechaDeEmision.AutoSize = true;
            this.lblFechaDeEmision.Location = new System.Drawing.Point(12, 208);
            this.lblFechaDeEmision.Name = "lblFechaDeEmision";
            this.lblFechaDeEmision.Size = new System.Drawing.Size(93, 13);
            this.lblFechaDeEmision.TabIndex = 6;
            this.lblFechaDeEmision.Text = "Fecha de emisión:";
            // 
            // lblFechaDeVencimiento
            // 
            this.lblFechaDeVencimiento.AutoSize = true;
            this.lblFechaDeVencimiento.Location = new System.Drawing.Point(12, 234);
            this.lblFechaDeVencimiento.Name = "lblFechaDeVencimiento";
            this.lblFechaDeVencimiento.Size = new System.Drawing.Size(115, 13);
            this.lblFechaDeVencimiento.TabIndex = 7;
            this.lblFechaDeVencimiento.Text = "Fecha de vencimiento:";
            // 
            // lblRun
            // 
            this.lblRun.AutoSize = true;
            this.lblRun.Location = new System.Drawing.Point(12, 261);
            this.lblRun.Name = "lblRun";
            this.lblRun.Size = new System.Drawing.Size(37, 13);
            this.lblRun.TabIndex = 8;
            this.lblRun.Text = "R.U.N";
            // 
            // lblCiudadDeNacimiento
            // 
            this.lblCiudadDeNacimiento.AutoSize = true;
            this.lblCiudadDeNacimiento.Location = new System.Drawing.Point(12, 286);
            this.lblCiudadDeNacimiento.Name = "lblCiudadDeNacimiento";
            this.lblCiudadDeNacimiento.Size = new System.Drawing.Size(53, 13);
            this.lblCiudadDeNacimiento.TabIndex = 9;
            this.lblCiudadDeNacimiento.Text = "Nació en:";
            // 
            // lblProfesion
            // 
            this.lblProfesion.AutoSize = true;
            this.lblProfesion.Location = new System.Drawing.Point(12, 317);
            this.lblProfesion.Name = "lblProfesion";
            this.lblProfesion.Size = new System.Drawing.Size(54, 13);
            this.lblProfesion.TabIndex = 10;
            this.lblProfesion.Text = "Profesión:";
            // 
            // lblFotografia
            // 
            this.lblFotografia.AutoSize = true;
            this.lblFotografia.Location = new System.Drawing.Point(12, 345);
            this.lblFotografia.Name = "lblFotografia";
            this.lblFotografia.Size = new System.Drawing.Size(59, 13);
            this.lblFotografia.TabIndex = 11;
            this.lblFotografia.Text = "Fotografía:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(70, 21);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(167, 20);
            this.txtApellidos.TabIndex = 12;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(70, 50);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(167, 20);
            this.txtNombres.TabIndex = 13;
            // 
            // txtFechaDeNacimiento
            // 
            this.txtFechaDeNacimiento.Location = new System.Drawing.Point(137, 140);
            this.txtFechaDeNacimiento.Name = "txtFechaDeNacimiento";
            this.txtFechaDeNacimiento.Size = new System.Drawing.Size(100, 20);
            this.txtFechaDeNacimiento.TabIndex = 14;
            // 
            // txtProfesion
            // 
            this.txtProfesion.Location = new System.Drawing.Point(70, 317);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(167, 20);
            this.txtProfesion.TabIndex = 15;
            // 
            // txtFechaDeVencimiento
            // 
            this.txtFechaDeVencimiento.Location = new System.Drawing.Point(137, 234);
            this.txtFechaDeVencimiento.Name = "txtFechaDeVencimiento";
            this.txtFechaDeVencimiento.Size = new System.Drawing.Size(100, 20);
            this.txtFechaDeVencimiento.TabIndex = 17;
            // 
            // txtFechaDeEmision
            // 
            this.txtFechaDeEmision.Location = new System.Drawing.Point(137, 208);
            this.txtFechaDeEmision.Name = "txtFechaDeEmision";
            this.txtFechaDeEmision.Size = new System.Drawing.Size(100, 20);
            this.txtFechaDeEmision.TabIndex = 18;
            // 
            // txtNumeroDeDocumento
            // 
            this.txtNumeroDeDocumento.Location = new System.Drawing.Point(137, 175);
            this.txtNumeroDeDocumento.Name = "txtNumeroDeDocumento";
            this.txtNumeroDeDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDeDocumento.TabIndex = 19;
            // 
            // txtRun
            // 
            this.txtRun.Location = new System.Drawing.Point(71, 258);
            this.txtRun.Name = "txtRun";
            this.txtRun.Size = new System.Drawing.Size(166, 20);
            this.txtRun.TabIndex = 20;
            // 
            // cboNacionalidad
            // 
            this.cboNacionalidad.FormattingEnabled = true;
            this.cboNacionalidad.Location = new System.Drawing.Point(90, 80);
            this.cboNacionalidad.Name = "cboNacionalidad";
            this.cboNacionalidad.Size = new System.Drawing.Size(147, 21);
            this.cboNacionalidad.TabIndex = 21;
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(70, 107);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(167, 21);
            this.cboSexo.TabIndex = 22;
            // 
            // cboCiudadDeNacimiento
            // 
            this.cboCiudadDeNacimiento.FormattingEnabled = true;
            this.cboCiudadDeNacimiento.Location = new System.Drawing.Point(71, 283);
            this.cboCiudadDeNacimiento.Name = "cboCiudadDeNacimiento";
            this.cboCiudadDeNacimiento.Size = new System.Drawing.Size(166, 21);
            this.cboCiudadDeNacimiento.TabIndex = 23;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(71, 380);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 24;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dataGridCedulas
            // 
            this.dataGridCedulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCedulas.Location = new System.Drawing.Point(392, 261);
            this.dataGridCedulas.Name = "dataGridCedulas";
            this.dataGridCedulas.Size = new System.Drawing.Size(240, 150);
            this.dataGridCedulas.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 468);
            this.Controls.Add(this.dataGridCedulas);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cboCiudadDeNacimiento);
            this.Controls.Add(this.cboSexo);
            this.Controls.Add(this.cboNacionalidad);
            this.Controls.Add(this.txtRun);
            this.Controls.Add(this.txtNumeroDeDocumento);
            this.Controls.Add(this.txtFechaDeEmision);
            this.Controls.Add(this.txtFechaDeVencimiento);
            this.Controls.Add(this.txtProfesion);
            this.Controls.Add(this.txtFechaDeNacimiento);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblFotografia);
            this.Controls.Add(this.lblProfesion);
            this.Controls.Add(this.lblCiudadDeNacimiento);
            this.Controls.Add(this.lblRun);
            this.Controls.Add(this.lblFechaDeVencimiento);
            this.Controls.Add(this.lblFechaDeEmision);
            this.Controls.Add(this.lblNumeroDeDocumento);
            this.Controls.Add(this.lblFechaDeNacimiento);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblApellidos);
            this.Name = "Form1";
            this.Text = "Sistema de cédulas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCedulas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblFechaDeNacimiento;
        private System.Windows.Forms.Label lblNumeroDeDocumento;
        private System.Windows.Forms.Label lblFechaDeEmision;
        private System.Windows.Forms.Label lblFechaDeVencimiento;
        private System.Windows.Forms.Label lblRun;
        private System.Windows.Forms.Label lblCiudadDeNacimiento;
        private System.Windows.Forms.Label lblProfesion;
        private System.Windows.Forms.Label lblFotografia;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtFechaDeNacimiento;
        private System.Windows.Forms.TextBox txtProfesion;
        private System.Windows.Forms.TextBox txtFechaDeVencimiento;
        private System.Windows.Forms.TextBox txtFechaDeEmision;
        private System.Windows.Forms.TextBox txtNumeroDeDocumento;
        private System.Windows.Forms.TextBox txtRun;
        private System.Windows.Forms.ComboBox cboNacionalidad;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.ComboBox cboCiudadDeNacimiento;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dataGridCedulas;
    }
}

