namespace ProyectoCursos
{
    partial class MantenedorProfesores
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
            this.components = new System.ComponentModel.Container();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblRut = new System.Windows.Forms.Label();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtDigito = new System.Windows.Forms.TextBox();
            this.lblDigito = new System.Windows.Forms.Label();
            this.gridProfesores = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProfesor = new ProyectoCursos.DataSetProfesor();
            this.dataSetProfesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProfesorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProfesorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.profesorTableAdapter = new ProyectoCursos.DataSetProfesorTableAdapters.ProfesorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfesores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProfesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProfesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProfesorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProfesorBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(48, 205);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnAgregar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAgregar_MouseClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(156, 205);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(48, 252);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(156, 252);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(48, 295);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(156, 295);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(48, 347);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(183, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Location = new System.Drawing.Point(45, 27);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(0, 13);
            this.lblRut.TabIndex = 7;
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.Location = new System.Drawing.Point(45, 58);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(0, 13);
            this.lblPrimerNombre.TabIndex = 8;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(45, 146);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(0, 13);
            this.lblPass.TabIndex = 9;
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Location = new System.Drawing.Point(45, 88);
            this.lblSegundoNombre.Name = "lblSegundoNombre";
            this.lblSegundoNombre.Size = new System.Drawing.Size(0, 13);
            this.lblSegundoNombre.TabIndex = 10;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(45, 119);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(0, 13);
            this.lblApellidos.TabIndex = 11;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Location = new System.Drawing.Point(156, 51);
            this.txtPrimerNombre.MaxLength = 10;
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(100, 20);
            this.txtPrimerNombre.TabIndex = 12;
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Location = new System.Drawing.Point(156, 81);
            this.txtSegundoNombre.MaxLength = 10;
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(100, 20);
            this.txtSegundoNombre.TabIndex = 13;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(156, 143);
            this.txtPass.MaxLength = 64;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 14;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(156, 112);
            this.txtApellidos.MaxLength = 15;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 15;
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(156, 20);
            this.txtRut.MaxLength = 8;
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(100, 20);
            this.txtRut.TabIndex = 16;
            // 
            // txtDigito
            // 
            this.txtDigito.Location = new System.Drawing.Point(278, 20);
            this.txtDigito.MaxLength = 1;
            this.txtDigito.Name = "txtDigito";
            this.txtDigito.Size = new System.Drawing.Size(27, 20);
            this.txtDigito.TabIndex = 17;
            // 
            // lblDigito
            // 
            this.lblDigito.AutoSize = true;
            this.lblDigito.Location = new System.Drawing.Point(262, 23);
            this.lblDigito.Name = "lblDigito";
            this.lblDigito.Size = new System.Drawing.Size(0, 13);
            this.lblDigito.TabIndex = 18;
            // 
            // gridProfesores
            // 
            this.gridProfesores.AutoGenerateColumns = false;
            this.gridProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProfesores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.gridProfesores.DataSource = this.profesorBindingSource1;
            this.gridProfesores.Location = new System.Drawing.Point(426, 12);
            this.gridProfesores.Name = "gridProfesores";
            this.gridProfesores.Size = new System.Drawing.Size(318, 350);
            this.gridProfesores.TabIndex = 19;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "rut";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // profesorBindingSource1
            // 
            this.profesorBindingSource1.DataMember = "Profesor";
            this.profesorBindingSource1.DataSource = this.dataSetProfesor;
            // 
            // dataSetProfesor
            // 
            this.dataSetProfesor.DataSetName = "DataSetProfesor";
            this.dataSetProfesor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetProfesorBindingSource
            // 
            this.dataSetProfesorBindingSource.DataSource = this.dataSetProfesor;
            this.dataSetProfesorBindingSource.Position = 0;
            // 
            // dataSetProfesorBindingSource1
            // 
            this.dataSetProfesorBindingSource1.DataSource = typeof(ProyectoCursos.DataSetProfesor);
            this.dataSetProfesorBindingSource1.Position = 0;
            // 
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataMember = "Profesor";
            this.profesorBindingSource.DataSource = this.dataSetProfesor;
            // 
            // dataSetProfesorBindingSource2
            // 
            this.dataSetProfesorBindingSource2.DataSource = this.dataSetProfesor;
            this.dataSetProfesorBindingSource2.Position = 0;
            // 
            // profesorTableAdapter
            // 
            this.profesorTableAdapter.ClearBeforeFill = true;
            // 
            // MantenedorProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 389);
            this.Controls.Add(this.gridProfesores);
            this.Controls.Add(this.lblDigito);
            this.Controls.Add(this.txtDigito);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtSegundoNombre);
            this.Controls.Add(this.txtPrimerNombre);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblSegundoNombre);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblPrimerNombre);
            this.Controls.Add(this.lblRut);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "MantenedorProfesores";
            this.Text = "MantenedorProfesores";
            this.Load += new System.EventHandler(this.MantenedorProfesores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProfesores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProfesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProfesorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProfesorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProfesorBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.Label lblPrimerNombre;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblSegundoNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtDigito;
        private System.Windows.Forms.Label lblDigito;
        private System.Windows.Forms.DataGridView gridProfesores;
        private System.Windows.Forms.BindingSource dataSetProfesorBindingSource;
        private DataSetProfesor dataSetProfesor;
        private System.Windows.Forms.BindingSource dataSetProfesorBindingSource1;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private System.Windows.Forms.BindingSource dataSetProfesorBindingSource2;
        private System.Windows.Forms.BindingSource profesorBindingSource1;
        private DataSetProfesorTableAdapters.ProfesorTableAdapter profesorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
    }
}