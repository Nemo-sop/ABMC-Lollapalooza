
namespace gestorLollapalooza.presLayer.GrupoMusicalPres
{
    partial class frmConsultaGrupoMusical
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaGrupoMusical));
            this.dvgGrupoMusical = new System.Windows.Forms.DataGridView();
            this.gbxFiltros = new System.Windows.Forms.GroupBox();
            this.cbCantidadInt = new System.Windows.Forms.CheckBox();
            this.numCantIntegrantes = new System.Windows.Forms.NumericUpDown();
            this.chbTodos = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbDescripcion = new gestorLollapalooza.frmTextBoxFacha();
            this.txtbNombre = new gestorLollapalooza.frmTextBoxFacha();
            this.btnLimpiar = new gestorLollapalooza.BotonFacha();
            this.btnModificar = new gestorLollapalooza.BotonFacha();
            this.btnEliminar = new gestorLollapalooza.BotonFacha();
            this.btnAgregar = new gestorLollapalooza.BotonFacha();
            this.btnSalir = new gestorLollapalooza.BotonFacha();
            this.btnConsultar = new gestorLollapalooza.BotonFacha();
            this.clmIdGrupoMusical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantIntegrantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgGrupoMusical)).BeginInit();
            this.gbxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantIntegrantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgGrupoMusical
            // 
            this.dvgGrupoMusical.AllowUserToAddRows = false;
            this.dvgGrupoMusical.AllowUserToDeleteRows = false;
            this.dvgGrupoMusical.AllowUserToResizeColumns = false;
            this.dvgGrupoMusical.AllowUserToResizeRows = false;
            this.dvgGrupoMusical.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.dvgGrupoMusical.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgGrupoMusical.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgGrupoMusical.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgGrupoMusical.ColumnHeadersHeight = 30;
            this.dvgGrupoMusical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvgGrupoMusical.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdGrupoMusical,
            this.clmNombre,
            this.clmDescripcion,
            this.clmCantIntegrantes});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgGrupoMusical.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvgGrupoMusical.EnableHeadersVisualStyles = false;
            this.dvgGrupoMusical.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.dvgGrupoMusical.Location = new System.Drawing.Point(423, 15);
            this.dvgGrupoMusical.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvgGrupoMusical.Name = "dvgGrupoMusical";
            this.dvgGrupoMusical.ReadOnly = true;
            this.dvgGrupoMusical.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dvgGrupoMusical.RowHeadersVisible = false;
            this.dvgGrupoMusical.RowHeadersWidth = 51;
            this.dvgGrupoMusical.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgGrupoMusical.Size = new System.Drawing.Size(1004, 437);
            this.dvgGrupoMusical.TabIndex = 9;
            this.dvgGrupoMusical.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgGrupoMusical_CellContentClick);
            // 
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.cbCantidadInt);
            this.gbxFiltros.Controls.Add(this.numCantIntegrantes);
            this.gbxFiltros.Controls.Add(this.chbTodos);
            this.gbxFiltros.Controls.Add(this.label4);
            this.gbxFiltros.Controls.Add(this.label2);
            this.gbxFiltros.Controls.Add(this.label1);
            this.gbxFiltros.Controls.Add(this.txtbDescripcion);
            this.gbxFiltros.Controls.Add(this.txtbNombre);
            this.gbxFiltros.ForeColor = System.Drawing.Color.White;
            this.gbxFiltros.Location = new System.Drawing.Point(17, 15);
            this.gbxFiltros.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gbxFiltros.Size = new System.Drawing.Size(377, 345);
            this.gbxFiltros.TabIndex = 6;
            this.gbxFiltros.TabStop = false;
            this.gbxFiltros.Text = "Filtros";
            // 
            // cbCantidadInt
            // 
            this.cbCantidadInt.AutoSize = true;
            this.cbCantidadInt.Location = new System.Drawing.Point(33, 219);
            this.cbCantidadInt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCantidadInt.Name = "cbCantidadInt";
            this.cbCantidadInt.Size = new System.Drawing.Size(206, 21);
            this.cbCantidadInt.TabIndex = 3;
            this.cbCantidadInt.Text = "por Cantidad de integrantes";
            this.cbCantidadInt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbCantidadInt.UseVisualStyleBackColor = true;
            this.cbCantidadInt.CheckedChanged += new System.EventHandler(this.cbCantidadInt_CheckedChanged);
            // 
            // numCantIntegrantes
            // 
            this.numCantIntegrantes.Enabled = false;
            this.numCantIntegrantes.Location = new System.Drawing.Point(33, 247);
            this.numCantIntegrantes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numCantIntegrantes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantIntegrantes.Name = "numCantIntegrantes";
            this.numCantIntegrantes.Size = new System.Drawing.Size(160, 22);
            this.numCantIntegrantes.TabIndex = 4;
            this.numCantIntegrantes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chbTodos
            // 
            this.chbTodos.AutoSize = true;
            this.chbTodos.Location = new System.Drawing.Point(32, 302);
            this.chbTodos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbTodos.Name = "chbTodos";
            this.chbTodos.Size = new System.Drawing.Size(134, 21);
            this.chbTodos.TabIndex = 5;
            this.chbTodos.Text = "Consultar Todos";
            this.chbTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbTodos.UseVisualStyleBackColor = true;
            this.chbTodos.CheckedChanged += new System.EventHandler(this.chbTodos_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre:";
            // 
            // txtbDescripcion
            // 
            this.txtbDescripcion.BackColor = System.Drawing.Color.White;
            this.txtbDescripcion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbDescripcion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbDescripcion.BorderSize = 2;
            this.txtbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDescripcion.ForeColor = System.Drawing.Color.White;
            this.txtbDescripcion.Location = new System.Drawing.Point(33, 151);
            this.txtbDescripcion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtbDescripcion.Multiline = false;
            this.txtbDescripcion.Name = "txtbDescripcion";
            this.txtbDescripcion.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.txtbDescripcion.PasswordChar = false;
            this.txtbDescripcion.Size = new System.Drawing.Size(304, 43);
            this.txtbDescripcion.TabIndex = 2;
            this.txtbDescripcion.UnderlinedStyle = false;
            // 
            // txtbNombre
            // 
            this.txtbNombre.BackColor = System.Drawing.Color.White;
            this.txtbNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbNombre.BorderSize = 2;
            this.txtbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNombre.ForeColor = System.Drawing.Color.White;
            this.txtbNombre.Location = new System.Drawing.Point(33, 66);
            this.txtbNombre.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtbNombre.Multiline = false;
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.txtbNombre.PasswordChar = false;
            this.txtbNombre.Size = new System.Drawing.Size(304, 43);
            this.txtbNombre.TabIndex = 1;
            this.txtbNombre.UnderlinedStyle = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnLimpiar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnLimpiar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLimpiar.BorderRadius = 20;
            this.btnLimpiar.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(17, 400);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(124, 52);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextColor = System.Drawing.Color.White;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnModificar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnModificar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnModificar.BorderRadius = 20;
            this.btnModificar.BorderSize = 0;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(1451, 135);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(96, 49);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextColor = System.Drawing.Color.White;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnEliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminar.BorderRadius = 20;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(1451, 75);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(96, 49);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregar.BorderRadius = 20;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(1451, 15);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(96, 49);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnSalir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnSalir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSalir.BorderRadius = 20;
            this.btnSalir.BorderSize = 0;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(1451, 400);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 49);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnConsultar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnConsultar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConsultar.BorderRadius = 20;
            this.btnConsultar.BorderSize = 0;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(271, 400);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(124, 52);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextColor = System.Drawing.Color.White;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click_1);
            // 
            // clmIdGrupoMusical
            // 
            this.clmIdGrupoMusical.HeaderText = "Nro Grupo Musical";
            this.clmIdGrupoMusical.MinimumWidth = 6;
            this.clmIdGrupoMusical.Name = "clmIdGrupoMusical";
            this.clmIdGrupoMusical.ReadOnly = true;
            this.clmIdGrupoMusical.Width = 150;
            // 
            // clmNombre
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.clmNombre.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmNombre.FillWeight = 120F;
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.MinimumWidth = 6;
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            this.clmNombre.Width = 150;
            // 
            // clmDescripcion
            // 
            this.clmDescripcion.HeaderText = "Descripción";
            this.clmDescripcion.MinimumWidth = 6;
            this.clmDescripcion.Name = "clmDescripcion";
            this.clmDescripcion.ReadOnly = true;
            this.clmDescripcion.Width = 250;
            // 
            // clmCantIntegrantes
            // 
            this.clmCantIntegrantes.HeaderText = "Cantidad de Integrantes";
            this.clmCantIntegrantes.MinimumWidth = 6;
            this.clmCantIntegrantes.Name = "clmCantIntegrantes";
            this.clmCantIntegrantes.ReadOnly = true;
            this.clmCantIntegrantes.Width = 200;
            // 
            // frmConsultaGrupoMusical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1565, 501);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dvgGrupoMusical);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.gbxFiltros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmConsultaGrupoMusical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestionar Grupos musicales";
            this.Load += new System.EventHandler(this.frmConsultaGrupoMusical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgGrupoMusical)).EndInit();
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantIntegrantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgGrupoMusical;
        private BotonFacha btnSalir;
        private BotonFacha btnConsultar;
        private System.Windows.Forms.GroupBox gbxFiltros;
        private System.Windows.Forms.CheckBox chbTodos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private frmTextBoxFacha txtbDescripcion;
        private frmTextBoxFacha txtbNombre;
        private BotonFacha btnAgregar;
        private BotonFacha btnEliminar;
        private BotonFacha btnModificar;
        private System.Windows.Forms.NumericUpDown numCantIntegrantes;
        private BotonFacha btnLimpiar;
        private System.Windows.Forms.CheckBox cbCantidadInt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdGrupoMusical;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantIntegrantes;
    }
}