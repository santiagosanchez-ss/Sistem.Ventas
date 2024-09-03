﻿using CapaEntidad;
using CapaNegocio;
using DocumentFormat.OpenXml.Wordprocessing;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using iTextSharp.text;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.tool.xml;
using ClosedXML;

namespace CapaPresentacion
{
    public partial class FrmDetalleCompra : Form
    {
        public FrmDetalleCompra()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            NumberFormatInfo formato = new CultureInfo("es-AR").NumberFormat;
            formato.CurrencyGroupSeparator = ".";
            formato.NumberDecimalSeparator = ",";
            formato.CurrencySymbol = "$";
            Compra oCompra = new CNCompra().ObtenerCompra(TxtBusqueda.Text);

            if(oCompra.IdCompra !=0)
            {
                TxtDocumento.Text = oCompra.NumeroDocumento;
                TxtFechaCompra.Text = oCompra.FechaRegistro;
                TxtDocumento.Text =oCompra.TipoDocumento;
                TxtUsuario.Text = oCompra.oUsuario.NombreCompleto;
                TxtDocumentoProv.Text = oCompra.oProveedor.Documento;
                TxtRazonSocial.Text = oCompra.oProveedor.RazonSocial;

                DgvData.Rows.Clear();

                foreach (DetalleCompra dc in oCompra.oDetalleCompra)
                {
                    DgvData.Rows.Add(new object[] { dc.oProducto.Nombre, dc.PrecioCompra, dc.Cantidad, dc.MontoTotal });
                }
                TxtMontoTotal.Text = oCompra.MontoTotal.ToString("0.00");
            }else
            {
                MessageBox.Show("Ingrese un codigo valido");
            }

            
        }

        private void BtnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            TxtFechaCompra.Text = "";
            TxtDocumento.Text = "";
            TxtUsuario.Text = "";
            TxtDocumentoProv.Text = "";
            TxtRazonSocial.Text = "";
            DgvData.Rows.Clear();
            TxtMontoTotal.Text = "0.00";
        }

        private void BtnDescargarPDF_Click(object sender, EventArgs e)
        {
            if(TxtDocumento.Text =="")
            {
                MessageBox.Show ("No se encontraron los resultados.", "Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;  
            }

            
            string Texto_Html = Properties.Resources.PlatillaCompra.ToString();// en la variable TEXTO_HTML guardamos la plantilla compra
            Negocio oDatos = new CNNegocio().ObtenerDatos();


                //REEMPLAZAMOS LA INFORMACION DEL TEXTO CON LA INFORMACION DEL OBJETO OdATOS
            Texto_Html = Texto_Html.Replace("@nombrenegocio", oDatos.Nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", oDatos.RUC);
            Texto_Html = Texto_Html.Replace("@Direcnegocio", oDatos.Direccion);
            
          
            Texto_Html = Texto_Html.Replace("@tipodocumento",TxtTipoDocumento.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", TxtDocumento.Text);
            
            
            Texto_Html = Texto_Html.Replace("@docproveedor", TxtDocumentoProv.Text);
            Texto_Html = Texto_Html.Replace("@nombreproveedor", TxtRazonSocial.Text);
            Texto_Html = Texto_Html.Replace("@fecharegistro", TxtFechaCompra.Text);
            Texto_Html = Texto_Html.Replace("@usuarioregistro", TxtUsuario.Text);

          //TOTAMOS LA DATA DEL DGVDATAGRIDVIEW DEL DETALLE COMPRA Y LO IMCLUIMOS EN LA SECCION FILA DEL ARCHIVO PDF
            string filas = string.Empty;    
            foreach(DataGridViewRow row in DgvData.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioCompra"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }


            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", TxtMontoTotal.Text);


            //Ventana de dialogo que nos dice donde guardar
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.FileName = string.Format("Compra{0}[{1}].pdf", TxtBusqueda.Text,TxtFechaCompra.Text);
            SaveFile.Filter = "pdf files|*.pdf";

            //SI SaveFila no falla 
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {

                using (FileStream stream = new FileStream(SaveFile.FileName, FileMode.Create))
                {
                    //Le damos un estilo a la pagina
                    iTextSharp.text.Document PdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 25, 25, 25, 25);
                    //Creamos una instancia de el pdf y lo almacenamos enn la variable writer que es un archivo de memoria 
                    PdfWriter writer = PdfWriter.GetInstance(PdfDoc, stream);
                    //abrimos el doc
                    PdfDoc.Open();

                    //Declaramos una variable obtenido para almacenar la imagen 
                    bool Obtenido = true;
                    
                    //nuestra imagen es un array de bytes asi que en esta variable de tipo byte lo que obtenemos es el resultado del metodo ObenerLogo
                    byte[] byteImage = new CNNegocio().ObtenerLogo(out Obtenido);
                    

                    if(Obtenido)
                    {
                        // creamos una img en base a ese array de bytes y la guardamos en la variable img
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
                        img.ScaleToFit(60,90);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING; //alineamos la imagen sobre el texto 
                        img.SetAbsolutePosition(PdfDoc.Left, PdfDoc.GetTop(51)); //le damos un aposicion en el eje x y en el eje y
                        PdfDoc.Add(img);// le añadimos la fot al PDF


                    }
                    //Pegamos todo el texto HTML en el pdf
                    using(StringReader sr = new StringReader(Texto_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer,PdfDoc, sr);
                    }
                    PdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information); 



                }

            }
        }

        
    }
}
