using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SistemaFacturacion
{
    class Facturas
    {

        private static void getPaths()
        {
            string[] lines = new string[0];
            try
            {

                lines = System.IO.File.ReadAllLines(@"" + System.Windows.Forms.Application.StartupPath + "\\paths.txt");
                pathPlantillaSinEncabezado = lines[0];//archivo excel sin encabezados
                pathPlantillaFacturacion = lines[1];//factura final
            }
            catch
            {
                Utilidades.mostrarMensajeValidacion("No se pudo leer la configuración. Verificar el archivo de paths.");
                System.Environment.Exit(1);
            }
        }

        public static void generar_excel(DataTable tabla)
        {
            //Primero recibe los registros del DataTable
            if (tabla == null)
            {
                MessageBox.Show("No se han encontrado registros");
            }
            else
            {
                Facturas.getPaths();
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(Facturas.pathPlantillaSinEncabezado);
                Microsoft.Office.Interop.Excel.Workbook workbookExportacion;
                //Obtenemos todas las hojas de la plantilla 
                Microsoft.Office.Interop.Excel.Sheets sheets = xlWorkBook.Worksheets;
                //Obtenemos la primera hoja de la plantilla 
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = xlApp.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;
                //Se copia la hoja actual y se coloca automáticamente en un nuevo workbook. 
                xlWorkSheet.Copy(Type.Missing, Type.Missing);
                //Cerramos la plantilla original de excel. 
                xlWorkBook.Close(0);
                //Comenzamos a trabajar con el workbook de exportación 
                //Asignamos un identificador para nuestro workbook 
                workbookExportacion = xlApp.ActiveWorkbook;
                Microsoft.Office.Interop.Excel.Sheets sheetsExportacion = workbookExportacion.Worksheets;
                Microsoft.Office.Interop.Excel.Worksheet sheetExportacion = xlApp.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;
                //Copiamos la tabla de exportación al portaPapeles            
                Utilidades.CopyDataTableToClipboard(tabla, false);
                Microsoft.Office.Interop.Excel.Range CR = sheetExportacion.Cells[1, 1] as Microsoft.Office.Interop.Excel.Range;
                CR.Select();
                sheetExportacion.Paste(CR, Clipboard.GetText());

             
                //iteración de la tabla creada sin encabezados
               
                int celdaCambioInicio = 20;
                int celdaCambioFinal = 20;
                //Obtenemos los límites de la hoja
                int cantidadRegistros = tabla.Rows.Count;
                int ultimaCelda = (cantidadRegistros) + 20;

                //Hacemos el merge del último periodo. 
                if (celdaCambioFinal == 20)
                {
                    celdaCambioFinal = 17;
                }
                Microsoft.Office.Interop.Excel.Range rangoMerge = sheetExportacion.get_Range("A" + (celdaCambioFinal + 1), "A" + (ultimaCelda));
                rangoMerge.MergeCells = true;
                rangoMerge.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                rangoMerge.VerticalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                celdaCambioInicio = celdaCambioFinal + 1;

                //Establecemos los márgenes para la impresión.             
                sheetExportacion.PageSetup.PrintArea = "A1:H" + ultimaCelda;
                Microsoft.Office.Interop.Excel.Range aRange = sheetExportacion.get_Range("A20", "I" + ultimaCelda);
                aRange.Rows.AutoFit();
                xlApp.DisplayAlerts = false;


                Microsoft.Office.Interop.Excel.Range range = sheetExportacion.get_Range("A" + (8), "H" + (tabla.Rows.Count + 8));

                //Hacemos el Autofit de las tareas
                aRange = sheetExportacion.get_Range("A30", "A30");
                aRange.Rows.AutoFit();
                xlApp.DisplayAlerts = false;


               /* string rutaPDF = System.Windows.Forms.Application.StartupPath + "\\ultimoReporte.pdf";
                //MessageBox.Show("Guardado en " + rutaPDF); 
                sheetExportacion.ExportAsFixedFormat(
                Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF,
                rutaPDF,
                Microsoft.Office.Interop.Excel.XlFixedFormatQuality.xlQualityStandard,
                true,
                false,
                Type.Missing,
                Type.Missing,
                false);*/


                xlApp.Visible = true;
                xlApp.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized;

            }


        }



        public static string pathPlantillaFacturacion { get; set; }

        public static string pathPlantillaSinEncabezado { get; set; }
    }
}
