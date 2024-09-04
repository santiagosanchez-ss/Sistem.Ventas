namespace CapaPresentacion
{
    partial class FrmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtCantidad = new System.Windows.Forms.NumericUpDown();
            this.TxtIdProducto = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnRegistrar = new FontAwesome.Sharp.IconButton();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.TxtCambio = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnAgregarProd = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.BtnBuscarCliente = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtdocCliente = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.BtnbuscarProd = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtTotalAPagar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtPagaCon = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(615, 50);
            this.TxtCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TxtCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(48, 20);
            this.TxtCantidad.TabIndex = 40;
            this.TxtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TxtIdProducto
            // 
            this.TxtIdProducto.Location = new System.Drawing.Point(140, 24);
            this.TxtIdProducto.Name = "TxtIdProducto";
            this.TxtIdProducto.Size = new System.Drawing.Size(39, 20);
            this.TxtIdProducto.TabIndex = 33;
            this.TxtIdProducto.Visible = false;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(428, 50);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(97, 20);
            this.TxtPrecio.TabIndex = 38;
            this.TxtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(612, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 17);
            this.label11.TabIndex = 37;
            this.label11.Text = "Cantidad";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.Color.White;
            this.BtnRegistrar.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.BtnRegistrar.IconColor = System.Drawing.Color.Green;
            this.BtnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRegistrar.IconSize = 20;
            this.BtnRegistrar.Location = new System.Drawing.Point(806, 346);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(88, 40);
            this.BtnRegistrar.TabIndex = 55;
            this.BtnRegistrar.Text = "Crear Venta";
            this.BtnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.BackgroundColor = System.Drawing.Color.White;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.SubTotal,
            this.BtnEliminar});
            this.DgvData.Location = new System.Drawing.Point(249, 216);
            this.DgvData.Name = "DgvData";
            this.DgvData.Size = new System.Drawing.Size(548, 170);
            this.DgvData.TabIndex = 51;
            this.DgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellContentClick);
            this.DgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DgvData_CellPainting);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            this.IdProducto.Width = 50;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.Width = 150;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio ";
            this.Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            // 
            // BtnEliminar
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            this.BtnEliminar.DefaultCellStyle = dataGridViewCellStyle3;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.HeaderText = "";
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Width = 25;
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(534, 50);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(75, 20);
            this.TxtStock.TabIndex = 39;
            // 
            // TxtCambio
            // 
            this.TxtCambio.Location = new System.Drawing.Point(806, 321);
            this.TxtCambio.Name = "TxtCambio";
            this.TxtCambio.Size = new System.Drawing.Size(88, 20);
            this.TxtCambio.TabIndex = 54;
            this.TxtCambio.Text = "0";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(803, 300);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 18);
            this.label12.TabIndex = 53;
            this.label12.Text = "Cambio";
            // 
            // BtnAgregarProd
            // 
            this.BtnAgregarProd.BackColor = System.Drawing.Color.White;
            this.BtnAgregarProd.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.BtnAgregarProd.IconColor = System.Drawing.Color.Green;
            this.BtnAgregarProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAgregarProd.Location = new System.Drawing.Point(836, 141);
            this.BtnAgregarProd.Name = "BtnAgregarProd";
            this.BtnAgregarProd.Size = new System.Drawing.Size(75, 70);
            this.BtnAgregarProd.TabIndex = 52;
            this.BtnAgregarProd.Text = "Agregar";
            this.BtnAgregarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAgregarProd.UseVisualStyleBackColor = false;
            this.BtnAgregarProd.Click += new System.EventHandler(this.BtnAgregarProd_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(531, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Stock";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Nro Documento";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.CboTipoDocumento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtFecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(150, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 81);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Venta";
            // 
            // CboTipoDocumento
            // 
            this.CboTipoDocumento.FormattingEnabled = true;
            this.CboTipoDocumento.Location = new System.Drawing.Point(219, 50);
            this.CboTipoDocumento.Name = "CboTipoDocumento";
            this.CboTipoDocumento.Size = new System.Drawing.Size(121, 21);
            this.CboTipoDocumento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Documento";
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(30, 50);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(123, 20);
            this.TxtFecha.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "Registrar Venta";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.TxtIdCliente);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNombreCliente);
            this.groupBox2.Controls.Add(this.BtnBuscarCliente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxtdocCliente);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(546, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 81);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Cliente";
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.Location = new System.Drawing.Point(326, 25);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(39, 20);
            this.TxtIdCliente.TabIndex = 28;
            this.TxtIdCliente.Visible = false;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(219, 51);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(128, 20);
            this.txtNombreCliente.TabIndex = 31;
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.BackColor = System.Drawing.Color.White;
            this.BtnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarCliente.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.BtnBuscarCliente.IconColor = System.Drawing.Color.ForestGreen;
            this.BtnBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscarCliente.IconSize = 18;
            this.BtnBuscarCliente.Location = new System.Drawing.Point(161, 49);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(30, 21);
            this.BtnBuscarCliente.TabIndex = 30;
            this.BtnBuscarCliente.UseVisualStyleBackColor = false;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "NombreCompleto";
            // 
            // TxtdocCliente
            // 
            this.TxtdocCliente.Location = new System.Drawing.Point(27, 50);
            this.TxtdocCliente.Name = "TxtdocCliente";
            this.TxtdocCliente.Size = new System.Drawing.Size(128, 20);
            this.TxtdocCliente.TabIndex = 29;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.TxtCantidad);
            this.groupBox3.Controls.Add(this.TxtIdProducto);
            this.groupBox3.Controls.Add(this.TxtStock);
            this.groupBox3.Controls.Add(this.TxtPrecio);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TxtProducto);
            this.groupBox3.Controls.Add(this.BtnbuscarProd);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtCodProducto);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(150, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(681, 75);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion Producto";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(425, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Precio ";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Codigo Producto";
            // 
            // TxtProducto
            // 
            this.TxtProducto.Location = new System.Drawing.Point(219, 50);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(191, 20);
            this.TxtProducto.TabIndex = 31;
            // 
            // BtnbuscarProd
            // 
            this.BtnbuscarProd.BackColor = System.Drawing.Color.White;
            this.BtnbuscarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnbuscarProd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnbuscarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnbuscarProd.ForeColor = System.Drawing.Color.Black;
            this.BtnbuscarProd.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.BtnbuscarProd.IconColor = System.Drawing.Color.Black;
            this.BtnbuscarProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnbuscarProd.IconSize = 18;
            this.BtnbuscarProd.Location = new System.Drawing.Point(161, 49);
            this.BtnbuscarProd.Name = "BtnbuscarProd";
            this.BtnbuscarProd.Size = new System.Drawing.Size(30, 21);
            this.BtnbuscarProd.TabIndex = 30;
            this.BtnbuscarProd.UseVisualStyleBackColor = false;
            this.BtnbuscarProd.Click += new System.EventHandler(this.BtnbuscarProd_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(216, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Producto";
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Location = new System.Drawing.Point(27, 50);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(128, 20);
            this.txtCodProducto.TabIndex = 29;
            this.txtCodProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodProducto_KeyDown);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(131, 19);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(830, 386);
            this.label10.TabIndex = 44;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtTotalAPagar
            // 
            this.TxtTotalAPagar.Location = new System.Drawing.Point(806, 237);
            this.TxtTotalAPagar.Name = "TxtTotalAPagar";
            this.TxtTotalAPagar.Size = new System.Drawing.Size(88, 20);
            this.TxtTotalAPagar.TabIndex = 57;
            this.TxtTotalAPagar.Text = "0";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(803, 216);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 18);
            this.label13.TabIndex = 56;
            this.label13.Text = "Total a Pagar";
            // 
            // TxtPagaCon
            // 
            this.TxtPagaCon.Location = new System.Drawing.Point(806, 281);
            this.TxtPagaCon.Name = "TxtPagaCon";
            this.TxtPagaCon.Size = new System.Drawing.Size(88, 20);
            this.TxtPagaCon.TabIndex = 59;
            this.TxtPagaCon.Text = "0";
            this.TxtPagaCon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPagaCon_KeyDown_1);
            this.TxtPagaCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPagaCon_KeyPress);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(803, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 18);
            this.label14.TabIndex = 58;
            this.label14.Text = "Paga con";
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 468);
            this.Controls.Add(this.TxtPagaCon);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TxtTotalAPagar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.TxtCambio);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BtnAgregarProd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label10);
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown TxtCantidad;
        private System.Windows.Forms.TextBox TxtIdProducto;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton BtnRegistrar;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.TextBox TxtCambio;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton BtnAgregarProd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CboTipoDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtIdCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private FontAwesome.Sharp.IconButton BtnBuscarCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtdocCliente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtProducto;
        private FontAwesome.Sharp.IconButton BtnbuscarProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtTotalAPagar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEliminar;
        private System.Windows.Forms.TextBox TxtPagaCon;
        private System.Windows.Forms.Label label14;
    }
}