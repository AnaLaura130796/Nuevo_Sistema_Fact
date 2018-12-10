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
    public partial class FormFacturacion : Form
    {
        public FormFacturacion()
        {
            InitializeComponent();
        }

       

        private void button_llenar_datos_Click(object sender, EventArgs e)
        {
            Form_datos_sin_captura ventanaCambio = new Form_datos_sin_captura();
            ventanaCambio.ShowDialog();
            MessageBox.Show(ventanaCambio.richTextBoxnombre1.Text); 
             

        }

   
        private void button_busca_archivo_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            using (OpenFileDialog openfiledialog = new OpenFileDialog())
            {   //abrirá en la ruta donde esta el archivo a entrar
                openfiledialog.InitialDirectory = "C:\\Users\\PMM\\Desktop\\sistemas\\SFacturacion\\plantillas";
                openfiledialog.RestoreDirectory = true;
                //solo muestra los archivos de este tipo
                openfiledialog.Filter = "xlsx files (*,.xlsx)|*.xlsx";
                if (openfiledialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openfiledialog.FileName;
                    DataBase.pathBaseDeDatos = filePath;
                }
            }

        }
    }
}
