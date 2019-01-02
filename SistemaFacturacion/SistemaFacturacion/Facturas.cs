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
                pathPlantillaFacturacion = lines[0];//factura final
            }
            catch
            {
                Utilidades.mostrarMensajeValidacion("No se pudo leer la configuración. Verificar el archivo de paths.");
                System.Environment.Exit(1);
            }
        }


        public static string pathPlantillaFacturacion { get; set; }
        



        //CLASE UTILIZADA PARA LA GENERACIÓN DE LA FACTURA, PLANTILLA FINAL 
        public static void generarFacturaFinal(DataTable tabla_facturacion)
        {

            //Primero recibe los registros del DataTable
            if (tabla_facturacion == null)
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
                   xlWorkBook.Close(0);


                //Comenzamos a trabajar con el workbook de exportación 
                //Asignamos un identificador para nuestro workbook 
                workbookExportacion = xlApp.ActiveWorkbook;
                Microsoft.Office.Interop.Excel.Sheets sheetsExportacion = workbookExportacion.Worksheets;
                Microsoft.Office.Interop.Excel.Worksheet sheetExportacion = xlApp.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;
                //Copiamos la tabla_facturacion de exportación al portaPapeles            
                Utilidades.CopyDataTableToClipboard(tabla_facturacion);
                Microsoft.Office.Interop.Excel.Range CR = sheetExportacion.Cells[8, 2] as Microsoft.Office.Interop.Excel.Range;
                CR.Select();
                //   sheetExportacion.Paste(CR, Clipboard.GetText());

                

                //iteración de la tabla creada sin encabezados
                for (int i = 0; i < tabla_facturacion.Rows.Count; i++)
                {

                    {
                        //REVISAR FORMATO DE FECHA
                        sheetExportacion.Cells[1, 2] = tabla_facturacion.Rows[i]["InvoiceDate"].ToString();
                        //VERDE
                        //sheetExportacion.Cells[4, 4] = "";
                        sheetExportacion.Cells[5, 4] = tabla_facturacion.Rows[i]["Name_1"].ToString();
                        //AMARILLO
                        // sheetExportacion.Cells[6, 4] = "";
                        //VERDE
                        sheetExportacion.Cells[7, 4] = tabla_facturacion.Rows[i]["City1_1"] + " " + tabla_facturacion.Rows[i]["Address1_1"] + "," + tabla_facturacion.Rows[i]["PostalCode1"] + "-0701".ToString();

                        //VERDE
                        sheetExportacion.Cells[8, 4] = tabla_facturacion.Rows[i]["Country_1"].ToString();
                        //AMARILLO
                        //sheetExportacion.Cells[9, 4] = "";
                        //sheetExportacion.Cells[12, 4] = "";
                        sheetExportacion.Cells[14, 4] = "PO# " + tabla_facturacion.Rows[0]["PoNo_1"].ToString();
                        sheetExportacion.Cells[15, 4] = "EDI COMPANY CODE: " + tabla_facturacion.Rows[0]["LegalEntity_1"].ToString();


                        //COLOR ROJO
                        //sheetExportacion.Cells[4, 6] = "";
                        //sheetExportacion.Cells[5, 6] = "";
                        //sheetExportacion.Cells[6, 6] = "";
                        //sheetExportacion.Cells[7, 6] = "";
                        //sheetExportacion.Cells[8, 6] = "";

                        //AMARILLO
                        //sheetExportacion.Cells[12, 6] = "";
                        //sheetExportacion.Cells[14, 6] = "";

                        //VERDE
                        //sheetExportacion.Cells[15, 6] = "";
                        //AMARILLO
                        //sheetExportacion.Cells[17, 4] = "";

                        //VERDE
                        sheetExportacion.Cells[45, 4] = "ALL PRICES ARE " + tabla_facturacion.Rows[i]["Currency_1"].ToString(); ;

                        //VERDE
                        sheetExportacion.Cells[44, 8] = tabla_facturacion.Rows[i]["InvoiceAmount"].ToString();
                        for (int x = 0; x < tabla_facturacion.Rows.Count; x++)
                        {

                            sheetExportacion.Cells[(1 * x) + 22, 2] = tabla_facturacion.Rows[x]["Quantity"].ToString();
                            sheetExportacion.Cells[(1 * x) +22, 7] = tabla_facturacion.Rows[x]["NetPrice"].ToString();
                            sheetExportacion.Cells[(1 * x)+22, 8] = tabla_facturacion.Rows[x]["LineItemAmount"].ToString();

                        }
                      
                    }
                   
                    
                    
                    //Obtenemos los límites de la hoja
                    /*int cantidadRegistros = tabla_facturacion.Rows.Count;
                    int ultimaCelda = (cantidadRegistros) + 50;

                    
                    //Establecemos los márgenes para la impresión.             
                    sheetExportacion.PageSetup.PrintArea = "A1:H" + ultimaCelda;
                    Microsoft.Office.Interop.Excel.Range aRange = sheetExportacion.get_Range("A20", "I" + ultimaCelda);
                    aRange.Rows.AutoFit();
                    xlApp.DisplayAlerts = false;


                    Microsoft.Office.Interop.Excel.Range range = sheetExportacion.get_Range("A" + (8), "H" + (tabla_facturacion.Rows.Count + 8));

                    //Hacemos el Autofit de las tareas
                    aRange = sheetExportacion.get_Range("A40", "A40");
                    aRange.Rows.AutoFit();*/
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
        }
    }
}
