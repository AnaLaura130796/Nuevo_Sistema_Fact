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

    class Utilidades
    {

        public static void mostrarMensajeValidacion(string mensaje)
        {
            MessageBox.Show(mensaje,
            "Aviso",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button1);
        }
        internal static void exportarTablaExcel(DataTable tabla)
        {

            try
            {
                if (tabla == null)
                {
                    Utilidades.mostrarMensajeValidacion("No se encontró información en la tabla para exportación. Contacta a Aseguramiento de calidad.");
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
                //Pegamos nuestra tabla para la generación del reporte. 
                
                Microsoft.Office.Interop.Excel.Range CR = xlWorkSheet.Cells[1, 1] as Microsoft.Office.Interop.Excel.Range;
                CR.Select();

                xlWorkSheet.Paste();

                //Código para quitar la primera fila. 
                Microsoft.Office.Interop.Excel.Range primera_celda = xlWorkSheet.Cells[1, 1] as Microsoft.Office.Interop.Excel.Range;
                primera_celda.EntireRow.Delete(); 



                xlApp.Visible = true;



            }
            catch (Exception e)
            {
                Utilidades.mostrarMensajeValidacion(e.Message.ToString());

            }
        }


        private static void cerrarExcel(Microsoft.Office.Interop.Excel.Window Wn)
        {
            Wn.Application.Quit();
            Utilidades.matarProcesoDeExcel(Wn.Application);
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        public static void matarProcesoDeExcel(Microsoft.Office.Interop.Excel.Application xlApp)
        {
            uint processId = 0;
            GetWindowThreadProcessId(new IntPtr(xlApp.Hwnd), out processId);
            try
            {
                if (processId != 0)
                {
                    Process excelProcess = Process.GetProcessById((int)processId);
                    excelProcess.CloseMainWindow();
                    excelProcess.Refresh();
                    excelProcess.Kill();
                }
            }
            catch
            {
                // Process was already killed
            }
        }

        internal static void CopyDataTableToClipboard(DataTable DT, bool headerCopied = true)
        {
            if (DT == null)
            {
                Clipboard.SetText(" ");
                return;
            }
            if ((DT.Rows.Count == 0))
            {
                Clipboard.SetText(" ");
                return;
            }
            StringBuilder Output = new StringBuilder();

            //The first "line" will be the Headers.
            if (headerCopied)
            {
                for (int i = 0; i < DT.Columns.Count; i++)
                {
                    Output.Append(DT.Columns[i].ColumnName + "\t");
                }
            }

            Output.Append("\n");

            //Generate Cell Value Data
            foreach (DataRow Row in DT.Rows)
            {
                for (int i = 0; i < Row.ItemArray.Length; i++)
                {

                    //Handling the last cell of the line.
                    if (i == (Row.ItemArray.Length - 1))
                    {

                        Output.Append(Row.ItemArray[i].ToString() + "\n");
                    }
                    else
                    {

                        Output.Append(Row.ItemArray[i].ToString() + "\t");
                    }
                }

            }

            Clipboard.SetText(Output.ToString());
        }


        public static void verPDF(string path)
        {
            try
            {
                FormVistaPrevia vistaPrevia = new FormVistaPrevia();
                vistaPrevia.Navegar(path);
                vistaPrevia.Show();
                vistaPrevia.TopMost = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo leer el manual de usuario. \n" + ex.ToString());
            }
        }

       
    }
}