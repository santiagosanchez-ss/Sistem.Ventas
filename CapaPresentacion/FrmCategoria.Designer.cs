namespace CapaPresentacion
{
    partial class FrmCategoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtIndice = new System.Windows.Forms.TextBox();
            this.BtnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.Txtbusqueda = new System.Windows.Forms.TextBox();
            this.CboBusqueda = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.DGVData = new System.Windows.Forms.DataGridView();
            this.BtnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.CboEstado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVData)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtIndice
            // 
            this.TxtIndice.Location = new System.Drawing.Point(222, 12);
            this.TxtIndice.Name = "TxtIndice";
            this.TxtIndice.Size = new System.Drawing.Size(39, 20);
            this.TxtIndice.TabIndex = 58;
            this.TxtIndice.Text = "-1";
            this.TxtIndice.Visible = false;
            // 
            // BtnLimpiarBuscador
            // 
            this.BtnLimpiarBuscador.BackColor = System.Drawing.Color.White;
            this.BtnLimpiarBuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiarBuscador.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnLimpiarBuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarBuscador.ForeColor = System.Drawing.Color.Black;
            this.BtnLimpiarBuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.BtnLimpiarBuscador.IconColor = System.Drawing.Color.SkyBlue;
            this.BtnLimpiarBuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLimpiarBuscador.IconSize = 18;
            this.BtnLimpiarBuscador.Location = new System.Drawing.Point(1012, 57);
            this.BtnLimpiarBuscador.Name = "BtnLimpiarBuscador";
            this.BtnLimpiarBuscador.Size = new System.Drawing.Size(30, 20);
            this.BtnLimpiarBuscador.TabIndex = 57;
            this.BtnLimpiarBuscador.UseVisualStyleBackColor = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.White;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.BtnBuscar.IconColor = System.Drawing.Color.ForestGreen;
            this.BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscar.IconSize = 18;
            this.BtnBuscar.Location = new System.Drawing.Point(963, 57);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(30, 20);
            this.BtnBuscar.TabIndex = 56;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // Txtbusqueda
            // 
            this.Txtbusqueda.Location = new System.Drawing.Point(804, 58);
            this.Txtbusqueda.Name = "Txtbusqueda";
            this.Txtbusqueda.Size = new System.Drawing.Size(128, 20);
            this.Txtbusqueda.TabIndex = 55;
            // 
            // CboBusqueda
            // 
            this.CboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBusqueda.FormattingEnabled = true;
            this.CboBusqueda.Location = new System.Drawing.Point(679, 57);
            this.CboBusqueda.Name = "CboBusqueda";
            this.CboBusqueda.Size = new System.Drawing.Size(107, 21);
            this.CboBusqueda.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(592, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "Buscar por:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(177, 12);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(39, 20);
            this.TxtId.TabIndex = 52;
            this.TxtId.Text = "0";
            this.TxtId.Visible = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(312, 41);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label10.Size = new System.Drawing.Size(753, 50);
            this.label10.TabIndex = 51;
            this.label10.Text = "Lista de Categorias:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnEliminar.IconColor = System.Drawing.Color.Black;
            this.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminar.Location = new System.Drawing.Point(37, 206);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(208, 23);
            this.BtnEliminar.TabIndex = 48;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnLimpiar.IconColor = System.Drawing.Color.White;
            this.BtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLimpiar.Location = new System.Drawing.Point(36, 177);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(208, 23);
            this.BtnLimpiar.TabIndex = 47;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // DGVData
            // 
            this.DGVData.AllowUserToAddRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVData.BackgroundColor = System.Drawing.Color.White;
            this.DGVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnSeleccionar,
            this.Id,
            this.Descripcion,
            this.EstadoValor,
            this.Estado});
            this.DGVData.Location = new System.Drawing.Point(312, 108);
            this.DGVData.MultiSelect = false;
            this.DGVData.Name = "DGVData";
            this.DGVData.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVData.RowTemplate.Height = 28;
            this.DGVData.Size = new System.Drawing.Size(323, 213);
            this.DGVData.TabIndex = 50;
            this.DGVData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVData_CellContentClick);
            this.DGVData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DGVData_CellPainting);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.HeaderText = "";
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.ReadOnly = true;
            this.BtnSeleccionar.Width = 30;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 50;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 150;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EstadoValor";
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 24);
            this.label9.TabIndex = 49;
            this.label9.Text = "Detalle Categoria:";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnGuardar.IconColor = System.Drawing.Color.White;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardar.IconSize = 20;
            this.BtnGuardar.Location = new System.Drawing.Point(36, 148);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(208, 23);
            this.BtnGuardar.TabIndex = 46;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // CboEstado
            // 
            this.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEstado.FormattingEnabled = true;
            this.CboEstado.Location = new System.Drawing.Point(37, 108);
            this.CboEstado.Name = "CboEstado";
            this.CboEstado.Size = new System.Drawing.Size(207, 21);
            this.CboEstado.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(33, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Estado:";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(34, 57);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(207, 20);
            this.TxtDescripcion.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 529);
            this.label1.TabIndex = 31;
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 529);
            this.Controls.Add(this.TxtIndice);
            this.Controls.Add(this.BtnLimpiarBuscador);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.Txtbusqueda);
            this.Controls.Add(this.CboBusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.DGVData);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.CboEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCategoria";
            this.Text = "FrmCategoria";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtIndice;
        private FontAwesome.Sharp.IconButton BtnLimpiarBuscador;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TextBox Txtbusqueda;
        private System.Windows.Forms.ComboBox CboBusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private System.Windows.Forms.DataGridView DGVData;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.ComboBox CboEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn BtnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}