using SERLabLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace SERLab
{
    public partial class CargarDetalle : Form
    {
        public int idDetalleResultado { get; set; }
        public int idResultado { get; set; }
        public CargarDetalle()
        {
            InitializeComponent();
        }

        private void CargarResultado()
        {
            try
            {
                clsResultado resultado = new clsResultado();
                resultado.idResultado = idResultado;
                miGridResultado.DataSource = resultado.consultarPorID();
            }
            catch (Exception)
            {

            }
        }

        private void CargarDetalles()
        {
            try
            {
                clsDetalle detalle = new clsDetalle();
                detalle.resultados = new clsResultado();
                detalle.resultados.idResultado = idResultado;
                miGridDetalles.DataSource = detalle.consultarPorID();
            }
            catch (Exception)
            {

            }
        }
        private void CargarDetalle_Load(object sender, EventArgs e)
        {
            CargarResultado();
            CargarDetalles();
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            //hacer el pdf aqui
            SaveFileDialog savefile = new SaveFileDialog();

            savefile.AddExtension = true;
            string PaginaHTML_Texto = Properties.Resources.ReporteResultadoExamen.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@idResultado", idResultado.ToString());

            string filas = string.Empty;
            foreach (DataGridViewRow row in miGridResultado.Rows)
            {
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", row.Cells["Medico"].Value.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", row.Cells["Paciente"].Value.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Parse(row.Cells["fechaRealizada"].Value.ToString()).ToString("dd-MM-yyyy"));
                savefile.FileName = string.Format("{0}.PDF", row.Cells["Paciente"].Value.ToString() + " (" + DateTime.Now.ToString("dd-MM-yyyy HH mm ss") + ")");
            }

            foreach (DataGridViewRow row in miGridDetalles.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["nombre"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["resultado"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["unidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["rangoReferencia"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);


            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    //Agregamos la imagen del banner al documento
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.Logo_Lab, System.Drawing.Imaging.ImageFormat.Jpeg);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    //img.SetAbsolutePosition(10,100);
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);


                    //pdfDoc.Add(new Phrase("Hola Mundo"));
                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }

            }

        }
    }
}
