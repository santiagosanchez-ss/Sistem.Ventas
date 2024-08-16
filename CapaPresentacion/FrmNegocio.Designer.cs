namespace CapaPresentacion
{
    partial class FrmNegocio
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
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSubirImg = new FontAwesome.Sharp.IconButton();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.TxtRUC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNombreNegocio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 24);
            this.label9.TabIndex = 23;
            this.label9.Text = "Detalle Negocio:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 450);
            this.label1.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.BtnSubirImg);
            this.groupBox1.Controls.Add(this.BtnGuardar);
            this.groupBox1.Controls.Add(this.TxtRUC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PicLogo);
            this.groupBox1.Controls.Add(this.TxtDireccion);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelNombreNegocio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(16, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 230);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // BtnSubirImg
            // 
            this.BtnSubirImg.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnSubirImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSubirImg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSubirImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubirImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubirImg.ForeColor = System.Drawing.Color.White;
            this.BtnSubirImg.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.BtnSubirImg.IconColor = System.Drawing.Color.LawnGreen;
            this.BtnSubirImg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSubirImg.IconSize = 13;
            this.BtnSubirImg.Location = new System.Drawing.Point(9, 167);
            this.BtnSubirImg.Name = "BtnSubirImg";
            this.BtnSubirImg.Size = new System.Drawing.Size(130, 21);
            this.BtnSubirImg.TabIndex = 35;
            this.BtnSubirImg.Text = "Subir ";
            this.BtnSubirImg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSubirImg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSubirImg.UseVisualStyleBackColor = false;
            this.BtnSubirImg.Click += new System.EventHandler(this.BtnSubirImg_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnGuardar.IconColor = System.Drawing.Color.White;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardar.IconSize = 20;
            this.BtnGuardar.Location = new System.Drawing.Point(332, 167);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(63, 21);
            this.BtnGuardar.TabIndex = 34;
            this.BtnGuardar.Text = "Guardar ";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtRUC
            // 
            this.TxtRUC.Location = new System.Drawing.Point(189, 87);
            this.TxtRUC.Name = "TxtRUC";
            this.TxtRUC.Size = new System.Drawing.Size(206, 20);
            this.TxtRUC.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Logo";
            // 
            // PicLogo
            // 
            this.PicLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicLogo.Location = new System.Drawing.Point(9, 31);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(130, 130);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 25;
            this.PicLogo.TabStop = false;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(189, 141);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(206, 20);
            this.TxtDireccion.TabIndex = 32;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(189, 31);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(206, 20);
            this.TxtNombre.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(185, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "R.U.C :";
            // 
            // labelNombreNegocio
            // 
            this.labelNombreNegocio.AutoSize = true;
            this.labelNombreNegocio.BackColor = System.Drawing.Color.White;
            this.labelNombreNegocio.Location = new System.Drawing.Point(188, 15);
            this.labelNombreNegocio.Name = "labelNombreNegocio";
            this.labelNombreNegocio.Size = new System.Drawing.Size(93, 13);
            this.labelNombreNegocio.TabIndex = 28;
            this.labelNombreNegocio.Text = "Nombre Negocio :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(185, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Direccion :";
            // 
            // FrmNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "FrmNegocio";
            this.Text = "FrmNegocio";
            this.Load += new System.EventHandler(this.FrmNegocio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PicLogo;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.TextBox TxtRUC;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNombreNegocio;
        private FontAwesome.Sharp.IconButton BtnSubirImg;
    }
}