namespace CapaPresentacion
{
    partial class FrmCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtIdProveedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textNombreProveedor = new System.Windows.Forms.TextBox();
            this.BtnBuscarProveedor = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtdocProveedor = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtCantidad = new System.Windows.Forms.NumericUpDown();
            this.TxtIdProducto = new System.Windows.Forms.TextBox();
            this.TxtPrecioVen = new System.Windows.Forms.TextBox();
            this.txtPrecioComp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.BtnbuscarProd = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TxtPrecioTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnRegistrar = new FontAwesome.Sharp.IconButton();
            this.BtnAgregarProd = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(103, 46);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(830, 384);
            this.label10.TabIndex = 24;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Registrar Compra";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.CboTipoDocumento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtFecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(132, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 80);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Compra";
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
            this.label3.Location = new System.Drawing.Point(216, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
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
            this.label2.Location = new System.Drawing.Point(27, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.TxtIdProveedor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textNombreProveedor);
            this.groupBox2.Controls.Add(this.BtnBuscarProveedor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxtdocProveedor);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(528, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 80);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Proveedor";
            // 
            // TxtIdProveedor
            // 
            this.TxtIdProveedor.Location = new System.Drawing.Point(308, 25);
            this.TxtIdProveedor.Name = "TxtIdProveedor";
            this.TxtIdProveedor.Size = new System.Drawing.Size(39, 20);
            this.TxtIdProveedor.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Nro Documento";
            // 
            // textNombreProveedor
            // 
            this.textNombreProveedor.Location = new System.Drawing.Point(219, 51);
            this.textNombreProveedor.Name = "textNombreProveedor";
            this.textNombreProveedor.Size = new System.Drawing.Size(128, 20);
            this.textNombreProveedor.TabIndex = 31;
            // 
            // BtnBuscarProveedor
            // 
            this.BtnBuscarProveedor.BackColor = System.Drawing.Color.White;
            this.BtnBuscarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarProveedor.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscarProveedor.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.BtnBuscarProveedor.IconColor = System.Drawing.Color.Black;
            this.BtnBuscarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscarProveedor.IconSize = 18;
            this.BtnBuscarProveedor.Location = new System.Drawing.Point(161, 50);
            this.BtnBuscarProveedor.Name = "BtnBuscarProveedor";
            this.BtnBuscarProveedor.Size = new System.Drawing.Size(30, 20);
            this.BtnBuscarProveedor.TabIndex = 30;
            this.BtnBuscarProveedor.UseVisualStyleBackColor = false;
            this.BtnBuscarProveedor.Click += new System.EventHandler(this.BtnBuscarProveedor_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Razon Social";
            // 
            // TxtdocProveedor
            // 
            this.TxtdocProveedor.Location = new System.Drawing.Point(27, 50);
            this.TxtdocProveedor.Name = "TxtdocProveedor";
            this.TxtdocProveedor.Size = new System.Drawing.Size(128, 20);
            this.TxtdocProveedor.TabIndex = 29;
            this.TxtdocProveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtdocProveedor_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.TxtCantidad);
            this.groupBox3.Controls.Add(this.TxtIdProducto);
            this.groupBox3.Controls.Add(this.TxtPrecioVen);
            this.groupBox3.Controls.Add(this.txtPrecioComp);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TxtProducto);
            this.groupBox3.Controls.Add(this.BtnbuscarProd);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtCodProducto);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(132, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(681, 74);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion Producto";
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
            // 
            // TxtPrecioVen
            // 
            this.TxtPrecioVen.Location = new System.Drawing.Point(534, 50);
            this.TxtPrecioVen.Name = "TxtPrecioVen";
            this.TxtPrecioVen.Size = new System.Drawing.Size(65, 20);
            this.TxtPrecioVen.TabIndex = 39;
            this.TxtPrecioVen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecioVen_KeyPress);
            // 
            // txtPrecioComp
            // 
            this.txtPrecioComp.Location = new System.Drawing.Point(428, 50);
            this.txtPrecioComp.Name = "txtPrecioComp";
            this.txtPrecioComp.Size = new System.Drawing.Size(64, 20);
            this.txtPrecioComp.TabIndex = 38;
            this.txtPrecioComp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioComp_KeyPress);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(612, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 16);
            this.label11.TabIndex = 37;
            this.label11.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(531, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 16);
            this.label9.TabIndex = 35;
            this.label9.Text = "Precio Venta";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(425, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Precio Compra";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
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
            this.BtnbuscarProd.Location = new System.Drawing.Point(161, 50);
            this.BtnbuscarProd.Name = "BtnbuscarProd";
            this.BtnbuscarProd.Size = new System.Drawing.Size(30, 20);
            this.BtnbuscarProd.TabIndex = 30;
            this.BtnbuscarProd.UseVisualStyleBackColor = false;
            this.BtnbuscarProd.Click += new System.EventHandler(this.BtnbuscarProd_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(216, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(492, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 34;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(607, 214);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(50, 20);
            this.textBox4.TabIndex = 36;
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.BackgroundColor = System.Drawing.Color.White;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal,
            this.BtnEliminar});
            this.DgvData.Location = new System.Drawing.Point(231, 240);
            this.DgvData.Name = "DgvData";
            this.DgvData.Size = new System.Drawing.Size(548, 150);
            this.DgvData.TabIndex = 37;
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
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            // 
            // BtnEliminar
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            this.BtnEliminar.DefaultCellStyle = dataGridViewCellStyle4;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.HeaderText = "";
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Width = 25;
            // 
            // TxtPrecioTotal
            // 
            this.TxtPrecioTotal.Location = new System.Drawing.Point(790, 310);
            this.TxtPrecioTotal.Name = "TxtPrecioTotal";
            this.TxtPrecioTotal.Size = new System.Drawing.Size(88, 20);
            this.TxtPrecioTotal.TabIndex = 42;
            this.TxtPrecioTotal.Text = "0";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(787, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 17);
            this.label12.TabIndex = 41;
            this.label12.Text = "Precio Total";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.BtnRegistrar.IconColor = System.Drawing.Color.Green;
            this.BtnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRegistrar.IconSize = 20;
            this.BtnRegistrar.Location = new System.Drawing.Point(790, 351);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(88, 39);
            this.BtnRegistrar.TabIndex = 43;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnAgregarProd
            // 
            this.BtnAgregarProd.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.BtnAgregarProd.IconColor = System.Drawing.Color.Green;
            this.BtnAgregarProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAgregarProd.Location = new System.Drawing.Point(818, 165);
            this.BtnAgregarProd.Name = "BtnAgregarProd";
            this.BtnAgregarProd.Size = new System.Drawing.Size(75, 69);
            this.BtnAgregarProd.TabIndex = 38;
            this.BtnAgregarProd.Text = "Agregar";
            this.BtnAgregarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAgregarProd.UseVisualStyleBackColor = true;
            this.BtnAgregarProd.Click += new System.EventHandler(this.BtnAgregarProd_Click);
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 494);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.TxtPrecioTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BtnAgregarProd);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Name = "FrmCompras";
            this.Text = "FrmCompras";
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CboTipoDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNombreProveedor;
        private FontAwesome.Sharp.IconButton BtnBuscarProveedor;
        private System.Windows.Forms.TextBox TxtdocProveedor;
        private System.Windows.Forms.TextBox TxtIdProveedor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPrecioComp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtProducto;
        private FontAwesome.Sharp.IconButton BtnbuscarProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.TextBox TxtPrecioVen;
        private System.Windows.Forms.TextBox TxtIdProducto;
        private System.Windows.Forms.NumericUpDown TxtCantidad;
        private System.Windows.Forms.DataGridView DgvData;
        private FontAwesome.Sharp.IconButton BtnAgregarProd;
        private System.Windows.Forms.TextBox TxtPrecioTotal;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton BtnRegistrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEliminar;
    }
}