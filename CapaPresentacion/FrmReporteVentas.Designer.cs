﻿namespace CapaPresentacion
{
    partial class FrmReporteVentas
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
            this.BtnExcel = new FontAwesome.Sharp.IconButton();
            this.Txtbusqueda = new System.Windows.Forms.TextBox();
            this.CboBusqueda = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.DGVData = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.TxtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVData)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExcel
            // 
            this.BtnExcel.BackColor = System.Drawing.Color.White;
            this.BtnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExcel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcel.ForeColor = System.Drawing.Color.Black;
            this.BtnExcel.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.BtnExcel.IconColor = System.Drawing.Color.LimeGreen;
            this.BtnExcel.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnExcel.IconSize = 18;
            this.BtnExcel.Location = new System.Drawing.Point(226, 94);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(171, 29);
            this.BtnExcel.TabIndex = 80;
            this.BtnExcel.Text = "Descargar a Excel";
            this.BtnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExcel.UseVisualStyleBackColor = false;
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // Txtbusqueda
            // 
            this.Txtbusqueda.Location = new System.Drawing.Point(615, 103);
            this.Txtbusqueda.Name = "Txtbusqueda";
            this.Txtbusqueda.Size = new System.Drawing.Size(121, 20);
            this.Txtbusqueda.TabIndex = 77;
            // 
            // CboBusqueda
            // 
            this.CboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBusqueda.FormattingEnabled = true;
            this.CboBusqueda.Location = new System.Drawing.Point(491, 102);
            this.CboBusqueda.Name = "CboBusqueda";
            this.CboBusqueda.Size = new System.Drawing.Size(100, 21);
            this.CboBusqueda.TabIndex = 76;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(415, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 75;
            this.label11.Text = "Buscar por:";
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
            this.BtnLimpiarBuscador.Location = new System.Drawing.Point(782, 103);
            this.BtnLimpiarBuscador.Name = "BtnLimpiarBuscador";
            this.BtnLimpiarBuscador.Size = new System.Drawing.Size(34, 20);
            this.BtnLimpiarBuscador.TabIndex = 78;
            this.BtnLimpiarBuscador.UseVisualStyleBackColor = false;
            this.BtnLimpiarBuscador.Click += new System.EventHandler(this.BtnLimpiarBuscador_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.iconButton1.IconColor = System.Drawing.Color.ForestGreen;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 18;
            this.iconButton1.Location = new System.Drawing.Point(742, 103);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(34, 20);
            this.iconButton1.TabIndex = 79;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
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
            this.FechaRegistro,
            this.TipoDocumento,
            this.NumeroDocumento,
            this.MontoTotal,
            this.UsuarioRegistro,
            this.DocumentoCliente,
            this.NombreCliente,
            this.CodigoProducto,
            this.NombreProducto,
            this.Categoria,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal});
            this.DGVData.Location = new System.Drawing.Point(61, 137);
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
            this.DGVData.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.DGVData.Size = new System.Drawing.Size(1003, 300);
            this.DGVData.TabIndex = 74;
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
            this.BtnBuscar.Location = new System.Drawing.Point(599, 57);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(34, 20);
            this.BtnBuscar.TabIndex = 73;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "Fecha Fin";
            // 
            // TxtFechaFin
            // 
            this.TxtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtFechaFin.Location = new System.Drawing.Point(491, 57);
            this.TxtFechaFin.Name = "TxtFechaFin";
            this.TxtFechaFin.Size = new System.Drawing.Size(92, 20);
            this.TxtFechaFin.TabIndex = 69;
            // 
            // TxtFechaInicio
            // 
            this.TxtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtFechaInicio.Location = new System.Drawing.Point(305, 57);
            this.TxtFechaInicio.Name = "TxtFechaInicio";
            this.TxtFechaInicio.Size = new System.Drawing.Size(92, 20);
            this.TxtFechaInicio.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Fecha Inicio";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(798, 107);
            this.label1.TabIndex = 66;
            this.label1.Text = "Reporte Compras";
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.HeaderText = "Num. Documento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            // 
            // UsuarioRegistro
            // 
            this.UsuarioRegistro.HeaderText = "Usuario Registro";
            this.UsuarioRegistro.Name = "UsuarioRegistro";
            this.UsuarioRegistro.ReadOnly = true;
            // 
            // DocumentoCliente
            // 
            this.DocumentoCliente.HeaderText = "Doc Cliente";
            this.DocumentoCliente.Name = "DocumentoCliente";
            this.DocumentoCliente.ReadOnly = true;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "Cod. Producto";
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nom. Prod";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // FrmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 450);
            this.Controls.Add(this.BtnExcel);
            this.Controls.Add(this.Txtbusqueda);
            this.Controls.Add(this.CboBusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtnLimpiarBuscador);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.DGVData);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtFechaFin);
            this.Controls.Add(this.TxtFechaInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmReporteVentas";
            this.Text = "FrmReporteventas";
            this.Load += new System.EventHandler(this.FrmReporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnExcel;
        private System.Windows.Forms.TextBox Txtbusqueda;
        private System.Windows.Forms.ComboBox CboBusqueda;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton BtnLimpiarBuscador;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridView DGVData;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker TxtFechaFin;
        private System.Windows.Forms.DateTimePicker TxtFechaInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}