using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaFacturacion
{
    public partial class FormVistaPrevia : Form
    {
        PdfiumViewer.PdfViewer pdf;

        public bool IsShown
        { get; set; }

        public FormVistaPrevia()
        {
            InitializeComponent();
            this.Height = 700;
            this.Location = new Point(0, 0);
            pdf = new PdfViewer();
            pdf.Visible = true;
            this.Controls.Add(pdf);

            pdf.Dock = DockStyle.Fill;
            pdf.ZoomMode = PdfViewerZoomMode.FitWidth;
        }

        private void FormVistaPrevia_Load(object sender, EventArgs e)
        {

        }

        public void Navegar(string path)
        {
            byte[] bytes = System.IO.File.ReadAllBytes(@path);
            var stream = new MemoryStream(bytes);
            PdfDocument pdfDocument = PdfDocument.Load(stream);
            pdf.Document = pdfDocument;
            this.CenterToScreen();
            this.Height = 700;
        }

        public int cantidadDePaginas(string path)
        {
            byte[] bytes = System.IO.File.ReadAllBytes(@path);
            var stream = new MemoryStream(bytes);
            PdfDocument pdfDocument = PdfDocument.Load(stream);
            pdf.Document = pdfDocument;
            int cantidadPaginas = pdf.Document.PageCount;
            this.CenterToScreen();
            this.Height = 700;
            return cantidadPaginas;
        }

        private void FormVistaPrevia_SizeChanged(object sender, EventArgs e)
        {
         
            if (pdf != null)
            {
                pdf.Width = this.Width - 30;
                int extraHeight = this.Height - pdf.Height;
                if (extraHeight > 0)
                    pdf.Height += extraHeight;
                else
                    pdf.Height -= extraHeight;
                pdf.Height -= 40;
            }
        
        }
    }
}
