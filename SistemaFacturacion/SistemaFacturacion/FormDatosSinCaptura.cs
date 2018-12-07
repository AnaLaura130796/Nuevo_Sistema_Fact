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
    public partial class Form_datos_sin_captura : Form
    {
        public Form_datos_sin_captura()
        {
            InitializeComponent();
        }
        public void llenar_informacion()
        {
            if (DataBase.pathBaseDeDatos == null)
            {
                MessageBox.Show("No encontré nada en pathBaseDeDatos, es nula");
                return;
            }
            else
            {
               //traer del query que contiene los datos que no cambian para llenar los textbox
                string query_entrada = string.Format("SELECT" +
              "F1 as PoNo_1 " +          //siempre el mismo  
              ", F2 as Currency_1 " +      //siempre el mismo
              ", F3 as BIL " +             //Siempre el mismo
              ", F4 as SapBox " +          //siempre el mismo
              ", F5 as LegalEntity_1 " +    //siempre el mismo
              ", F6 as LE_Country" +        //siempre el mismo
              ", F7 as Name_Lab " +         //siempre el mismo
              ", F8 as Address_a " +       //siempre el mismo
              ", F9 as Address1_1 " +      //siempre el mismo
              ", F10 as City1_1 " +        //siempre el mismo
              ", F11 as PostalCode_A " +   //siempre el mismo
              ", F12 as Country_1 " +      //siempre el mismo
              ", F13 as Name_No " +    //siempre el mismo
              ", F14 as Name_Vendor " +    //siempre el mismo
              ", F15 as Address1_2" +       //siempre el mismo
              ", F16 as Address2 " +        //siempre el mismo  
              ", F17 as City1_2 " +         //siempre el mismo
              ", F18 as Country_2 " +       //siempre el mismo
              ", F19 as UoM " +            //siempre el mismo
              ", F20 as TaxAmount_2 " +        //siempre el mismo
              ", F22 as TaxRate_b " +          //siempre el mismo
              ", F23 as InvoiceType " +         //siempre el mismo
              ", F24 as TaxAmount1 " +      //siempre el mismo
              "FROM  [{0}$] WHERE F5<>'Currency'", "hoja_entrada");
                tabla_facturacion = DataBase.runSelectQuery(query_entrada);
                MessageBox.Show("query_entrada contiene:" + query_entrada);

                richTextBoxPoNo.Text = tabla_facturacion.Rows[0]["PoNo_1"].ToString();
                richTextBoxCurrency.Text = tabla_facturacion.Rows[0]["Currency_1"].ToString();
                richTextBoxbil.Text = tabla_facturacion.Rows[0]["BIL"].ToString();
                richTextBoxSapBox.Text = tabla_facturacion.Rows[0]["SapBox"].ToString();
                richTextBoxLegalEntity.Text = tabla_facturacion.Rows[0]["LegalEntity_1"].ToString();
                richTextBoxLECountry.Text = tabla_facturacion.Rows[0]["LE_Country"].ToString();
                richTextBoxnombre1.Text = tabla_facturacion.Rows[0]["Name_Lab"].ToString();
                richTextBoxaddress1.Text = tabla_facturacion.Rows[0]["Address_a"].ToString();
                richTextBoxaddress2.Text = tabla_facturacion.Rows[0]["Address1_1"].ToString();
                richTextBoxcity.Text = tabla_facturacion.Rows[0]["City1_1"].ToString();
                richTextBoxPostalCode.Text = tabla_facturacion.Rows[0]["PostalCode_A"].ToString();
                richTextBoxCountry.Text = tabla_facturacion.Rows[0]["Country_1"].ToString();
                richTextBoxVendorNo.Text = tabla_facturacion.Rows[0]["Name_No"].ToString();
                richTextBoxVendorName.Text = tabla_facturacion.Rows[0]["Name_Vendor"].ToString();
                richTextBoxVendorAddress1.Text = tabla_facturacion.Rows[0]["Address1_2"].ToString();
                richTextBoxVendorAddress2.Text = tabla_facturacion.Rows[0]["Address2"].ToString();
                richTextBoxVendorCity.Text = tabla_facturacion.Rows[0]["City1_2"].ToString();
                richTextBoxVendorCountry.Text = tabla_facturacion.Rows[0]["Country_2"].ToString();
                richTextBoxUoM.Text = tabla_facturacion.Rows[0]["UoM"].ToString();
                richTextBoxTaxAmount.Text = tabla_facturacion.Rows[0]["TaxAmount_2"].ToString();
                richTextBoxTaxRate.Text = tabla_facturacion.Rows[0]["TaxRate_b"].ToString();
                richTextBoxInvoiceType.Text = tabla_facturacion.Rows[0]["InvoiceType"].ToString();
                richTextBoxTaxAmount1.Text = tabla_facturacion.Rows[0]["TaxAmount1"].ToString();


            }
            
        }
        DataTable tabla_facturacion;
        private void groupBox_SM_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label_LegalEntity_Click(object sender, EventArgs e)
        {

        }

        private void button_siguiente_Click(object sender, EventArgs e)
        {
            FormDatosCapturados venatanaCambio = new FormDatosCapturados();
            venatanaCambio.ShowDialog();
            //es necesaria una validación para que estén llenos todos los campos

        }

        private void label_UoM_Click(object sender, EventArgs e)
        {

        }

        private void label_currency_Click(object sender, EventArgs e)
        {

        }

        private void label_country_Click(object sender, EventArgs e)
        {

        }

        private void Form_datos_sin_captura_Load(object sender, EventArgs e)
        {

        }

        private void richTextBoxVendorAddress2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
