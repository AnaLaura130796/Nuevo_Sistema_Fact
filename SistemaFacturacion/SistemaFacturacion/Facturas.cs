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



        public static void generarFactura(DataTable tabla)
        {
            try
            {
                int columnas = 0;
                if (tabla == null)
                {
                    Utilidades.mostrarMensajeValidacion("No se encontro la infromación");
                    return;
                }
                //Creamos una nueva aplicación de excel. 
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                //Abrimos la plantilla de reportes y creamos un nuevo workbook para mostrar ahí el reporte.
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook = xlApp.Workbooks.Add();
                //Obtenemos todas las hojas de la plantilla 
                Microsoft.Office.Interop.Excel.Sheets sheets = xlWorkBook.Worksheets;
                //Obtenemos la primera hoja de la plantilla 
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = xlApp.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;
                //Copiamos la tabla en el portapapeles con el encabezado.
                Utilidades.CopyDataTableToClipboard(tabla, false);
                int inicio_y_tabla = 1;
                int inicio_x_tabla = 1;
                //Colocamos la fecha de eleboración del reporte. 
                //xlWorkSheet.Cells[1, inicio_x_tabla + columnas - 1] = "'" + DateTime.Now.ToString("dd/MM/yyyy");
                // xlWorkSheet.Cells[1, inicio_x_tabla + columnas - 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                //Combinamos la celda del encabezado. 				
                // xlWorkSheet.Range[xlWorkSheet.Cells[2, inicio_x_tabla], xlWorkSheet.Cells[2, columnas + inicio_x_tabla - 1]].Merge();
                //xlWorkSheet.Range[xlWorkSheet.Cells[2, inicio_x_tabla], xlWorkSheet.Cells[2, columnas + inicio_x_tabla - 1]].Font.size = 15;
                //xlWorkSheet.Range[xlWorkSheet.Cells[2, inicio_x_tabla], xlWorkSheet.Cells[2, columnas + inicio_x_tabla - 1]].Font.bold = true;
                //xlWorkSheet.Range[xlWorkSheet.Cells[2, inicio_x_tabla], xlWorkSheet.Cells[2, columnas + inicio_x_tabla - 1]].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                // xlWorkSheet.Cells[2, inicio_x_tabla] = encabezado;
                //Pegamos nuestra tabla para la generación del reporte. 
                Microsoft.Office.Interop.Excel.Range CR = xlWorkSheet.Cells[inicio_y_tabla, inicio_x_tabla] as Microsoft.Office.Interop.Excel.Range;
                CR.Select();
                xlWorkSheet.Paste();
                //Colocamos los bordes de las celdas 
                //xlWorkSheet.Range[xlWorkSheet.Cells[inicio_y_tabla, inicio_x_tabla], xlWorkSheet.Cells[tabla.Rows.Count + inicio_y_tabla, columnas + inicio_x_tabla - 1]].borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                //xlWorkSheet.Range[xlWorkSheet.Cells[inicio_y_tabla, inicio_x_tabla], xlWorkSheet.Cells[tabla.Rows.Count + inicio_y_tabla, columnas + inicio_x_tabla - 1]].borders.Weight = 2d;
                //Se ponen todas las columnas del mismo ancho. 
                xlWorkSheet.Range[xlWorkSheet.Cells[inicio_y_tabla, 1], xlWorkSheet.Cells[tabla.Rows.Count + inicio_y_tabla, columnas + inicio_x_tabla]].ColumnWidth = 25;
                //Coloreamos los encabezados de las celdas. 
                //xlWorkSheet.Range[xlWorkSheet.Cells[inicio_y_tabla, inicio_x_tabla], xlWorkSheet.Cells[inicio_y_tabla, columnas + inicio_x_tabla - 1]].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue);
                //xlWorkSheet.Range[xlWorkSheet.Cells[inicio_y_tabla, inicio_x_tabla], xlWorkSheet.Cells[inicio_y_tabla, columnas + inicio_x_tabla - 1]].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                string letra = obtenerLetraDeRango(columnas + inicio_x_tabla);
                //Establecemos los márgenes para la impresión y hacemos autoFit
                xlWorkSheet.PageSetup.PrintArea = "";
                xlWorkSheet.PageSetup.PrintArea = string.Format("A1:{0}{1}", letra, tabla.Rows.Count + inicio_y_tabla);
                Microsoft.Office.Interop.Excel.Range aRange = xlWorkSheet.Range[xlWorkSheet.Cells[1, 1], xlWorkSheet.Cells[tabla.Rows.Count + inicio_y_tabla, columnas + inicio_x_tabla]];
                aRange.Rows.AutoFit();
                /*string rutaPDF = System.Windows.Forms.Application.StartupPath + "\\ultimoReporte.pdf";
                        //MessageBox.Show("Guardado en " + rutaPDF); 
                        xlWorkSheet.ExportAsFixedFormat(
                        Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF,
                        rutaPDF,
                        Microsoft.Office.Interop.Excel.XlFixedFormatQuality.xlQualityStandard,
                        true,
                        false,
                        Type.Missing,
                        Type.Missing,
                        false);*/
                xlApp.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized;
                xlApp.Visible = true;
                xlApp.DisplayAlerts = true;
                //xlWorkBook.WindowDeactivate += cerrarExcel;
            }
            catch
            {
                Utilidades.mostrarMensajeValidacion("NO NO FUNCIONA");
            }
        }
        private static string obtenerLetraDeRango(int numero)
        {
            int A = 65 - 1;

            int letra = A + numero;
            return Encoding.ASCII.GetString(new byte[] { byte.Parse(letra.ToString()) });
        }
        private static void cerrarExcel(Microsoft.Office.Interop.Excel.Window Wn)
        {
            Wn.Application.Quit();
            Utilidades.matarProcesoDeExcel(Wn.Application);
        }
        public static void generar_impresa(DataTable tabla)
        {
            //Primero recibe los registros del DataTable
            if (tabla == null)
            {
                MessageBox.Show("No se han encontrado registros");
            }
            else
            {
                Facturas.getPaths();
                //   object misValue = System.Reflection.Missing.Value;  //configuraciones 

                //Creamos una nueva aplicación de excel. 
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                //Abrimos la plantilla de reportes y creamos un nuevo workbook para mostrar ahí el reporte. 
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(Facturas.pathPlantillaFacturacion);
                Microsoft.Office.Interop.Excel.Workbook workbookExportacion;
                //Obtenemos todas las hojas de la plantilla 
                Microsoft.Office.Interop.Excel.Sheets sheets = xlWorkBook.Worksheets;

                //Obtenemos la primera hoja de la plantilla 
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = xlApp.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;

                //Se copia la hoja actual y se coloca automáticamente en un nuevo workbook. 
                xlWorkSheet.Copy(Type.Missing, Type.Missing);

                //Cerramos la plantilla original de excel. 
                //    xlWorkBook.Close(0);


                //Comenzamos a trabajar con el workbook de exportación 
                //Asignamos un identificador para nuestro workbook 
                workbookExportacion = xlApp.ActiveWorkbook;
                Microsoft.Office.Interop.Excel.Sheets sheetsExportacion = workbookExportacion.Worksheets;
                Microsoft.Office.Interop.Excel.Worksheet sheetExportacion = xlApp.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;
                //Copiamos la tabla de exportación al portaPapeles            
                Utilidades.CopyDataTableToClipboard(tabla);
                Microsoft.Office.Interop.Excel.Range CR = sheetExportacion.Cells[8, 2] as Microsoft.Office.Interop.Excel.Range;
                CR.Select();
                //   sheetExportacion.Paste(CR, Clipboard.GetText());


                sheetExportacion.Cells[2, 1] = "HOLA";
                //iteración de la tabla creada sin encabezados
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    sheetExportacion.Cells[2, 3] = "PROCTER & GAMBLE";
                    sheetExportacion.Cells[3, 3] = tabla.Rows[i]["Address_a"].ToString();
                    sheetExportacion.Cells[4, 3] = tabla.Rows[i]["Address1_1"].ToString();
                    sheetExportacion.Cells[5, 3] = tabla.Rows[i]["City1_1"].ToString();
                    sheetExportacion.Cells[6, 3] = tabla.Rows[i]["PostalCode_A"].ToString();
                    sheetExportacion.Cells[7, 3] = tabla.Rows[i]["Country_1"].ToString();
                    sheetExportacion.Cells[8, 3] = tabla.Rows[i]["PostalCode_A"].ToString();
                    sheetExportacion.Cells[9, 3] = tabla.Rows[i]["Currency_1"].ToString();


                    sheetExportacion.Cells[2, 6] = tabla.Rows[i]["Name_Lab"].ToString();
                    sheetExportacion.Cells[3, 6] = tabla.Rows[i]["Address1_2"].ToString();
                    sheetExportacion.Cells[4, 6] = tabla.Rows[i]["Address2"].ToString();
                    sheetExportacion.Cells[5, 6] = tabla.Rows[i]["City1_2"].ToString();
                    sheetExportacion.Cells[6, 6] = tabla.Rows[i]["Country_2"].ToString();
                    sheetExportacion.Cells[7, 3] = tabla.Rows[i]["PostalCode_A"].ToString();
                    sheetExportacion.Cells[7, 6] = tabla.Rows[i]["Currency_1"].ToString();

                    sheetExportacion.Cells[10, 2] = tabla.Rows[i]["InvoiceDate"].ToString();
                    sheetExportacion.Cells[11, 2] = tabla.Rows[i]["PoNo_1"].ToString();
                    sheetExportacion.Cells[12, 2] = tabla.Rows[i]["LegalEntity_1"].ToString();

                    sheetExportacion.Cells[13, 2] = tabla.Rows[i]["Vendor_No"].ToString();
                    sheetExportacion.Cells[14, 2] = tabla.Rows[i]["Name_Vendor"].ToString();


                    //    sheetExportacion.Cells[26, 2] = tabla.Rows[i]["LineItemNumber"].ToString();
                    sheetExportacion.Cells[22, 2] = tabla.Rows[i]["Quantity_1"].ToString();
                    sheetExportacion.Cells[22, 3] = tabla.Rows[i]["UoM"].ToString();
                    sheetExportacion.Cells[22, 4] = tabla.Rows[i]["NetPrice"].ToString();
                    sheetExportacion.Cells[22, 5] = tabla.Rows[i]["LineItemAmount"].ToString();
                    // sheetExportacion.Cells[10, 2] = tabla.Rows[i]["MaterialNumber"].ToString();
                    sheetExportacion.Cells[22, 6] = tabla.Rows[i]["InvoiceAmount"].ToString();
                    sheetExportacion.Cells[22, 5] = tabla.Rows[i]["LineItemAmount"].ToString();
                    sheetExportacion.Cells[15, 5] = tabla.Rows[i]["TaxAmount_2"].ToString();
                    sheetExportacion.Cells[14, 5] = tabla.Rows[i]["TaxRate_b"].ToString();
                    sheetExportacion.Cells[22, 7] = tabla.Rows[i]["InvoiceType"].ToString();





                }
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


                string rutaPDF = System.Windows.Forms.Application.StartupPath + "\\ultimoReporte.pdf";
                //MessageBox.Show("Guardado en " + rutaPDF); 
                sheetExportacion.ExportAsFixedFormat(
                Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF,
                rutaPDF,
                Microsoft.Office.Interop.Excel.XlFixedFormatQuality.xlQualityStandard,
                true,
                false,
                Type.Missing,
                Type.Missing,
                false);


                xlApp.Visible = true;
                xlApp.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized;

            }


        }



        public static string pathPlantillaFacturacion { get; set; }

        public static string pathPlantillaSinEncabezado { get; set; }
    }
}
