using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion
{
    public partial class FormDatosCapturados : Form
    {
        public FormDatosCapturados()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_agregar_mas_registros_Click(object sender, EventArgs e)
        {

        }

        private void button_genera_factura_Click(object sender, EventArgs e)
        {
            //Generar la factura impresa
            //Abriras un nuevo archivo de excel y vaciaras la información en el formato para la representación impresa. 
            //Iterar con la tabla en un ciclo for. 
            Facturas.generar_impresa(tabla_facturacion);

        }

        private void FormDatosCapturados_Load(object sender, EventArgs e)
        {

        }

        private void button_generar_excel_sin_encabezados_Click(object sender, EventArgs e)
        {   //Generar el archivo excel sin encabezados
            Facturas.generarFactura(tabla_facturacion);

        }
        DataTable tabla_facturacion;

    }
}
